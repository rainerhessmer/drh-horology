using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SvgNet.SvgTypes;

namespace GearBuilder.Common.Svg
{
	public static class Styles
	{
		public static readonly SvgStyle MinorLineStyle = "fill:none;stroke:#000000;stroke-opacity:1;stroke-width:0.05;stroke-miterlimit:4;stroke-dasharray:none";
		public static readonly SvgStyle HelperLineStyle = "fill:none;stroke:#0000ff;stroke-opacity:1;stroke-width:0.05;stroke-miterlimit:4;stroke-dasharray:none";
		public static readonly SvgStyle NormalLineStyle = "fill:none;stroke:#000000;stroke-opacity:1;stroke-width:0.1;stroke-miterlimit:4;stroke-dasharray:none";
		public static readonly SvgStyle MajorLineStyle = "fill:none;stroke:#000000;stroke-opacity:1;stroke-width:0.2;stroke-miterlimit:4;stroke-dasharray:none";

		public static readonly SvgStyle FilledBlack = "fill:#000000;stroke:none;fill-opacity:1";
		public static readonly SvgStyle FilledWhite = "fill:#ffffff;stroke:none;fill-opacity:1";
	}
}
