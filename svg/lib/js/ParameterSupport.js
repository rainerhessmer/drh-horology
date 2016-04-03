var ParameterSupport;
(function (ParameterSupport) {

  // Adopted openjscad.js and slightly enhanced to support calculated parameters that the user cannot modify
  function createParamControls(parameterDefinitions, parametersDiv) {
    var parametersTable = document.createElement("table");
    parametersTable.className = "parameterstable";
    parametersDiv.appendChild(parametersTable);

    parametersTable.innerHTML = "";
    var paramControls = [];
    var tableRows = [];
    for(var i = 0; i < parameterDefinitions.length; i++) {
      var errorprefix = "Error in parameter definition #"+(i+1)+": ";
      var paramDef = parameterDefinitions[i];
      if(!('name' in paramDef)) {
        throw new Error(errorprefix + "Should include a 'name' parameter");
      }
      var type = "text";
      if('type' in paramDef) {
        type = paramDef.type;
      }
      if( (type !== "text") && (type !== "int") && (type !== "float") && (type !== "choice") && (type !== "longtext") && (type !== "bool") ) {
        throw new Error(errorprefix + "Unknown parameter type '"+type+"'");
      }
      var initial;
      if('initial' in paramDef) {
        initial = paramDef.initial;
      }
      else if('default' in paramDef) {
        initial = paramDef['default'];
      }
      var control;
      if( (type == "text") || (type == "int") || (type == "float") ) {
        control = document.createElement("input");
        control.type = "text";
        if(initial !== undefined) {
          control.value = initial;
        }
        else {
          if( (type == "int") || (type == "float") ) {
            control.value = "0";
          }
          else {
            control.value = "";
          }
        }
      }
      else if(type == "choice") {
        if(!('values' in paramDef)) {
          throw new Error(errorprefix + "Should include a 'values' parameter");
        }        
        control = document.createElement("select");
        var values = paramDef.values;
        var captions;
        if('captions' in paramDef) {
          captions = paramDef.captions;
          if(captions.length != values.length) {
            throw new Error(errorprefix + "'captions' and 'values' should have the same number of items");
          }
        }
        else {
          captions = values;
        }
        var selectedindex = 0;
        for(var valueindex = 0; valueindex < values.length; valueindex++) {
          var option = document.createElement("option");
          option.value = values[valueindex];
          option.text = captions[valueindex];
          control.add(option);
          if(initial !== undefined) {
            if(initial == values[valueindex]) {
              selectedindex = valueindex;
            }
          }
        }
        if(values.length > 0) {
          control.selectedIndex = selectedindex;
        }        
      }
      else if(type == "longtext") {
        control = document.createElement("textarea");
        if(initial !== undefined) {
          control.value = initial;
        }
        else {
          control.value = "";
        }
      }
      else if(type == "bool") {
        control = document.createElement("input");
        control.type = "checkbox";
        if(initial !== undefined) {
          if(typeof(initial) != "boolean") {
            throw new Error(errorprefix + "initial/default of type 'bool' has to be boolean (true/false)");
          }
          control.checked = initial;
        }
        else {
          control.checked = false;
        }
      }
      if(!('isCalculated' in paramDef)) {
        paramDef.isCalculated = false;
      }

      if (paramDef.isCalculated) {
        control.readOnly = paramDef.isCalculated;
        control.style.backgroundColor = 'LightGrey';        
      }
      paramDef.control = control;
      paramControls.push(control);
      var tr = document.createElement("tr");
      var td = document.createElement("td");
      var label = paramDef.name + ":";
      if('caption' in paramDef) {
        label = paramDef.caption;
      }
      if('visible' in paramDef) {
        tr.style.display = (paramDef.visible) ? "table-row" : "none";
      }
       
      td.innerHTML = label;
      tr.appendChild(td);
      td = document.createElement("td");
      td.appendChild(control);
      tr.appendChild(td);
      tableRows.push(tr);

      // Associating getters and setters
    }
    tableRows.map(function(tr){
      parametersTable.appendChild(tr);
    });     
  }
  ParameterSupport.createParamControls = createParamControls;

  function injectFromUI(parameterDefinitions, target) {
    for(var i = 0; i < parameterDefinitions.length; i++) {
      var paramDef = parameterDefinitions[i];
      var type = "text";
      if('type' in paramDef) {
        type = paramDef.type;
      }
      var control = paramDef.control;
      var value;
      if( (type == "text") || (type == "longtext") || (type == "float") || (type == "int") ) {
        value = control.value;
        if( (type == "float") || (type == "int") ) {
          var isnumber = !isNaN(parseFloat(value)) && isFinite(value);
          if(!isnumber) {
            throw new Error("Not a number: "+value);
          }
          if(type == "int") {
            value = parseInt(value);
          }
          else {
            value = parseFloat(value);
          }
        }
      }
      else if(type == "choice") {
        value = control.options[control.selectedIndex].value;
      }
      else if(type == "bool") {
        value = control.checked;
      }
      target[paramDef.name] = value;
    }
  }
  ParameterSupport.injectFromUI = injectFromUI;

  // for now we only support parameters that are represented by a text control
  function writeToUI(parameterDefinitions, paramValues) {
    for(var i = 0; i < parameterDefinitions.length; i++) {
      var paramDef = parameterDefinitions[i];
      if (paramDef.isCalculated) {
        paramDef.control.value = paramValues[paramDef.name]
      }
    }
  }
  ParameterSupport.writeToUI = writeToUI;

})(ParameterSupport || (ParameterSupport = {}));