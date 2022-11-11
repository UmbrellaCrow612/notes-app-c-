public static class notes_util
{
    // have utils like help

    public static void HelpText()
    {
        Console.WriteLine(" \n Here are some options you could try \n  \n 1.) note-add  \n 2.) note-search \n 3.) note-update \n 4.) note-delete \n 5.) note-tags \n 6.) note-list \n");
    }

    public static void AddNote(string title, string body, string tags)
    {
        // add expetions for correct format 
        // add note
        // tags "tag1,tag2,tag3"
        if (body.Contains("\""))
        {

        } else
        {
            //throw new FormatException("Body must be wrapped with \"  \" ", new Exception("BODY"));
            throw new NotesFormatExeption("Body must be wrapped in \"  \" ", NotesFormatExeption.ExeptionType.BODY);
        }

        if (tags.Contains("\""))
        {
            throw new NotesFormatExeption("Tags must be wrapped in \"  \" ", NotesFormatExeption.ExeptionType.TAGS);
        }
        else
        {
            throw new FormatException("Tags must be wrapped in \"  \" ", new Exception("TAGS"));
        }
        // title 
    }

   
}


