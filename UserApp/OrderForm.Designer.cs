using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp;

public partial class OrderForm
{
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
        label1 = new Label();
        nameTextBox = new TextBox();
        numberTextBox = new TextBox();
        label2 = new Label();
        label3 = new Label();
        sushiLabel = new Label();
        pictureBox1 = new PictureBox();
        button1 = new Button();
        labelCost = new Label();
        sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
        comboBox1 = new ComboBox();
        label4 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
        label1.Location = new Point(476, 162);
        label1.Name = "label1";
        label1.Size = new Size(501, 46);
        label1.TabIndex = 0;
        label1.Text = "Заполните форму для заказа";
        // 
        // nameTextBox
        // 
        nameTextBox.Font = new Font("Segoe UI", 15F);
        nameTextBox.Location = new Point(487, 263);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.PlaceholderText = "Александр";
        nameTextBox.Size = new Size(268, 34);
        nameTextBox.TabIndex = 1;
        // 
        // numberTextBox
        // 
        numberTextBox.Font = new Font("Segoe UI", 15F);
        numberTextBox.Location = new Point(487, 349);
        numberTextBox.Name = "numberTextBox";
        numberTextBox.PlaceholderText = "Пример: 79673142483";
        numberTextBox.Size = new Size(268, 34);
        numberTextBox.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 20F);
        label2.Location = new Point(487, 223);
        label2.Name = "label2";
        label2.Size = new Size(76, 37);
        label2.TabIndex = 3;
        label2.Text = "Имя:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 20F);
        label3.Location = new Point(487, 309);
        label3.Name = "label3";
        label3.Size = new Size(232, 37);
        label3.TabIndex = 4;
        label3.Text = "Номер телефона:";
        // 
        // sushiLabel
        // 
        sushiLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        sushiLabel.AutoSize = true;
        sushiLabel.Font = new Font("Segoe UI", 25F);
        sushiLabel.Location = new Point(3, 37);
        sushiLabel.Name = "sushiLabel";
        sushiLabel.Size = new Size(694, 46);
        sushiLabel.TabIndex = 5;
        sushiLabel.Text = "Гункан с морским окунем и филадельфией";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(3, 141);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(455, 403);
        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 15F);
        button1.Location = new Point(487, 476);
        button1.Name = "button1";
        button1.Size = new Size(158, 68);
        button1.TabIndex = 7;
        button1.Text = "Подтвердить заказ";
        button1.UseVisualStyleBackColor = true;
        button1.Click += BuyProduct;
        // 
        // labelCost
        // 
        labelCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        labelCost.AutoSize = true;
        labelCost.Font = new Font("Segoe UI", 25F);
        labelCost.Location = new Point(3, 83);
        labelCost.Name = "labelCost";
        labelCost.Size = new Size(116, 46);
        labelCost.TabIndex = 8;
        labelCost.Text = "Цена: ";
        // 
        // sqliteCommand1
        // 
        sqliteCommand1.CommandTimeout = 30;
        sqliteCommand1.Connection = null;
        sqliteCommand1.Transaction = null;
        sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
        // 
        // comboBox1
        // 
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.Font = new Font("Segoe UI", 15F);
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(821, 254);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(194, 36);
        comboBox1.TabIndex = 9;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 20F);
        label4.Location = new Point(812, 214);
        label4.Name = "label4";
        label4.Size = new Size(137, 37);
        label4.TabIndex = 10;
        label4.Text = "Ресторан:";
        // 
        // OrderForm
        // 
        ClientSize = new Size(1108, 556);
        Controls.Add(label4);
        Controls.Add(comboBox1);
        Controls.Add(labelCost);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Controls.Add(sushiLabel);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(numberTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(label1);
        Name = "OrderForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Заказ";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private TextBox nameTextBox;
    private TextBox numberTextBox;
    private Label label2;
    private Label label3;
    private Label sushiLabel;
    private PictureBox pictureBox1;
    private Button button1;
    private Label labelCost;
    private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    private ComboBox comboBox1;
    private Label label4;
}
