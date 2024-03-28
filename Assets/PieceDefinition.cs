public class PieceDefinition
{
    //this is a singleton, a variable that self-references it's own class, and since it is public and static, all public properties and methods in this class are usable by everything
    public static PieceDefinition instance { get; }

    
}
