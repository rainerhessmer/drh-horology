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
	public abstract class Tooth
	{
		protected Gear Gear { get; private set; }
		public double CenterRayAngle { get; private set; }
		public Point Apex { get; private set; }
		public Point DedendumIntersectLeft { get; private set; }
		public Point DedendumIntersectRight { get; private set; }
		public Point PitchCircleIntersectLeft { get; private set; }
		public Point PitchCircleIntersectRight { get; private set; }

		internal Tooth(Gear gear, double centerRayAngle)
		{
			this.Gear = gear;

			this.CenterRayAngle = centerRayAngle;

			double radius = gear.PitchDiameter / 2.0 + gear.Addendum;

			this.Apex = new Point(
				gear.Center.X + Math.Cos(this.CenterRayAngle) * radius,
				gear.Center.Y + Math.Sin(this.CenterRayAngle) * radius);

			double leftFlankAngle = this.CenterRayAngle - gear.HalfToothAngle;
			double rightFlankAngle = this.CenterRayAngle + gear.HalfToothAngle;

			radius = gear.PitchDiameter / 2.0 - gear.Dedendum;
			this.DedendumIntersectLeft = new Point(
				gear.Center.X + Math.Cos(leftFlankAngle) * radius,
				gear.Center.Y + Math.Sin(leftFlankAngle) * radius);
			this.DedendumIntersectRight = new Point(
				gear.Center.X + Math.Cos(rightFlankAngle) * radius,
				gear.Center.Y + Math.Sin(rightFlankAngle) * radius);

			radius = gear.PitchDiameter / 2.0;
			this.PitchCircleIntersectLeft = new Point(
				gear.Center.X + Math.Cos(leftFlankAngle) * radius,
				gear.Center.Y + Math.Sin(leftFlankAngle) * radius);
			this.PitchCircleIntersectRight = new Point(
				gear.Center.X + Math.Cos(rightFlankAngle) * radius,
				gear.Center.Y + Math.Sin(rightFlankAngle) * radius);
		}
	}
}
