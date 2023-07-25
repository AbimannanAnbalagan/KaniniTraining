using ExceptionHandling;

class program
{
    public static void Main(string[] args)
    {
        EHcode eHcode = new EHcode(10,5,0);
        //eHcode.div();
        //eHcode.arr();

        CustomException customException = new CustomException();
        customException.CheckVal(-1);
    }
}
