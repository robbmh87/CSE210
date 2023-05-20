class Scripture
{
    
    private string text;
    private List<string> hiddenWords;

    public Scripture()
    {
    
        this.hiddenWords = new List<string>();
    }

    public void DisplayScripture(string text)
    {
        Reference reference = new Reference();
        // Display the reference and text of the scripture
        Console.WriteLine(reference);
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            // Check if the word is hidden
            if (hiddenWords.Contains(word))
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(word + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideWord(string text)
    {
        // Select a random word from the scripture text
        string[] words = text.Split(' ');
        Random rand = new Random();
        int index = rand.Next(words.Length);
        string wordToHide = words[index];

        // Add the word to the list of hidden words
        hiddenWords.Add(wordToHide);
    }

    public bool AllWordsHidden(string text)
    {
        // Check if all words in the scripture text are in the list of hidden words
        string[] words = text.Split(' ');
        return hiddenWords.Count == words.Length;
    }
}
