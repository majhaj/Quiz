using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class QuizEntity
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        private readonly Dictionary<string, string> questionsAndAnswers;

        public QuizEntity()
        {
            questionsAndAnswers = new Dictionary<string, string>
        {
            { "Witamina B12 występuje: \n a. we wszystkich produktach spożywczych;\n b. głównie w produktach odzwierzęcych (mięso, mleko i przetwory mleczne);\n c. głównie w owocach i warzywach i ich przetworach;\n d. w algach.", "b" },
            { "Źródłem kwasów tłuszczowych omega-3 są:\n a.orzechy, oleje roślinne;\n b. owoce cytrusowe;\n c. kasze gruboziarniste;\n d. mleko i produkty mleczne.", "a" },
            { "Przyswajalność wapnia z produktów roślinnych jest:\n a.taka sama jak z produktów odzwierzęcych;\n b. większa niż z produktów odzwierzęcych;\n c. mniejsza niż z produktów odzwierzęcych;\n d. nie wiem.", "c" },
            { "Do produktów roślinnych bogatych w żelazo należą:\n a. pieczywo pszenne, pomidory, oliwa z oliwek;\n b.pełnoziarniste produkty zbożowe, soczewica, burak;\n c. kasza manna, jogurt naturalny, ogórek zielony;\n d. kasza jęczmienna, kukurydza, banany.", "b" },
            { "Na przyswajalność żelaza nie ma wpływu:\n a. zawartość taniny (w kawie i herbacie);\n b. witamina E; \n c. witamina C; \n d. fityniany.", "b" },
            { "Zalecane spożycie żelaza dla wegetarian:\n a. jest niższe niż dla niewegetarian;\n b. jest takie same jak dla niewegetarian; \n c. jest nieznacznie wyższe niż dla niewegetarian;\n d. jest prawie dwukrotnie wyższe niż dla niewegetarian.", "d" },
            { "Najlepszym źródłem białka roślinnego są:\n a. chleb żytni, papryka czerwona, pomarańcze; \n b. ryż biały, ziemniaki, truskawki;\n c. kasza gryczana, fasola, ciecierzyca, słonecznik;\n d. pieczywo pszenne, pomidory, fasola biała.", "c" },
            { "Suplementacja witaminy D w Polsce dla osoby zdrowej: \n a. nie jest zalecana;\n b. jest zalecana od kwietnia do października;\n c. jest zalecana od października do kwietnia\n d. jest zalecana przez cały rok", "c" },
            { "Czy uważa Pani / Pan, że w czasie ciąży i laktacji może być stosowana dieta wegetariańska?\n a. tak i nie wymaga dodatkowej suplementacji;\n  b. tak, ale wymaga dodatkowej suplementacji;\n c. nie powinna być stosowana;\n d. nie wiem.", "b" }

        };
        }

        public void StartQuiz()
        {
            int userScore = 0;

            Console.WriteLine($"Rozpocznij quiz o id {Id}:");

            foreach (var question in questionsAndAnswers)
            {
                Console.WriteLine(question.Key);
                string userAnswer = Console.ReadLine();

                if (userAnswer.Equals(question.Value, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Poprawna odpowiedź!");
                    userScore++;
                }
                else
                {
                    Console.WriteLine($"Niepoprawna odpowiedź. Prawidłowa odpowiedź to: {question.Value}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Twój wynik: {userScore} punktów");
            Score = userScore;

            if (userScore > 7)
            {
                Console.WriteLine("Brawo! Na temat diety wegetariańskiej wiesz prawie wszytsko.");
            }
            else if (userScore > 5 && userScore <= 7)
            {
                Console.WriteLine("Twój poziom wiedzy na temat diety wegetariańskiej jest średni, dowiedz się więcej na www.wege.org");
            }
            else
            {
                Console.WriteLine("Twój poziom wiedzy jest niski. Skonsultuj się z dietetykiem lub lekarzem, jeśli chcesz zadbać o swoją dietę.");
            }
            Console.ReadKey();
        }
    }
}

