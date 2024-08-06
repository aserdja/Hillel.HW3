namespace HW3
{
	public class UaEnTranslator : Translator
	{
		public override string TextLanguage { get; } = "Ukrainian";

		public override string TargetLanguage { get; } = "English";

		public override string Translate(string incomingText)
		{
			string result = incomingText switch
			{
				"Привіт" => "Hello",
				"Прощавай" => "Bye",
				_ => "Перевірте правильність введених даних"
			};
			return result;
		}
	}
}
