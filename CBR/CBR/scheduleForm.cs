using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CBR
{
    public partial class scheduleForm : Form
    {
        List<Curs> data;
        string start;
        string end;
        public scheduleForm(List<Curs> data, string Name, string start, string end)
        {
            InitializeComponent();
            this.data = data;
            Text = Name;
            
            fillDataGrid();
            drawChart(start, end);
        }

        void fillDataGrid()
        {
            dataTable.RowHeadersVisible = false;
            dataTable.RowCount = data.Count;
            dataTable.ColumnCount = 3;

            dataTable.Columns[0].HeaderText = "Значение";
            dataTable.Columns[1].HeaderText = "Номинал";
            dataTable.Columns[2].HeaderText = "Дата";

            for (int i = 0; i < data.Count; i++)
            {
                dataTable.Rows[i].Cells[0].Value = data[i].Value;
                dataTable.Rows[i].Cells[1].Value = data[i].Nominal;
                dataTable.Rows[i].Cells[2].Value = data[i].Date;
            }


        }

        void drawChart(string start, string end)
        {
            chartValute.Titles[0].Text = "с " + start + " по " + end;
            chartValute.Series[0].MarkerSize = 9;
            chartValute.Series[0].MarkerColor = Color.Blue;
            chartValute.Series[0].MarkerStyle = MarkerStyle.Circle;
            for (int i = data.Count - 1; i >= 0; i--)
            {
                chartValute.Series[0].Points.AddXY(data[i].Date, data[i].Value / data[i].Nominal);
            }
        }
    }
}
