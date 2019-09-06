using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectImNotSureWhatItIS
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavAnimal { get; set; }
        public string FavColor { get; set; }
        public int FavNumber { get; set; }
        public int NumPets { get; set; }
        public string petNames { get; set; }
        public string AnswerQuestions(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public int AnswerQuestionWithIntiger(string question)
        {
            string stringAnswer = AnswerQuestions(question);
            return int.Parse(stringAnswer);
        }
        public int AnswerQuestionWithIntiger2(string question)
        {
            string stringAnswer = AnswerQuestions(question);
            int x = int.Parse(stringAnswer);
            return int.Parse(stringAnswer);
        }
        public string AnswerwithPetNames(string question)
        {
            Console.WriteLine(question);
            
            return Console.ReadLine();
        }
    }
}
