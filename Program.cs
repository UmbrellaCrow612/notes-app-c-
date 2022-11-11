// Note
// Search func
// Based tags, wild card search, titles, words
// adv func collab

// coll - list nites / users
// algo - search
// command line - -- add note
// robus - exepctions
// enxcoplusation / construcotr ?
// inheritcae ?
// seralastion save load ?
// threading muti ?

// get all notes from files
// if no args are passed




try
{
    string arg = args[0];
    switch (arg)
    {
        // wrap body in "" and tags in "" and then use split 
        case ("note-add"): notes_util.AddNote(title: args[1], body: args[2], tags: args[3]); break;
        case ("note-help"): break; // also help for each function
        default: throw new ArgumentException(arg);
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine("Argument not supported " + ex.Message);
    notes_util.HelpText();
}
catch (NotesFormatExeption ex)
{
    if(ex.Type == NotesFormatExeption.ExeptionType.BODY)
    {
        Console.WriteLine("Body error " + ex.Message);
    }
    if(ex.Type == NotesFormatExeption.ExeptionType.TAGS)
    {
        Console.WriteLine("Tags error" + ex.Message);
    }
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Must pass argument to run");
    notes_util.HelpText();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}