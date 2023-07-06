using Task1;

Console.WriteLine("What functionality do you want to use: creating a quiz or filling it out" + '\n'
    + "1. Create quiz" + '\n'
    + "2. filling it out");

const string path = @"C:/Users/VKukuchanashvili/Desktop/TBCAcademyCsharp/Assignment 14/Task1/bin/Debug/net7.0/quiz.txt";
CreateQuiz quiz = new CreateQuiz(path);

int choose = int.Parse(Console.ReadLine());

if(choose == 1)
{
    bool isFileEmpty = quiz.IsFileEmpty(path);

    if(isFileEmpty == false)
    {
        Console.WriteLine("1. Clear Questions, which is in file" + '\n' +
        "2. Add Question");
        int chooseAnswer = int.Parse(Console.ReadLine());
        if (chooseAnswer == 1)
        {
            quiz.ClearQuiz(path);
            Console.WriteLine("The file was cleared");
            EnterQuestions();
        }
        else
        {
            EnterQuestions();
        }
    }
    else
    {
        Console.WriteLine("The file is empty, so you can only add questions");
        EnterQuestions();
    }

}
else if(choose == 2)
{
    Console.WriteLine("Enter your firstname: ");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter your lastname: ");
    string lastName = Console.ReadLine();

    int scoreSum = quiz.ReadFileAndFillQuiz(path);

    Console.WriteLine($"{firstName} {lastName} your final score is {scoreSum}");

}


void EnterQuestions()
{
    while (true)
    {
        Console.WriteLine("Enter Question: ");
        string question = Console.ReadLine();

        Console.WriteLine("Enter Score: ");
        int score = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter answer quantity: ");
        List<string> options = new List<string>();
        int answerQuantity = int.Parse(Console.ReadLine());
        for (int i = 0; i < answerQuantity; i++)
        {
            Console.WriteLine($"Enter {i + 1} answer: ");
            options.Add(Console.ReadLine());
        }

        Console.WriteLine("Enter Correct Answer: ");
        int correctAnswer = int.Parse(Console.ReadLine());

        quiz.AddQuestion(question, score, options, correctAnswer);

        Console.WriteLine("Do u want to add one more question? Yes/No");
        var answer = Console.ReadLine();
        if (answer == "Yes")
        {
            continue;
        }
        else
        {
            quiz.PrintQuestions();

            Console.WriteLine("Do u want to save question(s) in file? Yes/No");
            var answerAddQuestion = Console.ReadLine();
            if (answerAddQuestion == "Yes")
            {
                quiz.SaveFileQuiz(path);
                return;
            }
            else
            {
                return;
            }
        }
    }
}