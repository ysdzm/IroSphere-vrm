using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
	public static bool IsEqual(float a, float b)
	{
		//1/256した値以下は誤差として切り捨て
		return MathF.Abs(a - b) <= 0.004f;
	}

}
