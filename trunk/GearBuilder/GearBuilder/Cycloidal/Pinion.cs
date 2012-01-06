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
	public class Pinion : Gear
	{
		internal Pinion(CycloidalGear gearSet)
			: base(gearSet)
		{
		}

		internal override void Update()
		{
			this.PitchDiameter = this.GearSet.Module * this.ToothCount;
			if (base.GearSet.CustomSlopEnabled)
			{
				this.Dedendum = this.GearSet.Wheel.Addendum + base.GearSet.CustomSlop;
			}
			else
			{
				this.Dedendum = this.GearSet.Module * (this.GearSet.PracticalAddendumFactor + 0.4);
			}
			InitializeToothAngle();
			InitializeAddendum();
		}

		/// <summary>
		/// From http://www.csparks.com/watchmaking/CycloidalGears/index.jhtml:
		/// The nominal width of a tooth or a space when they are equally spaced is just pi/2, or about 1.57.
		/// For pinions, we will reduce the width of the tooth a bit. For pinions with 6-10 leaves, the tooth
		/// width at the pitch circle is 1.05. For pinions with 11 or more teeth the tooth width is 1.25. 
		/// </summary>
		private void InitializeToothAngle()
		{
			double factor = 0;
			if (this.ToothCount <= 10)
			{
				factor = 1.05;
			}
			else
			{
				factor = 1.25;
			}

			//factor = Math.PI / 2;
			this.HalfToothAngle = factor * this.GearSet.Module / this.PitchDiameter;
		}

		/// <summary>
		/// For details see the Profile - Leaves tables in http://www.csparks.com/watchmaking/CycloidalGears/index.jhtml
		/// </summary>
		private void InitializeAddendum()
		{
			if (this.ToothCount <= 7)
			{
				// high ogival
				this.Addendum = 0.855 * this.GearSet.Module;
				this.AddendumRadius = 1.050 * this.GearSet.Module;
			}
			else if (this.ToothCount == 8 || this.ToothCount == 9)
			{
				// medium ogival
				this.Addendum = 0.670 * this.GearSet.Module;
				this.AddendumRadius = 0.7 * this.GearSet.Module;
			}
			else if (this.ToothCount == 10)
			{
				// round top for small tooth
				this.Addendum = 0.525 * this.GearSet.Module;
				this.AddendumRadius = 0.525 * this.GearSet.Module;
			}
			else
			{
				// 11+ teeth, round top for wider tooth
				this.Addendum = 0.625 * this.GearSet.Module;
				this.AddendumRadius = 0.625 * this.GearSet.Module;
			}
		}

		public PinionTooth[] GetTeeth(double startAngle)
		{
			PinionTooth[] teeth = new PinionTooth[this.ToothCount];
			double angleBetweenTeeth = 2 * Math.PI / this.ToothCount;
			for (int i = 0; i < this.ToothCount; i++)
			{
				double centerRayAngle = startAngle + i * angleBetweenTeeth;
				teeth[i] = new PinionTooth(this, centerRayAngle);
			}

			return teeth;
		}
	}
}
