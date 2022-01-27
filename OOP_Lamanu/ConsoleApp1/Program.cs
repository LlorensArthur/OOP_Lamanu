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
        gestionQuizz();
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

// Cette fonction permet de faire le Quizz
 void quizz()
{
    for (int i = 0; i < questions.ask.Count; i++)
        {
        Console.WriteLine(questions.ask[i]);
        string userInput2 = Console.ReadLine();
        if (userInput2 == answers.ans[i])
        {
            Console.WriteLine("bonne réponse");
        }
        else
        {
            Console.WriteLine("mauvaise réponse");
        }
        Thread.Sleep(1000);
        Console.Clear();
    }
}

// Verification du Mot de passe
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

// Cette fonction affiche la gestion du Quizz a l'Admin
void gestionQuizz()
{
    bool exitgestion = false;
    while (!exitgestion)
    {
        Console.WriteLine("Que voulez vous faire? \n 1 - Afficher les question  \n 2 - Ajouter question  \n 3 - Suprimer question  \n 4 - Quitter");
        string userchoice = Console.ReadLine();
        switch (userchoice)
        {
            case "1":
                showQuizz();
            break;
            case "2":
                newQuestion();
            break;
            case "3":
                removeQuestion();
            break;
            case "4":
                exitgestion = true;
            break;
        }
    }
}

// Cette fonction affiche les question presente dans le Quizz
void showQuizz()
{
    for (int i = 0; i < questions.ask.Count; i++)
    {
        Console.WriteLine(questions.ask[i]);
        Console.WriteLine(answers.ans[i]);
        Console.WriteLine("\n");
    }
}

// Cette fonction permet de rajouter des question dans le Quizz
void newQuestion() {

    Console.WriteLine("Veillez entrer votre question");
    string newQuestion = Console.ReadLine();
    questions.ask.Add(newQuestion);
    Console.WriteLine("Veillez entrer la réponse à cette question");
    string newAnswer = Console.ReadLine();
    answers.ans.Add(newAnswer);
}

// Cette fonction permet de supprimer des question dans le Quizz
void removeQuestion(){

    Console.WriteLine("Quelle question voulez vous supprimer?");
    int DeleteQuestion = int.Parse(Console.ReadLine());
    // La decrementation a lieu pour que le numéro soit cohérent avec le numero dans la liste 
    DeleteQuestion--;
    questions.ask.RemoveAt(DeleteQuestion);
    answers.ans.RemoveAt(DeleteQuestion);
}