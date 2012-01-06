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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GearBuilder.Cycloidal;
using System.IO;
using GearBuilder.Cycloidal.Svg;

namespace GearBuilder.UI
{
	public partial class MainForm : Form
	{
		private CycloidalGear m_CycloidalGear = new CycloidalGear();

		public MainForm()
		{
			InitializeComponent();

			m_CycloidalGear.Module = 4;
			m_CycloidalGear.Wheel.ToothCount = 30;
			m_CycloidalGear.Pinion.ToothCount = 6;

			m_CycloidalGear.Wheel.CenterHoleDiameter = 6;
			m_CycloidalGear.Pinion.CenterHoleDiameter = 6;

			UpdateFromModel();
		}

		private void OnInputLeave(object sender, EventArgs e)
		{
			double doubleValue;
			if (Double.TryParse(m_ModuleTextBox.Text, out doubleValue))
			{
				m_CycloidalGear.Module = doubleValue;
			}
			else
			{
				m_CycloidalGear.Module = 0;
			}

			int intValue;
			if (Int32.TryParse(m_WheelCountTextBox.Text, out intValue))
			{
				m_CycloidalGear.Wheel.ToothCount = intValue;
			}
			else
			{
				m_CycloidalGear.Wheel.ToothCount = 0;
			}
			if (Int32.TryParse(m_PinionCountTextBox.Text, out intValue))
			{
				m_CycloidalGear.Pinion.ToothCount = intValue;
			}
			else
			{
				m_CycloidalGear.Pinion.ToothCount = 0;
			}

			UpdateFromModel();
		}

		private void UpdateFromModel()
		{
			m_ModuleTextBox.Text = m_CycloidalGear.Module.ToString();
			m_WheelCountTextBox.Text = m_CycloidalGear.Wheel.ToothCount.ToString();
			m_PinionCountTextBox.Text = m_CycloidalGear.Pinion.ToothCount.ToString();
			m_WheelHoleDiameterTextBox.Text = m_CycloidalGear.Wheel.CenterHoleDiameter.ToString();
			m_PinionHoleDiameterTextBox.Text = m_CycloidalGear.Pinion.CenterHoleDiameter.ToString();

			m_CirdularPitchTextBox.Text = m_CycloidalGear.CircularPitch.ToString();
			m_DedendumTextBox.Text = m_CycloidalGear.Wheel.Dedendum.ToString();
			m_GearRatioTextBox.Text = m_CycloidalGear.GearRatio.ToString();
			m_PracticalAddendumFactorTextBox.Text = m_CycloidalGear.PracticalAddendumFactor.ToString();
			m_AddendumTextBox.Text = m_CycloidalGear.Wheel.Addendum.ToString();
			m_AddendumRadiusTextBox.Text = m_CycloidalGear.Wheel.AddendumRadius.ToString();
			m_PitchDiameterWheelTextBox.Text = m_CycloidalGear.Wheel.PitchDiameter.ToString();
			m_PitchDiameterPinionTextBox.Text = m_CycloidalGear.Pinion.PitchDiameter.ToString();
		}

		private void OnSVGButtonClick(object sender, EventArgs e)
		{
			GearSetGenerator gearGenerator = new GearSetGenerator(m_CycloidalGear);
			string svgText = gearGenerator.Build();
			Save(svgText, "CycloidalGear.svg");
		}

		private static void Save(string svgText, string filePath)
		{
			using (StreamWriter writer = new StreamWriter(filePath, false))
			{
				writer.Write(svgText);
			}
		}
	}
}
