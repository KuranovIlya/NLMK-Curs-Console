using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Data.Common;
using System.IO;

namespace CBR
{
    class DataBase
    {
        public DataBase(string path)
        {
            con = "Data Source=" + path + "; Version=3;";
        }
        string con;

        public List<Valutes> getAllValutes()
        {
            List<Valutes> valutes = new List<Valutes>();
            using (SQLiteConnection Connect = new SQLiteConnection(con))
            {
                Connect.Open();
                string commandText = "SELECT * FROM Valutes";
                using (SQLiteCommand Command = new SQLiteCommand(commandText, Connect))
                {
                    using (SQLiteDataReader reader = Command.ExecuteReader())
                    {
                        foreach (DbDataRecord record in reader)
                        {
                            Valutes v = new Valutes(Convert.ToString(record["id"]),
                                Convert.ToInt32(record["NumCode"]),
                                Convert.ToString(record["CharCode"]),
                                Convert.ToString(record["Name"]),
                                Convert.ToInt32(record["Active"]));
                            valutes.Add(v);
                        }
                    }
                }
                Connect.Close();

            }

            return valutes;
        }
        public List<Curs> getCursInfo(string ID)
        {
            List<Curs> curs = new List<Curs>();

            using (SQLiteConnection Connect = new SQLiteConnection(con))
            {
                Connect.Open();
                string commandText = "SELECT * FROM Curs WHERE id=\"" + ID + "\" ORDER BY Date DESC";
                using (SQLiteCommand Command = new SQLiteCommand(commandText, Connect))
                {
                    using (SQLiteDataReader reader = Command.ExecuteReader())
                    {
                        foreach (DbDataRecord record in reader)
                        {
                            Curs c = new Curs(ID,
                                Convert.ToInt32(record["Nominal"]),
                                Convert.ToDouble(record["Value"]),
                                Convert.ToString(record["Date"]));
                            curs.Add(c);
                        }
                    }
                }
                Connect.Close();
            }
                return curs;
        }

        public void changeActive(string ID, int Active)
        {
            using (SQLiteConnection Connect = new SQLiteConnection(con))
            {

                Connect.Open();
                string commandText = "UPDATE Valutes SET Active = " + Active.ToString() + " WHERE id=\"" + ID + "\";";
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Command.ExecuteNonQuery();
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

    public class Curs
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
