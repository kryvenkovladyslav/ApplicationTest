using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTest.Models
{
    public class Test
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public List<Question> Questions { get; set; }
        public double Score { get; set; }
        public double GetScore()
            => Questions.Where(question => question.Result).Count() * 10;
        
    }
}
