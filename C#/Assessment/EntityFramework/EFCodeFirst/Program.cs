using EFCodeFirst;
using Microsoft.EntityFrameworkCore.Design.Internal;

class program
{
    public static void Main(string[] args)
    {
        CRUDOperations crud= new CRUDOperations();
        //crud.InsertRecordsInCourseEntity();
        crud.UpdateRecordsInCourseEntity();
    }
}