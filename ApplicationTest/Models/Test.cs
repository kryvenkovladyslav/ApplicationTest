using System.Collections.Generic;
using System.Linq;

namespace ApplicationTest.Models
{
    public class Test
    {
        public Domain.Categories Category { get; set; }
        public List<Question> Questions { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Score 
            => Questions.Where(question => question.Result).Count() * 10;


    }
}
