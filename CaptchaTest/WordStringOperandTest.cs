using System;
using NUnit.Framework;
using Captcha;

namespace CaptchaTest
{
	[TestFixture]
	public class WordStringOperandTest
	{
		[TestCase (1, Result = "One")]
		[TestCase (2, Result = "Two")]
		[TestCase (3, Result = "Three")]
		[TestCase (4, Result = "Four")]
		[TestCase (5, Result = "Five")]
		[TestCase (6, Result = "Six")]
		[TestCase (7, Result = "Seven")]
		[TestCase (8, Result = "Eight")]
		[TestCase (9, Result = "Nine")]
		[TestCase (0, Result = "Zero")]
		public string ToStringTest (int value)
		{
			return new WordStringOperand (value).ToString ();
		}
	}
}

