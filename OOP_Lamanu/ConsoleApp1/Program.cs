using System.Reflection;


Questions questions = new Questions("1?", "2?", "3?", "4?");

Answers answers = new Answers("1", "2", "3", "4");

Users user1 = new Users(1, "Admin", "4dmin");
Users user2 = new Users(2, "User", "useR");

Console.WriteLine("Bonjour, veuillez rentrer votre nom");

bool exitLogin = false;
while (!exitLogin)
{
    string userInput = Console.ReadLine();
    if (userInput == user1.name)
    {
        CheckPassword(user1);
    }
    else if (userInput == user2.name)
    {
        CheckPassword(user2);
        quizz();   
        
    }
    else
    {
        Console.WriteLine("Le nom que vous avez rentré n'est pas valide");
    }
}




 void quizz()
{
    foreach(string question in questions.fdp)
    {


    }


    for (int i = 1; i < 5; i++)
    {
        switch (i)
        {
            case 1:
                Console.WriteLine(questions.question1);
                string userInput2 = Console.ReadLine();
                if (userInput2 == answers.reponse1)
                {
                    Console.WriteLine("bonne réponse");
                }
                else
                {
                    Console.WriteLine("mauvaise réponse");
                }
                Console.Clear();
                break;
            case 2:
                Console.WriteLine(questions.question2);
                string userInput3 = Console.ReadLine();
                if (userInput3 == answers.reponse2)
                {
                    Console.WriteLine("bonne réponse");
                }
                else
                {
                    Console.WriteLine("mauvaise réponse");
                }
                Console.Clear();
                break;
            case 3:
                Console.WriteLine(questions.question3);
                string userInput4 = Console.ReadLine();
                if (userInput4 == answers.reponse3)
                {
                    Console.WriteLine("bonne réponse");
                }
                else
                {
                    Console.WriteLine("mauvaise réponse");
                }
                Console.Clear();
                break;
            case 4:
                Console.WriteLine(questions.question4);
                string userInput5 = Console.ReadLine();
                if (userInput5 == answers.reponse4)
                {
                    Console.WriteLine("bonne réponse");
                }
                else
                {
                    Console.WriteLine("mauvaise réponse");
                }
                Console.Clear();
                break;
            default:
                break;
        }
    }
}
void CheckPassword(Users user)
{
    Console.WriteLine("Nom valide, veuillez rentrer le mot de  passe");
    while (true)
    {
        string userInput = Console.ReadLine();
        if (userInput == user.password)
        {
            exitLogin = true;
            break;
        }
    }
}


    