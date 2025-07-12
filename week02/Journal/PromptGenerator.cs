using System;

public class PromptGenerator
{
    private string[] questions = {
        "What made you happy today?",
        "What challenges did you face today?",
        "What did you learn today?",
        "What are you grateful for?",
        "What are your goals for tomorrow?"
    };

    private Random random = new Random();

    public string GeneratePrompt()
    {
        int randomIndex = random.Next(questions.Length);
        return questions[randomIndex];
    }
}
