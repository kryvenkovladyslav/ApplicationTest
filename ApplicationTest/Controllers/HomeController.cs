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

        public IActionResult Index() => View();
        public IActionResult Privacy() => View();
        public IActionResult ShowCategories() => View(((Repository<Test>)repository).Items);
        public IActionResult ShowTestPage(int category, string name)
        {
            return View(repository
                .GetAllByCategory(category)
                .Where(test => test.Name == name)
                .First());
        }


        [HttpPost]
        public IActionResult ShowResultPage(Test test) => View(test);
        [HttpPost]
        public IActionResult ShowQuestionPage(Question question) => View(question);

       
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private void SeedData()
        {
            var mathTests = new Test[]
            {
                new Test
                {
                    Category = Domain.Categories.math,
                    Name = "Математика тест 2019",
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
                },

                new Test
                {
                    Category = Domain.Categories.math,
                    Name = "Математика тест 2020",
                    Count = 20,
                    Questions = new List<Question>
                    {
                        new Question { Text = "Завдання 1", ImagePath = @"math\math_2020\1.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 2", ImagePath = @"math\math_2020\2.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 3", ImagePath = @"math\math_2020\3.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 4", ImagePath = @"math\math_2020\4.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 5", ImagePath = @"math\math_2020\5.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 6", ImagePath = @"math\math_2020\6.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 7", ImagePath = @"math\math_2020\7.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 8", ImagePath = @"math\math_2020\8.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 9", ImagePath = @"math\math_2020\9.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 10", ImagePath = @"math\math_2020\10.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 11", ImagePath = @"math\math_2020\11.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 12", ImagePath = @"math\math_2020\12.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 13", ImagePath = @"math\math_2020\13.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 14", ImagePath = @"math\math_2020\14.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 15", ImagePath = @"math\math_2020\15.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 16", ImagePath = @"math\math_2020\16.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 17", ImagePath = @"math\math_2020\17.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 18", ImagePath = @"math\math_2020\18.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 19", ImagePath = @"math\math_2020\19.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 20", ImagePath = @"math\math_2020\20.png", ExpectedAnswer = Domain.Answers.G }
                    }
                },

                new Test
                {
                    Category = Domain.Categories.math,
                    Name = "Математика тест 2021",
                    Count = 20,
                    Questions = new List<Question>
                    {
                        new Question { Text = "Завдання 1", ImagePath = @"math\math_2021\1.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 2", ImagePath = @"math\math_2021\2.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 3", ImagePath = @"math\math_2021\3.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 4", ImagePath = @"math\math_2021\4.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 5", ImagePath = @"math\math_2021\5.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 6", ImagePath = @"math\math_2021\6.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 7", ImagePath = @"math\math_2021\7.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 8", ImagePath = @"math\math_2021\8.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 9", ImagePath = @"math\math_2021\9.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 10", ImagePath = @"math\math_2021\10.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 11", ImagePath = @"math\math_2021\11.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 12", ImagePath = @"math\math_2021\12.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 13", ImagePath = @"math\math_2021\13.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 14", ImagePath = @"math\math_2021\14.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 15", ImagePath = @"math\math_2021\15.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 16", ImagePath = @"math\math_2021\16.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 17", ImagePath = @"math\math_2021\17.png", ExpectedAnswer = Domain.Answers.D },
                        new Question { Text = "Завдання 18", ImagePath = @"math\math_2021\18.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 19", ImagePath = @"math\math_2021\19.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 20", ImagePath = @"math\math_2021\20.png", ExpectedAnswer = Domain.Answers.G }
                    }
                }
            };

            var physicsTest = new Test[]
            {
                 new Test
                {
                    Category = Domain.Categories.physics,
                    Name = "Фізика тест 2019",
                    Count = 24,
                    Questions = new List<Question>
                    {
                        new Question { Text = "Завдання 1", ImagePath = @"physics\physics_2019\1.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 2", ImagePath = @"physics\physics_2019\2.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 3", ImagePath = @"physics\physics_2019\3.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 4", ImagePath = @"physics\physics_2019\4.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 5", ImagePath = @"physics\physics_2019\5.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 6", ImagePath = @"physics\physics_2019\6.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 7", ImagePath = @"physics\physics_2019\7.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 8", ImagePath = @"physics\physics_2019\8.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 9", ImagePath = @"physics\physics_2019\9.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 10", ImagePath = @"physics\physics_2019\10.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 11", ImagePath = @"physics\physics_2019\11.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 12", ImagePath = @"physics\physics_2019\12.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 13", ImagePath = @"physics\physics_2019\13.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 14", ImagePath = @"physics\physics_2019\14.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 15", ImagePath = @"physics\physics_2019\15.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 16", ImagePath = @"physics\physics_2019\16.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 17", ImagePath = @"physics\physics_2019\17.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 18", ImagePath = @"physics\physics_2019\18.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 19", ImagePath = @"physics\physics_2019\19.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 20", ImagePath = @"physics\physics_2019\20.png", ExpectedAnswer = Domain.Answers.B },
                        new Question { Text = "Завдання 21", ImagePath = @"physics\physics_2019\21.png", ExpectedAnswer = Domain.Answers.C },
                        new Question { Text = "Завдання 22", ImagePath = @"physics\physics_2019\22.png", ExpectedAnswer = Domain.Answers.A },
                        new Question { Text = "Завдання 23", ImagePath = @"physics\physics_2019\23.png", ExpectedAnswer = Domain.Answers.G },
                        new Question { Text = "Завдання 24", ImagePath = @"physics\physics_2019\24.png", ExpectedAnswer = Domain.Answers.B }


                    }
                }
            };

            repository.AddRange(((int)Domain.Categories.math), mathTests);
            repository.AddRange(((int)Domain.Categories.physics), physicsTest);
        }
    }
}
