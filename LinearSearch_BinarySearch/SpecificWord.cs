using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the number of sentences
        Console.Write("Enter the number of sentences: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Initialize an array to store the sentences
        string[] sentences = new string[size];

        // Prompt the user to enter the sentences
        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Sentence {i + 1}: ");
            sentences[i] = Convert.ToString(Console.ReadLine());
        }

        // Prompt the user to enter the word to search for
        Console.Write("Enter the word to search for: ");
        string word = Convert.ToString(Console.ReadLine());

        // Perform linear search for the first sentence containing the word
        int result = FindSentenceWithWord(sentences, word);

        // Display the result
        if (result != -1)
        {
            Console.WriteLine($"The first sentence containing the word '{word}' is at index {result}:");
            Console.WriteLine(sentences[result]);
        }
        else
        {
            Console.WriteLine($"No sentence contains the word '{word}'.");
        }
    }

    static int FindSentenceWithWord(string[] sentences, string word)
    {
        // Iterate through the sentences
        for (int i = 0; i < sentences.Length; i++)
        {
            // Check if the current sentence contains the word
            if (sentences[i].Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                return i; // Return the index of the first sentence containing the word
            }
        }

        // If no sentence contains the word, return -1
        return -1;
    }
}