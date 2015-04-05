namespace Captcha
{
	public class Operand
	{
		private IOperand[] operands;
		private int mode;

		public Operand (int value, int mode)
		{
			this.operands = new IOperand[] { 
				new NumberStringOperand (value) ,
				new WordStringOperand(value)
			};
			this.mode = mode;
		}

		public override string ToString ()
		{
			return this.operands [this.mode - 1].ToString ();
		}
	}
}