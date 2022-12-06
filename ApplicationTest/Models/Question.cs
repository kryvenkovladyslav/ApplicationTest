namespace ApplicationTest.Models
{
    public class Question
    {
        public string Text { get; set; }
        public Domain.Answers ExpectedAnswer { get; set; }
        public Domain.Answers ActualAnswer { get; set; }
        public bool Result => ExpectedAnswer.Equals(ActualAnswer);
    }
}
