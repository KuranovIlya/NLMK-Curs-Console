using System;
using System.Collections.Generic;
using System.Xml;

namespace Test
{
    class XmlParser
    {
        public void FillValutes(DataBase db)
        {
            try
            {
                List<Valutes> V = new List<Valutes>();
                Valutes v;
                /*XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");*/
                XmlTextReader reader = new XmlTextReader("https://www.cbr-xml-daily.ru/daily.xml"); 
                while (reader.Read())
                {
                    //Проверяем тип текущего узла
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            if (reader.Name == "Valute")
                            {
                                if (reader.HasAttributes)
                                {
                                    //Метод передвигает указатель к следующему атрибуту
                                    while (reader.MoveToNextAttribute())
                                    {
                                        if (reader.Name == "ID")
                                        {
                                            string id = reader.Value;
                                            //Возвращаемся к элементу, содержащий текущий узел атрибута
                                            reader.MoveToElement();
                                            //Считываем содержимое дочерних узлом
                                            string Xml = reader.ReadOuterXml();

                                            XmlDocument XmlDocument = new XmlDocument();
                                            XmlDocument.LoadXml(Xml);

                                            v = new Valutes(id,
                                                Convert.ToInt32(XmlDocument.SelectSingleNode("Valute/NumCode").InnerText),
                                                XmlDocument.SelectSingleNode("Valute/CharCode").InnerText,
                                                XmlDocument.SelectSingleNode("Valute/Name").InnerText,
                                                0);
                                            V.Add(v);
                                        }
                                    }
                                }
                            }

                            break;
                    }
                }
                db.AddAllValutes(V);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void xmlParse()
        {
            XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
            //В эти переменные будем сохранять куски XML
            //с определенными валютами (Euro, USD)
            string USDXml = "";
            string EuroXML = "";
            //Перебираем все узлы в загруженном документе
            while (reader.Read())
            {
                //Проверяем тип текущего узла
                switch (reader.NodeType)
                {
                    //Если этого элемент Valute, то начинаем анализировать атрибуты
                    case XmlNodeType.Element:

                        if (reader.Name == "Valute")
                        {
                            if (reader.HasAttributes)
                            {
                                //Метод передвигает указатель к следующему атрибуту
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name == "ID")
                                    {
                                        //Если значение атрибута равно R01235, то перед нами информация о курсе доллара
                                        if (reader.Value == "R01235")
                                        {
                                            //Возвращаемся к элементу, содержащий текущий узел атрибута
                                            reader.MoveToElement();
                                            //Считываем содержимое дочерних узлом
                                            USDXml = reader.ReadOuterXml();
                                        }
                                    }

                                    //Аналогичную процедуру делаем для ЕВРО
                                    if (reader.Name == "ID")
                                    {
                                        if (reader.Value == "R01239")
                                        {
                                            reader.MoveToElement();
                                            EuroXML = reader.ReadOuterXml();
                                        }
                                    }
                                }
                            }
                        }

                        break;
                }
            }

            //Из выдернутых кусков XML кода создаем новые XML документы
            XmlDocument usdXmlDocument = new XmlDocument();
            usdXmlDocument.LoadXml(USDXml);
            XmlDocument euroXmlDocument = new XmlDocument();
            euroXmlDocument.LoadXml(EuroXML);
            //Метод возвращает узел, соответствующий выражению XPath
            XmlNode xmlNode = usdXmlDocument.SelectSingleNode("Valute/Value");

            //Считываем значение и конвертируем в decimal. Курс валют получен
            decimal usdValue = Convert.ToDecimal(xmlNode.InnerText);
            xmlNode = euroXmlDocument.SelectSingleNode("Valute/Value");
            decimal euroValue = Convert.ToDecimal(xmlNode.InnerText);

            xmlNode = usdXmlDocument.SelectSingleNode("Valute/Name");
            Console.WriteLine(xmlNode.InnerText);

            Console.WriteLine(usdValue);
            Console.WriteLine(euroValue);
        }

        public List<Curs> getNewCurs(HashSet<string> ID)
        {
            try
            {
                List<Curs> C = new List<Curs>();
                Curs c;
                XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
                while (reader.Read())
                {
                    //Проверяем тип текущего узла
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            if (reader.Name == "Valute")
                            {
                                if (reader.HasAttributes)
                                {
                                    //Метод передвигает указатель к следующему атрибуту
                                    while (reader.MoveToNextAttribute())
                                    {
                                        if (reader.Name == "ID")
                                        {
                                            if (ID.Contains(reader.Value))
                                            {
                                                string id = reader.Value;
                                                //Возвращаемся к элементу, содержащий текущий узел атрибута
                                                reader.MoveToElement();
                                                //Считываем содержимое дочерних узлом
                                                string Xml = reader.ReadOuterXml();

                                                XmlDocument XmlDocument = new XmlDocument();
                                                XmlDocument.LoadXml(Xml);

                                                c = new Curs(id,
                                                    Convert.ToInt32(XmlDocument.SelectSingleNode("Valute/Nominal").InnerText),
                                                    Convert.ToDouble(XmlDocument.SelectSingleNode("Valute/Value").InnerText),
                                                    DateTime.Now.ToString("yyyy-MM-dd"));
                                                C.Add(c);
                                            }    
                                            
                                        }
                                    }
                                }
                            }

                            break;
                    }
                }
                return C;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
