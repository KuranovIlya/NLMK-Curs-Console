namespace CBR
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelValutes = new System.Windows.Forms.Label();
            this.listValutes = new System.Windows.Forms.ListBox();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelConverter = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCharCode = new System.Windows.Forms.Label();
            this.labelNumCode = new System.Windows.Forms.Label();
            this.labelNominal = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.valName = new System.Windows.Forms.Label();
            this.valCharCode = new System.Windows.Forms.Label();
            this.valNumCode = new System.Windows.Forms.Label();
            this.valNominal = new System.Windows.Forms.Label();
            this.valValue = new System.Windows.Forms.Label();
            this.valDate = new System.Windows.Forms.Label();
            this.labelFromRUB = new System.Windows.Forms.Label();
            this.labelConvertFrom = new System.Windows.Forms.Label();
            this.textBoxFromRUB = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxToRUB = new System.Windows.Forms.TextBox();
            this.buttonRUBTo = new System.Windows.Forms.Button();
            this.buttonActive = new System.Windows.Forms.Button();
            this.buttonToRUB = new System.Windows.Forms.Button();
            this.labelConvertTo = new System.Windows.Forms.Label();
            this.labelToRUB = new System.Windows.Forms.Label();
            this.intervalStart = new System.Windows.Forms.DateTimePicker();
            this.labelInterval = new System.Windows.Forms.Label();
            this.intervalEnd = new System.Windows.Forms.DateTimePicker();
            this.labelDash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(617, 601);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(126, 43);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelValutes
            // 
            this.labelValutes.AutoSize = true;
            this.labelValutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValutes.Location = new System.Drawing.Point(12, 12);
            this.labelValutes.Name = "labelValutes";
            this.labelValutes.Size = new System.Drawing.Size(99, 16);
            this.labelValutes.TabIndex = 1;
            this.labelValutes.Text = "Список валют";
            // 
            // listValutes
            // 
            this.listValutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listValutes.FormattingEnabled = true;
            this.listValutes.ItemHeight = 16;
            this.listValutes.Location = new System.Drawing.Point(13, 32);
            this.listValutes.Name = "listValutes";
            this.listValutes.Size = new System.Drawing.Size(459, 612);
            this.listValutes.TabIndex = 2;
            this.listValutes.SelectedValueChanged += new System.EventHandler(this.listValutes_SelectedValueChanged);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraph.Location = new System.Drawing.Point(509, 601);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(102, 43);
            this.buttonGraph.TabIndex = 3;
            this.buttonGraph.Text = "График";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(506, 12);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(93, 16);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Информация";
            // 
            // labelConverter
            // 
            this.labelConverter.AutoSize = true;
            this.labelConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConverter.Location = new System.Drawing.Point(506, 354);
            this.labelConverter.Name = "labelConverter";
            this.labelConverter.Size = new System.Drawing.Size(79, 16);
            this.labelConverter.TabIndex = 5;
            this.labelConverter.Text = "Конвертер";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(506, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 16);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Название:";
            // 
            // labelCharCode
            // 
            this.labelCharCode.AutoSize = true;
            this.labelCharCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCharCode.Location = new System.Drawing.Point(506, 84);
            this.labelCharCode.Name = "labelCharCode";
            this.labelCharCode.Size = new System.Drawing.Size(119, 16);
            this.labelCharCode.TabIndex = 7;
            this.labelCharCode.Text = "Символьный код:";
            // 
            // labelNumCode
            // 
            this.labelNumCode.AutoSize = true;
            this.labelNumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumCode.Location = new System.Drawing.Point(506, 136);
            this.labelNumCode.Name = "labelNumCode";
            this.labelNumCode.Size = new System.Drawing.Size(101, 16);
            this.labelNumCode.TabIndex = 8;
            this.labelNumCode.Text = "Числовой код:";
            // 
            // labelNominal
            // 
            this.labelNominal.AutoSize = true;
            this.labelNominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNominal.Location = new System.Drawing.Point(506, 188);
            this.labelNominal.Name = "labelNominal";
            this.labelNominal.Size = new System.Drawing.Size(70, 16);
            this.labelNominal.TabIndex = 9;
            this.labelNominal.Text = "Номинал:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.Location = new System.Drawing.Point(506, 240);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(42, 16);
            this.labelValue.TabIndex = 10;
            this.labelValue.Text = "Курс:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(506, 292);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(167, 16);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Последнее обновление:";
            // 
            // valName
            // 
            this.valName.AutoSize = true;
            this.valName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valName.Location = new System.Drawing.Point(522, 58);
            this.valName.Name = "valName";
            this.valName.Size = new System.Drawing.Size(0, 16);
            this.valName.TabIndex = 12;
            // 
            // valCharCode
            // 
            this.valCharCode.AutoSize = true;
            this.valCharCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valCharCode.Location = new System.Drawing.Point(522, 110);
            this.valCharCode.Name = "valCharCode";
            this.valCharCode.Size = new System.Drawing.Size(0, 16);
            this.valCharCode.TabIndex = 13;
            // 
            // valNumCode
            // 
            this.valNumCode.AutoSize = true;
            this.valNumCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valNumCode.Location = new System.Drawing.Point(522, 162);
            this.valNumCode.Name = "valNumCode";
            this.valNumCode.Size = new System.Drawing.Size(0, 16);
            this.valNumCode.TabIndex = 14;
            // 
            // valNominal
            // 
            this.valNominal.AutoSize = true;
            this.valNominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valNominal.Location = new System.Drawing.Point(522, 214);
            this.valNominal.Name = "valNominal";
            this.valNominal.Size = new System.Drawing.Size(0, 16);
            this.valNominal.TabIndex = 15;
            // 
            // valValue
            // 
            this.valValue.AutoSize = true;
            this.valValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valValue.Location = new System.Drawing.Point(522, 266);
            this.valValue.Name = "valValue";
            this.valValue.Size = new System.Drawing.Size(0, 16);
            this.valValue.TabIndex = 16;
            // 
            // valDate
            // 
            this.valDate.AutoSize = true;
            this.valDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valDate.Location = new System.Drawing.Point(522, 318);
            this.valDate.Name = "valDate";
            this.valDate.Size = new System.Drawing.Size(0, 16);
            this.valDate.TabIndex = 17;
            // 
            // labelFromRUB
            // 
            this.labelFromRUB.AutoSize = true;
            this.labelFromRUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFromRUB.Location = new System.Drawing.Point(506, 374);
            this.labelFromRUB.Name = "labelFromRUB";
            this.labelFromRUB.Size = new System.Drawing.Size(37, 16);
            this.labelFromRUB.TabIndex = 18;
            this.labelFromRUB.Text = "RUB";
            // 
            // labelConvertFrom
            // 
            this.labelConvertFrom.AutoSize = true;
            this.labelConvertFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConvertFrom.Location = new System.Drawing.Point(506, 441);
            this.labelConvertFrom.Name = "labelConvertFrom";
            this.labelConvertFrom.Size = new System.Drawing.Size(0, 16);
            this.labelConvertFrom.TabIndex = 19;
            // 
            // textBoxFromRUB
            // 
            this.textBoxFromRUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromRUB.Location = new System.Drawing.Point(509, 393);
            this.textBoxFromRUB.Name = "textBoxFromRUB";
            this.textBoxFromRUB.Size = new System.Drawing.Size(106, 22);
            this.textBoxFromRUB.TabIndex = 20;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFrom.Location = new System.Drawing.Point(509, 460);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(106, 22);
            this.textBoxFrom.TabIndex = 21;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTo.Location = new System.Drawing.Point(776, 393);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.ReadOnly = true;
            this.textBoxTo.Size = new System.Drawing.Size(106, 22);
            this.textBoxTo.TabIndex = 22;
            // 
            // textBoxToRUB
            // 
            this.textBoxToRUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToRUB.Location = new System.Drawing.Point(776, 460);
            this.textBoxToRUB.Name = "textBoxToRUB";
            this.textBoxToRUB.ReadOnly = true;
            this.textBoxToRUB.Size = new System.Drawing.Size(106, 22);
            this.textBoxToRUB.TabIndex = 23;
            // 
            // buttonRUBTo
            // 
            this.buttonRUBTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRUBTo.Location = new System.Drawing.Point(648, 386);
            this.buttonRUBTo.Name = "buttonRUBTo";
            this.buttonRUBTo.Size = new System.Drawing.Size(95, 34);
            this.buttonRUBTo.TabIndex = 24;
            this.buttonRUBTo.Text = "Перевести";
            this.buttonRUBTo.UseVisualStyleBackColor = true;
            this.buttonRUBTo.Click += new System.EventHandler(this.buttonRUBTo_Click);
            // 
            // buttonActive
            // 
            this.buttonActive.Location = new System.Drawing.Point(648, 315);
            this.buttonActive.Name = "buttonActive";
            this.buttonActive.Size = new System.Drawing.Size(95, 23);
            this.buttonActive.TabIndex = 26;
            this.buttonActive.Text = "Обновлять";
            this.buttonActive.UseVisualStyleBackColor = true;
            this.buttonActive.Click += new System.EventHandler(this.buttonActive_Click);
            // 
            // buttonToRUB
            // 
            this.buttonToRUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRUB.Location = new System.Drawing.Point(648, 453);
            this.buttonToRUB.Name = "buttonToRUB";
            this.buttonToRUB.Size = new System.Drawing.Size(95, 34);
            this.buttonToRUB.TabIndex = 27;
            this.buttonToRUB.Text = "Перевести";
            this.buttonToRUB.UseVisualStyleBackColor = true;
            this.buttonToRUB.Click += new System.EventHandler(this.buttonToRUB_Click);
            // 
            // labelConvertTo
            // 
            this.labelConvertTo.AutoSize = true;
            this.labelConvertTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConvertTo.Location = new System.Drawing.Point(773, 374);
            this.labelConvertTo.Name = "labelConvertTo";
            this.labelConvertTo.Size = new System.Drawing.Size(0, 16);
            this.labelConvertTo.TabIndex = 28;
            // 
            // labelToRUB
            // 
            this.labelToRUB.AutoSize = true;
            this.labelToRUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToRUB.Location = new System.Drawing.Point(773, 441);
            this.labelToRUB.Name = "labelToRUB";
            this.labelToRUB.Size = new System.Drawing.Size(37, 16);
            this.labelToRUB.TabIndex = 29;
            this.labelToRUB.Text = "RUB";
            // 
            // intervalStart
            // 
            this.intervalStart.CustomFormat = "yyyy-MM-dd";
            this.intervalStart.Location = new System.Drawing.Point(509, 529);
            this.intervalStart.Name = "intervalStart";
            this.intervalStart.Size = new System.Drawing.Size(125, 20);
            this.intervalStart.TabIndex = 30;
            this.intervalStart.Value = new System.DateTime(2020, 7, 23, 0, 0, 0, 0);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterval.Location = new System.Drawing.Point(506, 499);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(238, 16);
            this.labelInterval.TabIndex = 31;
            this.labelInterval.Text = "Интервал для построения графика";
            // 
            // intervalEnd
            // 
            this.intervalEnd.CustomFormat = "yyyy-MM-dd";
            this.intervalEnd.Location = new System.Drawing.Point(671, 529);
            this.intervalEnd.Name = "intervalEnd";
            this.intervalEnd.Size = new System.Drawing.Size(125, 20);
            this.intervalEnd.TabIndex = 32;
            this.intervalEnd.Value = new System.DateTime(2020, 7, 23, 0, 0, 0, 0);
            // 
            // labelDash
            // 
            this.labelDash.AutoSize = true;
            this.labelDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDash.Location = new System.Drawing.Point(645, 533);
            this.labelDash.Name = "labelDash";
            this.labelDash.Size = new System.Drawing.Size(17, 16);
            this.labelDash.TabIndex = 33;
            this.labelDash.Text = "—";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 662);
            this.Controls.Add(this.labelDash);
            this.Controls.Add(this.intervalEnd);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.intervalStart);
            this.Controls.Add(this.labelToRUB);
            this.Controls.Add(this.labelConvertTo);
            this.Controls.Add(this.buttonToRUB);
            this.Controls.Add(this.buttonActive);
            this.Controls.Add(this.buttonRUBTo);
            this.Controls.Add(this.textBoxToRUB);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxFromRUB);
            this.Controls.Add(this.labelConvertFrom);
            this.Controls.Add(this.labelFromRUB);
            this.Controls.Add(this.valDate);
            this.Controls.Add(this.valValue);
            this.Controls.Add(this.valNominal);
            this.Controls.Add(this.valNumCode);
            this.Controls.Add(this.valCharCode);
            this.Controls.Add(this.valName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelNominal);
            this.Controls.Add(this.labelNumCode);
            this.Controls.Add(this.labelCharCode);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelConverter);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.listValutes);
            this.Controls.Add(this.labelValutes);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсы валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelValutes;
        private System.Windows.Forms.ListBox listValutes;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelConverter;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCharCode;
        private System.Windows.Forms.Label labelNumCode;
        private System.Windows.Forms.Label labelNominal;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label valName;
        private System.Windows.Forms.Label valCharCode;
        private System.Windows.Forms.Label valNumCode;
        private System.Windows.Forms.Label valNominal;
        private System.Windows.Forms.Label valValue;
        private System.Windows.Forms.Label valDate;
        private System.Windows.Forms.Label labelFromRUB;
        private System.Windows.Forms.Label labelConvertFrom;
        private System.Windows.Forms.TextBox textBoxFromRUB;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxToRUB;
        private System.Windows.Forms.Button buttonRUBTo;
        private System.Windows.Forms.Button buttonActive;
        private System.Windows.Forms.Button buttonToRUB;
        private System.Windows.Forms.Label labelConvertTo;
        private System.Windows.Forms.Label labelToRUB;
        private System.Windows.Forms.DateTimePicker intervalStart;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.DateTimePicker intervalEnd;
        private System.Windows.Forms.Label labelDash;
    }
}

