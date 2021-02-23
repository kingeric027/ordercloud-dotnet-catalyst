﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCloud.Catalyst
{
	// I'm setting this internal so that people depending on catalyst don't have a bunch of random-seeming helper functions.
	// We can revisit whether they might be helpful to people. 
	internal static class ExtensionMethods
	{
		public static Type WithoutGenericArgs(this Type type)
		{
			return type.IsGenericType ? type.GetGenericTypeDefinition() : type;
		}
	}
}
