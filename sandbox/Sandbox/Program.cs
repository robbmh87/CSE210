using System;
using System.Collections.Generic;
using System.IO;



class Program

{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        entry._prompt = "big";
        //Console.WriteLine(entry._prompt);

        Entry date = new Entry();
        date.GiveValues("oct", "prompt", "input");

        //date.Display();
        List<Entry> entries = new List<Entry>();
        entries.Add(entry);
        entries.Add(date);
        entries[0].Display();
        entries[1].Display();
    }

}