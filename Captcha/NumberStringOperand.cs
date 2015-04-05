namespace Captcha
{
	public class NumberStringOperand : IOperand
	{
		private int value;

		public NumberStringOperand (int value)
		{
			this.value = value;	
		}

		public override string ToString ()
		{
			return this.value.ToString();
		}
	}
}

