using System;
namespace seleniumTesting
{
	public class Browser
	{
		private String name;
		private String version;
		private String platform;

		public String Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public String Version
		{
			get
			{
				return version;
			}
			set
			{
				version = value;
			}
		}

		public String Platform
		{
			get
			{
				return platform;
			}
			set
			{
				platform = value;
			}
		}
	}
}
