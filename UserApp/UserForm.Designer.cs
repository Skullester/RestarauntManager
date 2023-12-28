using Timer = System.Windows.Forms.Timer;

namespace UserApp
{
    partial class UserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param sushiName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            timeLabel = new Label();
            timer1 = new Timer(components);
            dateLabel = new Label();
            categoryLabel = new Label();
            labelHot = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
           // TableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 18F);
            timeLabel.Location = new Point(12, 628);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(102, 32);
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
            dateLabel.Location = new Point(12, 660);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(128, 27);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "29.11.2023";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            categoryLabel.Location = new Point(12, 21);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(163, 37);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Категории:";
            // 
            // labelHot
            // 
            labelHot.AutoSize = true;
            labelHot.Cursor = Cursors.Hand;
            labelHot.Font = new Font("Segoe UI", 20F);
            labelHot.Location = new Point(12, 76);
            labelHot.Name = "labelHot";
            labelHot.Size = new Size(194, 37);
            labelHot.TabIndex = 5;
            labelHot.Text = "Теплые роллы";
            labelHot.Click += ShowHot;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(271, 37);
            label1.TabIndex = 6;
            label1.Text = "Классические роллы";
            label1.Click += ShowClassic;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(168, 37);
            label2.TabIndex = 7;
            label2.Text = "Люкс роллы";
            label2.Click += ShowLux;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 217);
            label3.Name = "label3";
            label3.Size = new Size(216, 37);
            label3.TabIndex = 8;
            label3.Text = "Суши и гунканы";
            label3.Click += ShowSushi;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(-1, 580);
            label4.Name = "label4";
            label4.Size = new Size(284, 37);
            label4.TabIndex = 10;
            label4.Text = "Добро пожаловать!";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.Location = new Point(289, 40);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.Size = new Size(853, 642);
            TableLayoutPanel1.TabIndex = 11;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 694);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHot);
            Controls.Add(categoryLabel);
            Controls.Add(dateLabel);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Роллы";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label timeLabel;
        private Timer timer1;
        private Label dateLabel;
        #endregion

        private Label categoryLabel;
        private Label labelHot;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public static TableLayoutPanel TableLayoutPanel1 { get; } = new TableLayoutPanel();
    }
}
