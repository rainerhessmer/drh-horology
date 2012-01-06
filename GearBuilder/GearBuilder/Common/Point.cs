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

namespace GearBuilder.Common
{
	public struct Point
	{
		public static Point operator +(Point p, Vector v)
		{
			return new Point(p.X + v.X, p.Y + v.Y);
		}

		public static Point operator -(Point p, Vector v)
		{
			return new Point(p.X - v.X, p.Y - v.Y);
		}

		private double m_X;
		private double m_Y;

		public double X
		{
			get { return m_X; }
			set { m_X = value; }
		}

		public double Y
		{
			get { return m_Y; }
			set { m_Y = value; }
		}

		public Point(double x, double y)
		{
			m_X = x;
			m_Y = y;
		}

		public override string ToString()
		{
			return String.Format("({0},{1})", this.X, this.Y);
		}
	}
}
