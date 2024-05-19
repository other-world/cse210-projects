using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile (string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.Write($"{entry._date}::");
                outputFile.Write($"{entry._promptText}::");
                outputFile.WriteLine($"{entry._entryText}");
            }
            
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines) 
        {
            //Console.WriteLine($"{line}");
            string[] parts = line.Split("::");
            Entry loadedEntries = new Entry();
            loadedEntries._date = parts[0];
            loadedEntries._promptText = parts[1];
            loadedEntries._entryText = parts[2];

            _entries.Add(loadedEntries);
        }
    }
        

}