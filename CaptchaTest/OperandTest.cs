using NUnit.Framework;
using Captcha;

namespace CaptchaTest
{
	[TestFixture]
	public class OperandTest
	{
		[TestCase (1, Result = "1")]
		[TestCase (2, Result = "2")]
		public string ToString_Mode1 (int value)
		{
			var operand = new Operand (value, 1);
			return operand.ToString ();
		}

		[TestCase (1, Result = "One")]
		[TestCase (2, Result = "Two")]
		public string ToString_Mode2 (int value)
		{
			var operand = new Operand (value, 2);
			return operand.ToString ();
		}
	}
}

