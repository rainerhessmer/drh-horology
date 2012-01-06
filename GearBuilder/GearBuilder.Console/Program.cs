using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace GearBuilder.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			XmlDocument doc = new XmlDocument();
			// Create the XML Declaration, and append it to XML document
			XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", null, null);
			doc.AppendChild(declaration);// Create the root element
			XmlElement root = doc.CreateElement("Library");

			XmlAttribute attribute = doc.CreateAttribute("xmlns");
			attribute.Value = "http://www.w3.org/2000/svg";
			root.Attributes.Append(attribute);

			attribute = doc.CreateAttribute("xmlns:xlink");
			attribute.Value = "http://www.w3.org/1999/xlink";
			root.Attributes.Append(attribute);


			doc.AppendChild(root);

			string xmlContent = doc.OuterXml;
		}
	}
}
