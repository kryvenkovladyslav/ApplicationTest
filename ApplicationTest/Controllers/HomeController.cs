using ApplicationTest.Models;
using ApplicationTest.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IRepository<Test> repository;


        public HomeController(IRepository<Test> repository, ILogger<HomeController> logger)
        {
            (this.repository, this.logger) = (repository, logger);
            SeedData();
        }

        [HttpPost]
        public IActionResult ShowResultPage(Test test)
        {
            return View(test);
        
        }
        [HttpPost]
        public IActionResult ShowQuestionPage(Question question)
        {
            return View(question);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ShowTestPage(string name)
        {
            return View(repository
                .GetAllByCategory(((int)Domain.Categories.math))
                .Where(test => test.Name == "math_2019")
                .First());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private void SeedData()
        {
            var tests = new Test[]
            {
                new Test
                {
                    Category = Domain.Categories.math,
                    Name = "math_2019",
                    Count = 20,
                    Questions = new List<Question>
                    {
                        new Question { Text = "Завдання 1", ImagePath = @"math\math_2019\1.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 2", ImagePath = @"math\math_2019\2.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 3", ImagePath = @"math\math_2019\3.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 4", ImagePath = @"math\math_2019\4.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 5", ImagePath = @"math\math_2019\5.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 6", ImagePath = @"math\math_2019\6.png", ExpectedAnswer = Domain.Answers.D }, 
                        new Question { Text = "Завдання 7", ImagePath = @"math\math_2019\7.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 8", ImagePath = @"math\math_2019\8.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 9", ImagePath = @"math\math_2019\9.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 10", ImagePath = @"math\math_2019\10.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 11", ImagePath = @"math\math_2019\11.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 12", ImagePath = @"math\math_2019\12.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 13", ImagePath = @"math\math_2019\3.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 14", ImagePath = @"math\math_2019\14.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 15", ImagePath = @"math\math_2019\15.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 16", ImagePath = @"math\math_2019\16.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 17", ImagePath = @"math\math_2019\17.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 18", ImagePath = @"math\math_2019\18.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 19", ImagePath = @"math\math_2019\19.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 20", ImagePath = @"math\math_2019\20.png", ExpectedAnswer = Domain.Answers.G }
                    }
                }
            };

            repository.AddRange(((int)Domain.Categories.math), tests);
        }
    }
}
