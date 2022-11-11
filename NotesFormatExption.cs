// done all this to handle multiple diffrent format exptions with the notes
// gracefully inside catch statements
// by adding our ow type meta data
// the enum is there to restric input and add intellsiesnse
// 


public class NotesFormatExeption : FormatException
{
    private ExeptionType type = ExeptionType.BODY;

    public enum ExeptionType
    {
        BODY,
        TAGS
    }

    public NotesFormatExeption()
    {
    }

    public NotesFormatExeption(string message)
        : base(message)
    {
    }

    public NotesFormatExeption(string message, Exception inner)
        : base(message, inner)
    {
    }

    public NotesFormatExeption(string message, NotesFormatExeption.ExeptionType type)
       : base(message)
    {
        this.type = type;
    }

    public ExeptionType Type { get => type;}
}
