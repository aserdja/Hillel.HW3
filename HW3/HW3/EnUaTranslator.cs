namespace HW3
{
	public class EnUaTranslator : Translator
	{
		public override string TextLanguage { get; } = "English";

		public override string TargetLanguage { get; } = "Ukrainian";

		public override string Translate(string incomingText)
		{
			string result = incomingText switch
			{
				"Hello" => "Привіт",
				"Bye" => "Прощавай",
				_ => "Check your input is correct"
			};
			return result;
		}
	}
}
