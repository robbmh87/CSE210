public class Entry
{
    public string _date;
    public string _prompt;
    public string _input;

    public void Display()
    {
        Console.WriteLine($"{_date} {_prompt} {_input}");
    }

    public void GiveValues(string date, string prompt, string input)
    {
        _date = date;
        _prompt = prompt;
        _input = input;
    }

}

