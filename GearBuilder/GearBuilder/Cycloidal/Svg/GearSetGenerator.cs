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
using GearBuilder;
using SvgNet.SvgTypes;
using SvgNet.SvgElements;
using GearBuilder.Common;
using GearBuilder.Common.Svg;

namespace GearBuilder.Cycloidal.Svg
{
	public class GearSetGenerator
	{
		private CycloidalGear m_CycloidalGear;

		public GearSetGenerator(CycloidalGear cycloidalGear)
		{
			m_CycloidalGear = cycloidalGear;
		}

		public string Build()
		{
			double border = 5; // border around grahics in mm

			Wheel wheel = m_CycloidalGear.Wheel;
			Pinion pinion = m_CycloidalGear.Pinion;

			double pageWidth = wheel.Addendum + wheel.PitchDiameter + pinion.PitchDiameter + pinion.Addendum + 2 * border;
			double pageHeight = 2 * wheel.Addendum + wheel.PitchDiameter + 2 * border;
			Page page = new Page((float)pageWidth, (float)pageHeight, SvgLengthType.SVG_LENGTHTYPE_MM);

			SvgSvgElement root = new SvgSvgElement(
				page.SvgLengthWidth, page.SvgLengthHeight,
				new SvgNumList(new float[] { - (float)(wheel.Addendum + wheel.PitchDiameter / 2.0 + border), -page.Height / 2, page.Width, page.Height }));

			wheel.Center = new Point(0, 0);
			pinion.Center = wheel.Center + new Vector(m_CycloidalGear.WheelPinionDistance, 0);

			new WheelGenerator().Build(m_CycloidalGear.Wheel, root);
			new PinionGenerator().Build(m_CycloidalGear.Pinion, root);

			return root.WriteSVGString(true);
		}
	}
}