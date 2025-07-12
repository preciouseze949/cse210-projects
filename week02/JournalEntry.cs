using System;

public class JournalEntry
{
    public string Content { get; set; }
    public DateTime Date { get; set; }

    public JournalEntry(string content)
    {
        Content = content;
        Date = DateTime.Now;
    }

    public JournalEntry(string content, DateTime date)
    {
        Content = content;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date}: {Content}";
    }
}
