/****************************************************************************
Copyright (c) 2012 Dr. Rainer Hessmer

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SvgNet.SvgElements;
using GearBuilder.Common.Svg;
using SvgNet.SvgTypes;

namespace GearBuilder.Cycloidal.Svg
{
	internal class WheelGenerator
	{
		internal void Build(Wheel wheel, SvgSvgElement root)
		{
			SvgGroupElement helperLinesGroup = new SvgGroupElement("HelperLines");
			helperLinesGroup.Style = Styles.HelperLineStyle;
			root.AddChild(helperLinesGroup);

			// Wheel pitch circle
			helperLinesGroup.AddChild(SvgHelper.CreateCircle(wheel.Center, wheel.PitchDiameter / 2.0));

			// Wheel addendum circle
			helperLinesGroup.AddChild(SvgHelper.CreateCircle(wheel.Center, wheel.PitchDiameter / 2.0 + wheel.Addendum));

			// Wheel dedendum circle
			helperLinesGroup.AddChild(SvgHelper.CreateCircle(wheel.Center, wheel.PitchDiameter / 2.0 - wheel.Dedendum));

			// wheel center
			double halfCrossLength = 10;
			helperLinesGroup.AddChild(new SvgLineElement(wheel.Center.X - halfCrossLength, wheel.Center.Y, wheel.Center.X + halfCrossLength, wheel.Center.Y));
			helperLinesGroup.AddChild(new SvgLineElement(wheel.Center.X, wheel.Center.Y - halfCrossLength, wheel.Center.X, wheel.Center.Y + halfCrossLength));


			SvgGroupElement mainGroup = new SvgGroupElement("Main");
			mainGroup.Style = Styles.MinorLineStyle;
			root.AddChild(mainGroup);


			WheelTooth[] teeth = wheel.GetTeeth(0);
			StringBuilder pathBuilder = new StringBuilder();

			pathBuilder.AppendFormat("M{0},{1}", (float)teeth[0].DedendumIntersectLeft.X, (float)teeth[0].DedendumIntersectLeft.Y);
			for (int i = 0; i < teeth.Length; i++)
			{
				WheelTooth tooth = teeth[i];
				WheelTooth nextTooth = teeth[(i + 1) % teeth.Length];
				InsertWheelToothPath(wheel, tooth, nextTooth, pathBuilder);
			}
			pathBuilder.Append(" z");

			SvgPath svgPath = new SvgPath(pathBuilder.ToString());
			SvgPathElement svgPathElement = new SvgPathElement();
			svgPathElement.D = svgPath;

			mainGroup.AddChild(svgPathElement);

			if (wheel.CenterHoleDiameter > 0)
			{
				mainGroup.AddChild(SvgHelper.CreateCircle(wheel.Center, wheel.CenterHoleDiameter / 2.0));
			}
		}

		private void InsertWheelToothPath(Wheel wheel, WheelTooth tooth, WheelTooth nextTooth, StringBuilder pathBuilder)
		{
			pathBuilder.AppendFormat(" L{0},{1}", (float)tooth.PitchCircleIntersectLeft.X, (float)tooth.PitchCircleIntersectLeft.Y);

			pathBuilder.AppendFormat(
				" A{0},{1} 0 0,1 {2},{3}",
				(float)wheel.AddendumRadius, (float)wheel.AddendumRadius,
				(float)tooth.Apex.X, (float)tooth.Apex.Y);

			pathBuilder.AppendFormat(
				" A{0},{1} 0 0,1 {2},{3}",
				(float)wheel.AddendumRadius, (float)wheel.AddendumRadius,
				(float)tooth.PitchCircleIntersectRight.X, (float)tooth.PitchCircleIntersectRight.Y);

			pathBuilder.AppendFormat(" L{0},{1}", (float)tooth.DedendumIntersectRight.X, (float)tooth.DedendumIntersectRight.Y);

			double radius = wheel.PitchDiameter / 2.0 - wheel.Dedendum;
			pathBuilder.AppendFormat(
				" A{0},{1} 0 0,1 {2},{3}",
				(float)radius, (float)radius,
				(float)nextTooth.DedendumIntersectLeft.X, (float)nextTooth.DedendumIntersectLeft.Y);
		}
	}
}