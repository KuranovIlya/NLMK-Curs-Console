using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBR
{
    public partial class mainForm : Form
    {
        List<Valutes> valutes;
        List<Curs> curs;
        DataBase db;
        public mainForm()
        {
            InitializeComponent();

            intervalStart.Format = DateTimePickerFormat.Custom;
            intervalStart.CustomFormat = "yyyy-MM-dd";
            intervalEnd.Format = DateTimePickerFormat.Custom;
            intervalEnd.CustomFormat = "yyyy-MM-dd";
        }


        void fillListValutes()
        {
            try
            {
                valutes = db.getAllValutes();
                foreach (Valutes v in valutes)
                {
                    listValutes.Items.Add(v.Name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK);
            }




            
        }

        private void listValutes_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxTo.Text = "";
            textBoxToRUB.Text = "";

            valName.Text = valutes[listValutes.SelectedIndex].Name;
            valCharCode.Text = valutes[listValutes.SelectedIndex].CharCode;
            labelConvertFrom.Text = valutes[listValutes.SelectedIndex].CharCode;
            labelConvertTo.Text = valutes[listValutes.SelectedIndex].CharCode;
            valNumCode.Text = valutes[listValutes.SelectedIndex].NumCode.ToString();
            if (valutes[listValutes.SelectedIndex].Active == 1) 
                buttonActive.Text = "Не обновлять";
            else
                buttonActive.Text = "Обновлять";

            curs = db.getCursInfo(valutes[listValutes.SelectedIndex].ID);
            if (curs.Count != 0)
            {
                valNominal.Text = curs[0].Nominal.ToString();
                valValue.Text = curs[0].Value.ToString();
                valDate.Text = curs[0].Date.ToString();
            }
            else
            {
                valNominal.Text = "Нет данных";
                valValue.Text = "Нет данных";
                valDate.Text = "";
            }

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string path = "CBR.db";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DB files (*.db)|*.db|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listValutes.Items.Clear();
                    path = openFileDialog.FileName;
                }    
                else
                    return;
            }
            db = new DataBase(path);
            fillListValutes();
        }

        private void buttonToRUB_Click(object sender, EventArgs e)
        {
            try
            {
                if (listValutes.SelectedItems.Count != 0 && curs.Count > 0)
                {
                    if (!String.IsNullOrEmpty(textBoxFrom.Text))
                    {
                        string value = textBoxFrom.Text.Replace(".", ",");
                        double result = Math.Round(Convert.ToDouble(value) * (curs[0].Value / curs[0].Nominal), 5);
                        if (result >= 0)
                            textBoxToRUB.Text = Convert.ToString(result);
                        else
                            MessageBox.Show("Введено отрицательное число.", "Ошибка", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Пустая строка.", "Ошибка", MessageBoxButtons.OK);
                }    
                else
                    MessageBox.Show("Валюта не выбрана или по ней нет данных.", "Ошибка", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Ошибка вычисления.", "Ошибка", MessageBoxButtons.OK);
            }
            
        }

        private void buttonRUBTo_Click(object sender, EventArgs e)
        {
            try
            {
                if (listValutes.SelectedItems.Count != 0 && curs.Count > 0)
                {
                    if (!String.IsNullOrEmpty(textBoxFromRUB.Text))
                    {
                        string value = textBoxFromRUB.Text.Replace(".", ",");
                        double result = Math.Round(Convert.ToDouble(value) / (curs[0].Value / curs[0].Nominal), 5);
                        if (result >= 0)
                            textBoxTo.Text = Convert.ToString(result);
                        else
                            MessageBox.Show("Введено отрицательное число.", "Ошибка", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Пустая строка.", "Ошибка", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Валюта не выбрана или по ней нет данных.", "Ошибка", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Ошибка вычисления.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonActive_Click(object sender, EventArgs e)
        {
            try
            {
                if (listValutes.SelectedItems.Count != 0)
                {
                    int active;
                    if (valutes[listValutes.SelectedIndex].Active == 1)
                        active = 0;
                    else
                        active = 1;
                    db.changeActive(valutes[listValutes.SelectedIndex].ID, active);
                    valutes[listValutes.SelectedIndex].Active = active;
                    if (valutes[listValutes.SelectedIndex].Active == 1)
                        buttonActive.Text = "Не обновлять";
                    else
                        buttonActive.Text = "Обновлять";
                }
                else
                {
                    MessageBox.Show("Валюта не выбрана.", "Ошибка", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Не получается изменить статус валюты.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            if (listValutes.SelectedItems.Count != 0 && curs.Count > 0)
            {
                string start = intervalStart.Value.ToString("yyyy-MM-dd");
                string end = intervalEnd.Value.ToString("yyyy-MM-dd");
                if (String.Compare(start, end) <= 0)
                {
                    List<Curs> data = new List<Curs>();
                    foreach (Curs c in curs)
                    {
                        if (String.Compare(start, c.Date) <= 0 
                            && String.Compare(c.Date, end) <= 0)
                        {
                            data.Add(c);
                        }
                    }
                    if (data.Count > 0)
                    {
                        scheduleForm sf = new scheduleForm(data, valutes[listValutes.SelectedIndex].Name, start, end);
                        sf.Show();
                    }
                    else
                        MessageBox.Show("Нет данных за указанный промежуток.", "Ошибка", MessageBoxButtons.OK);

                }
                else
                    MessageBox.Show("Интервал указан неверно.", "Ошибка", MessageBoxButtons.OK);

            }
            else
                MessageBox.Show("Валюта не выбрана или по ней нет данных.", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
