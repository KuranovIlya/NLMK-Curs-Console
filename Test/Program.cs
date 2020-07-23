using System;

namespace Test
{
    class Program
    {
        static DataBase db;
        static void Main(string[] args)
        {
            db = new DataBase();
            db.CreateBase();
            db.AddCurs();

            Console.WriteLine("Синхронизация завершена! Нажмите любую кнопку, чтобы продолжить.");
            Console.Read();
        }

        
       
    }
}
