/*	2d helper support functions
	Copyright (c) 2012,2013 Dr. Rainer Hessmer
	Written by Dr. Rainer Hessmer, December 2012.
	Dual licensed under the GPL (http://www.gnu.org/licenses/gpl-3.0-standalone.html) and 
	MIT (http://opensource.org/licenses/MIT) licenses. 
	Please attribute the author if you use it. */

var TwoD;
(function (TwoD) {
	// p0 and p1 are two points represented as an array holding the x and y coordinates: [x,y]
	function distanceTwoPoints(p0, p1) {
		return Math.sqrt((p0[0] - p1[0]) * (p0[0] - p1[0]) + (p0[1] - p1[1]) * (p0[1] - p1[1]));
	}
	TwoD.distanceTwoPoints = distanceTwoPoints;

	// r is the radius and theta the angle in radians
	function polar2Cartesian(r, theta) {
		return [
			r * Math.cos(theta), 
			r * Math.sin(theta)
		];
	}
	TwoD.polar2Cartesian = polar2Cartesian;

	// c0: center of the first circle in the form [x,y]
	// r0: radius of the first circle
	// c1, r1: corresponding values for the second circle
	// equation see http://www.ambrsoft.com/TrigoCalc/Circles2/Circle2.htm
	function twoCirclesIntersections(c0, r0, c1, r1) {
		var D = distanceTwoPoints(c0, c1);
		var delta = 0.25 * Math.sqrt((D + r0 + r1) * (D + r0 - r1) * (D - r0 + r1) * (-D + r0 + r1));
		var xPart1 = (c0[0] + c1[0]) / 2 + (c1[0] - c0[0]) * (r0 * r0 - r1 * r1) / 2 / D / D;
		var xPart2 = 2 * (c0[1] - c1[1]) / D / D * delta;
		var yPart1 = (c0[1] + c1[1]) / 2 + (c1[1] - c0[1]) * (r0 * r0 - r1 * r1) / 2 / D / D;
		var yPart2 = 2 * (c0[0] - c1[0]) / D / D * delta;
		return {
			p0: [
				xPart1 + xPart2, 
				yPart1 - yPart2
			],
			p1: [
				xPart1 - xPart2, 
				yPart1 + yPart2
			]
		};
	}
	TwoD.twoCirclesIntersections = twoCirclesIntersections;

})(TwoD || (TwoD = {}));