using HW3;

var enTranslator = new EnUaTranslator();
var uaTranslator = new UaEnTranslator();

Console.WriteLine(enTranslator.Translate("Bye-bye"));
Console.WriteLine(enTranslator.Translate("Hello"));
Console.WriteLine(enTranslator.Translate("Bye"));

Console.WriteLine();

Console.WriteLine(uaTranslator.Translate("Привіт"));
Console.WriteLine(uaTranslator.Translate("Як справи"));
Console.WriteLine(uaTranslator.Translate("Прощавай"));