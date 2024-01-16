using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace CourseWork
{
    partial class ManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            orderTable = new DataGridView();
            button1 = new Button();
            timeLabel = new Label();
            timer1 = new Timer(components);
            dateLabel = new Label();
            storageTable = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            finder = new TextBox();
            consumersTable = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            comboBoxReport = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)orderTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storageTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consumersTable).BeginInit();
            SuspendLayout();
            // 
            // orderTable
            // 
            orderTable.BackgroundColor = SystemColors.ControlLight;
            orderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderTable.Location = new Point(12, 141);
            orderTable.Name = "orderTable";
            orderTable.Size = new Size(762, 570);
            orderTable.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(13, 22);
            button1.Name = "button1";
            button1.Size = new Size(186, 44);
            button1.TabIndex = 1;
            button1.Text = "Загрузить заказы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OpenTable;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 20F);
            timeLabel.Location = new Point(1645, 62);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(119, 37);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "20:49:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateLabel.Location = new Point(1636, 100);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(128, 27);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "29.11.2023";
            // 
            // storageTable
            // 
            storageTable.BackgroundColor = SystemColors.ControlLight;
            storageTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            storageTable.Location = new Point(807, 327);
            storageTable.Name = "storageTable";
            storageTable.Size = new Size(356, 389);
            storageTable.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(205, 22);
            button2.Name = "button2";
            button2.Size = new Size(186, 44);
            button2.TabIndex = 5;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Restart;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 25F);
            label1.Location = new Point(1260, 9);
            label1.Name = "label1";
            label1.Size = new Size(504, 44);
            label1.TabIndex = 6;
            label1.Text = "Здравствуйте, Администратор";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(397, 22);
            button3.Name = "button3";
            button3.Size = new Size(215, 43);
            button3.TabIndex = 7;
            button3.Text = "Обработать заказ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Process;
            // 
            // finder
            // 
            finder.Font = new Font("Segoe UI", 15F);
            finder.Location = new Point(956, 290);
            finder.Name = "finder";
            finder.PlaceholderText = "Найти";
            finder.Size = new Size(189, 34);
            finder.TabIndex = 8;
            finder.TextChanged += Find;
            // 
            // consumersTable
            // 
            consumersTable.BackgroundColor = SystemColors.ControlLight;
            consumersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            consumersTable.Location = new Point(1191, 219);
            consumersTable.Name = "consumersTable";
            consumersTable.Size = new Size(573, 499);
            consumersTable.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 25F);
            label2.Location = new Point(1400, 160);
            label2.Name = "label2";
            label2.Size = new Size(158, 44);
            label2.TabIndex = 10;
            label2.Text = "Клиенты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 25F);
            label3.Location = new Point(807, 280);
            label3.Name = "label3";
            label3.Size = new Size(119, 44);
            label3.TabIndex = 11;
            label3.Text = "Склад";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 25F);
            label4.Location = new Point(304, 87);
            label4.Name = "label4";
            label4.Size = new Size(137, 44);
            label4.TabIndex = 12;
            label4.Text = "Заказы";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(13, 105);
            button4.Name = "button4";
            button4.Size = new Size(151, 30);
            button4.TabIndex = 13;
            button4.Text = "Отсортировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Sort;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(781, 9);
            button5.Name = "button5";
            button5.Size = new Size(179, 44);
            button5.TabIndex = 14;
            button5.Text = "Составить отчет";
            button5.UseVisualStyleBackColor = true;
            button5.Click += MakeReport;
            // 
            // comboBoxReport
            // 
            comboBoxReport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReport.Font = new Font("Segoe UI", 12F);
            comboBoxReport.FormattingEnabled = true;
            comboBoxReport.Items.AddRange(new object[] { "Прибыль", "Частопокупаемые товары" });
            comboBoxReport.Location = new Point(966, 20);
            comboBoxReport.Name = "comboBoxReport";
            comboBoxReport.Size = new Size(121, 29);
            comboBoxReport.TabIndex = 15;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1776, 730);
            Controls.Add(comboBoxReport);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(consumersTable);
            Controls.Add(finder);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(storageTable);
            Controls.Add(dateLabel);
            Controls.Add(timeLabel);
            Controls.Add(button1);
            Controls.Add(orderTable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)orderTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)storageTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)consumersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView orderTable;
        private Button button1;
        private Label timeLabel;
        private Timer timer1;
        private Label dateLabel;
        private DataGridView storageTable;
        private Button button2;
        private Label label1;
        private Button button3;
        private TextBox finder;
        private DataGridView consumersTable;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button4;
        private Button button5;
        private ComboBox comboBoxReport;
    }
}
