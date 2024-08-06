public abstract class Translator : ITranslatable
{
	public abstract string TextLanguage { get; }
	public abstract string TargetLanguage { get; }
	public abstract string Translate(string incomingText);
}
