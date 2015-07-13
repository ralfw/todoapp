using NUnit.Framework;
using System;
using System.Globalization;

namespace scratchpad_tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void DateTime_parsing_with_cultureinfo ()
		{
			var ci = new CultureInfo ("en-us");
			var d = DateTime.Parse ("12/13/2010 2:00pm", ci);
			Assert.AreEqual (new DateTime (2010, 12, 13, 14, 0, 0), d);

			ci = new CultureInfo ("de-de");
			d = DateTime.Parse ("13.12.2010 14:00", ci);
			Assert.AreEqual (new DateTime (2010, 12, 13, 14, 0, 0), d);

			d = DateTime.Parse ("13.12.2010", new CultureInfo ("de-de"));
			Assert.AreEqual (new DateTime (2010, 12, 13, 0, 0, 0), d);
		}
	}
}

