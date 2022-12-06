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
            return View(repository.GetAllByCategory("math").Where(test => test.Name == "math_2019").First());
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
                    Category = "math",
                    Name = "math_2019",
                    Count = 20,
                    Score = default,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Text = "Question 1", ExpectedAnswer = Domain.Answers.A
                        },
                        new Question
                        {
                            Text = "Question 2", ExpectedAnswer = Domain.Answers.G
                        },
                        new Question
                        {
                            Text = "Question 3", ExpectedAnswer = Domain.Answers.D
                        },
                        new Question
                        {
                            Text = "Question 4", ExpectedAnswer = Domain.Answers.C
                        },
                        new Question
                        {
                            Text = "Question 5", ExpectedAnswer = Domain.Answers.A
                        },
                        new Question
                        {
                            Text = "Question 6", ExpectedAnswer = Domain.Answers.D
                        },
                        new Question
                        {
                            Text = "Question 7", ExpectedAnswer = Domain.Answers.B
                        },
                        new Question
                        {
                            Text = "Question 8", ExpectedAnswer = Domain.Answers.D
                        },
                        new Question
                        {
                            Text = "Question 9", ExpectedAnswer = Domain.Answers.A
                        },
                        new Question
                        {
                            Text = "Question 10", ExpectedAnswer = Domain.Answers.G
                        },
                        new Question
                        {
                            Text = "Question 11", ExpectedAnswer = Domain.Answers.C
                        },
                        new Question
                        {
                            Text = "Question 12", ExpectedAnswer = Domain.Answers.A
                        },
                        new Question
                        {
                            Text = "Question 13", ExpectedAnswer = Domain.Answers.C
                        },
                        new Question
                        {
                            Text = "Question 14", ExpectedAnswer = Domain.Answers.B
                        },
                        new Question
                        {
                            Text = "Question 15", ExpectedAnswer = Domain.Answers.D
                        },
                        new Question
                        {
                            Text = "Question 16", ExpectedAnswer = Domain.Answers.G
                        },
                        new Question
                        {
                            Text = "Question 17", ExpectedAnswer = Domain.Answers.A
                        },
                        new Question
                        {
                            Text = "Question 18", ExpectedAnswer = Domain.Answers.G
                        },
                        new Question
                        {
                            Text = "Question 19", ExpectedAnswer = Domain.Answers.B
                        },
                        new Question
                        {
                            Text = "Question 20", ExpectedAnswer = Domain.Answers.G
                        }
                    }
                }
            };

            repository.AddRange("math", tests);
        }
    }
}
