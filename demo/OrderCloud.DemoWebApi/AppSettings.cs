﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCloud.DemoWebApi
{
	public class AppSettings
	{
		public EnvironmentSettings EnvironmentSettings { get; set; } = new EnvironmentSettings();
		public RedisSettings RedisSettings { get; set; } = new RedisSettings();
	}

	public class RedisSettings
	{
		public string ConnectionString { get; set; }
		public int DatabaseID { get; set; }
	}

	public class EnvironmentSettings
	{
		public string BuildNumber { get; set; }
	}
}