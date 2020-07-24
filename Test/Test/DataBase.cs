using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.Common;

namespace Test
{
    class DataBase
    {
        string dbname = "CBR.db";
        string con = "Data Source=CBR.db; Version=3;";

        public void CreateBase()
        {
            try
            {
                if (!File.Exists(dbname))
                {
                    SQLiteConnection.CreateFile(dbname);
                    using (SQLiteConnection Connect = new SQLiteConnection(con)) // в строке указывается к какой базе подключаемся
                    {
                        // строка запроса, который надо будет выполнить
                        string commandText = "CREATE TABLE IF NOT EXISTS [Valutes] ([id] TEXT(10) PRIMARY KEY NOT NULL, [NumCode] INTEGER NOT NULL, " +
                            "[CharCode] TEXT(5) NOT NULL, [Name] TEXT(256) NOT NULL, [Active] INTEGER NOT NULL)"; // создать таблицу, если её нет
                        SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                        Connect.Open(); // открыть соединение
                        Command.ExecuteNonQuery(); // выполнить запрос

                        commandText = "CREATE TABLE IF NOT EXISTS [Curs] ( [id] TEXT(10) NOT NULL, [Nominal] INTEGER NOT NULL, " +
                            "[Value] TEXT(64) NOT NULL, [Date] TEXT(16) NOT NULL)";
                        Command = new SQLiteCommand(commandText, Connect);
                        Command.ExecuteNonQuery();

                        Connect.Close(); // закрыть соединение
                    }
                    XmlParser xp = new XmlParser();
                    xp.FillValutes(this);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        public void AddAllValutes(List<Valutes> V)
        {
            using (SQLiteConnection Connect = new SQLiteConnection(con))
            {
                
                Connect.Open();
                foreach (Valutes v in V)
                {
                    string commandText = "INSERT INTO Valutes (id, NumCode, CharCode, Name, Active) VALUES(\"" + v.ID + "\", " +
                        v.NumCode + ", \"" + v.CharCode + "\", \"" + v.Name + "\", " + v.Active + ");";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Command.ExecuteNonQuery();
                }
                Connect.Close();
            }
        }

        public void AddCurs()
        {
            HashSet<string> ID = new HashSet<string>();
            using (SQLiteConnection Connect = new SQLiteConnection(con))
            {
                Connect.Open();
                string commandText = "SELECT id FROM Valutes WHERE Active=1";
                using (SQLiteCommand Command = new SQLiteCommand(commandText, Connect))
                {
                    using (SQLiteDataReader reader = Command.ExecuteReader())
                    {
                        foreach (DbDataRecord record in reader)
                        {
                            ID.Add(Convert.ToString(record["id"]));
                        }
                    }
                }
                if (ID.Count > 0) 
                {
                    XmlParser xp = new XmlParser();
                    List<Curs> C = xp.getNewCurs(ID);
                    if (C.Count > 0)
                    {
                        foreach (Curs c in C)
                        {
                            commandText = "INSERT INTO Curs (id, Nominal, Value, Date) VALUES(\"" + c.ID + "\", " +
                                c.Nominal + ", \"" + c.Value + "\", \"" + c.Date + "\");";
                            SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                            Command.ExecuteNonQuery();
                        }
                    }
                }

                Connect.Close();

            }
        }
    }

    class Valutes
    {
        public string ID { get; set; }
        public int NumCode { get; set; }
        public string CharCode { get; set; }
        public string Name { get; set; }
        public int Active { get; set; }

        public Valutes(string ID, int NumCode, string CharCode, string Name, int Active)
        {
            this.ID = ID;
            this.NumCode = NumCode;
            this.CharCode = CharCode;
            this.Name = Name;
            this.Active = Active;
        }

        public void Print()
        {
            Console.WriteLine(ID);
            Console.WriteLine(NumCode);
            Console.WriteLine(CharCode);
            Console.WriteLine(Name); 
            Console.WriteLine(Active);
            Console.WriteLine();
        }
    }

    class Curs
    {
        public string ID { get; set; }
        public int Nominal { get; set; }
        public double Value { get; set; }
        public string Date { get; set; }

        public Curs(string ID, int Nominal, double Value, string Date)
        {
            this.ID = ID;
            this.Nominal = Nominal;
            this.Value = Value;
            this.Date = Date;
        }

    }
}
