namespace ConversorDeDinheiro.ConsoleApp
{
    public static class StringExtensions
    {
        public static string ToSentenceCase(this string text)
        {
            char primeiraLetraMaiuscula = text.ToUpper()[0];

            return primeiraLetraMaiuscula + text.Substring(1);
        }
    }

}
