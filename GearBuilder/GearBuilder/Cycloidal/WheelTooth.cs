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
using GearBuilder.Common;

namespace GearBuilder.Cycloidal
{
	public class WheelTooth : Tooth
	{
		public Wheel Wheel { get; private set; }
		public Point AddendumCircleCenterLeft { get; private set; }
		public Point AddendumCircleCenterRight { get; private set; }

		public WheelTooth(Wheel wheel, double centerRayAngle)
			: base(wheel, centerRayAngle)
		{
			this.Wheel = wheel;

			// Arc from left intersection with pitch circle to apex
			Vector v1 = new Vector(this.Apex, this.PitchCircleIntersectRight);
			double halfArcAngle = Math.Asin(v1.Magnitude / this.Wheel.AddendumRadius / 2.0);

			double l = this.Wheel.AddendumRadius * Math.Cos(halfArcAngle);

			this.AddendumCircleCenterLeft = this.PitchCircleIntersectRight + v1 / 2 - v1.Normal * l;

			Vector v2 = new Vector(this.Apex, this.PitchCircleIntersectLeft);
			this.AddendumCircleCenterRight = this.PitchCircleIntersectLeft + v2 / 2 + v2.Normal * l;
		}
	}
}
