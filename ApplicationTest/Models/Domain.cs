using System.Collections.Generic;

namespace ApplicationTest.Models
{
    public static class Domain
    {
        public static Dictionary<int, string> Dictionary = new Dictionary<int, string>();
        static Domain()
        {
            Dictionary.Add(0, "Математика");
            Dictionary.Add(1, "Фізика");
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
