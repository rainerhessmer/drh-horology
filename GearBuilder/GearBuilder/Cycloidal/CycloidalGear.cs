// Ported from http://www.csparks.com/watchmaking/CycloidalGears/CycloidCalculator.html
// more info here: http://www.csparks.com/watchmaking/CycloidalGears/index.jhtml

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
using SvgNet.SvgTypes;
using GearBuilder.Common;

namespace GearBuilder.Cycloidal
{
	public class CycloidalGear
	{
		private const double c_ErrorLimit = 0.000001;

		#region Inputs
		private double m_Module;
		public double Module
		{
			get { return m_Module; }
			set
			{
				m_Module = value;
				Update();
			}
		}

		/// <summary>
		/// The slop in mm between the apex of one gear and the trough of the other. Only used if custom slop is enabled.
		/// http://www.csparks.com/watchmaking/CycloidalGears/index.jhtml is used.
		/// </summary>
		private double m_CustomSlop;
		public double CustomSlop
		{
			get { return m_CustomSlop; }
			set
			{
				m_CustomSlop = value;
				Update();
			}
		}

		private bool m_CustomSlopEnabled;
		public bool CustomSlopEnabled
		{
			get { return m_CustomSlopEnabled; }
			set
			{
				m_CustomSlopEnabled = value;
				Update();
			}
		}

		#endregion

		public Wheel Wheel { get; private set; }
		public Pinion Pinion { get; private set; }

		#region Outputs
		public double AddendumFactor { get; private set; }
		public double PracticalAddendumFactor { get; private set; }
		public double GearRatio { get; private set; }
		public double CircularPitch { get; private set; }
		public double WheelPinionDistance { get; private set; }
		#endregion

		public CycloidalGear()
		{
			this.Wheel = new Wheel(this);
			this.Pinion = new Pinion(this);
		}

		internal void Update()
		{
			if (this.Pinion.ToothCount <= 0 || this.Wheel.ToothCount <= 0 || this.Module <= 0)
			{
				// TODO: set all outputs to zero
			}
			else
			{
				this.AddendumFactor = CalcAddendumFactor(this.Wheel.ToothCount, this.Pinion.ToothCount);
				this.PracticalAddendumFactor = 0.95 * this.AddendumFactor;
				this.GearRatio = this.Wheel.ToothCount / this.Pinion.ToothCount;

				this.CircularPitch = this.Module * Math.PI;
			}

			this.Wheel.Update();
			this.Pinion.Update();
			this.WheelPinionDistance = (this.Wheel.PitchDiameter + this.Pinion.PitchDiameter) / 2.0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="nw">wheel count</param>
		/// <param name="np">pinion count</param>
		/// <returns></returns>
		public double CalcAddendumFactor(int nw, int np)
		{
			double beta = 0.0;
			double theta = 1.0 ;
			double thetaNew = 0.0 ;
			double R = (double)nw / (double)np; // gear ratio
			while (Math.Abs(thetaNew - theta) > c_ErrorLimit)
			{
				theta = thetaNew;
				beta = Math.Atan2(Math.Sin(theta), (1.0 + 2 * R - Math.Cos(theta))) ;
				thetaNew = Math.PI/(double)np + 2 * R * beta ;	
			}

			theta = thetaNew;

			double k = 1.0 + 2 * R;

			// Addendum factor af
			double af = np / 4.0 * (1.0 - k + Math.Sqrt( 1.0 + k * k - 2.0 * k * Math.Cos(theta)) );
			return af;
		}
	}
}
