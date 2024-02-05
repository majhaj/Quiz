using Microsoft.EntityFrameworkCore;
using Quiz;
internal class Program
{
    private static void Main(string[] args)
    {
        var options = new DbContextOptionsBuilder<QuizContext>()
                .UseSqlite("Data Source=quiz.db")
                .Options;

        using (var context = new QuizContext(options))
        {
            context.Database.EnsureCreated();

            User user = new User();
            user.GetUserData();
            context.Users.Add(user);

            context.SaveChanges();

            QuizEntity quiz = new QuizEntity();
            quiz.StartQuiz();

            quiz.UserId = user.Id;
            context.Quizzes.Add(quiz);

            context.SaveChanges();
        }
    }
}
