using System;

namespace ProjectImNotSureWhatItIS
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Hey, can I ask you a few questions");

            user.FirstName = user.AnswerQuestions("What's your first name");
            user.LastName = user.AnswerQuestions("What's your last name");
            user.FavAnimal = user.AnswerQuestions("What's your favorite animal?");
            user.FavColor = user.AnswerQuestions("What's your favorite color?");
            user.FavNumber = user.AnswerQuestionWithIntiger("What's your lucky number?");
            user.NumPets = user.AnswerQuestionWithIntiger2("How many pet's do you have?");
            user.petNames = user.AnswerwithPetNames("And what are their names?");

            Console.WriteLine($"So you are {user.FirstName} {user.LastName}");
            Console.WriteLine($" your favorite animal is {user.FavAnimal}");
            Console.WriteLine($"and your favorite color is {user.FavColor} ");
            Console.WriteLine($"You have {user.NumPets}");
            Console.WriteLine($"And their names are {user.petNames}");
            Console.WriteLine($"While your lucky number is ");
            if (user.FavNumber > 10)
            { Console.ForegroundColor = ConsoleColor.Blue; }
            else
            { Console.ForegroundColor = ConsoleColor.Green; }
            

           

            Console.WriteLine(user.FavNumber);
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
