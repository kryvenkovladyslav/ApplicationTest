using System.Collections.Generic;

namespace ApplicationTest.Models
{
    public static class Domain
    {
        public static Dictionary<int, string> CategoryTranslater = new Dictionary<int, string>();
        public static Dictionary<string, string> AnswerTranslater = new Dictionary<string, string>();

        static Domain()
        {
            CategoryTranslater.Add(0, "Математика");
            CategoryTranslater.Add(1, "Фізика");

            AnswerTranslater.Add("A", "A");
            AnswerTranslater.Add("B", "Б");
            AnswerTranslater.Add("C", "В");
            AnswerTranslater.Add("G", "Г");
            AnswerTranslater.Add("D", "Д");

        }

        public enum Answers : int
        {
            A, B, C, G, D
        }
        public enum Categories : int
        {
            math,
            physics
        }
    }
}
