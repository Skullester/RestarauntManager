namespace Airport
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            labelCurrentFlights = new Label();
            dataGridViewDestinations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinations).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelCurrentFlights
            // 
            labelCurrentFlights.AutoSize = true;
            labelCurrentFlights.Font = new Font("Segoe UI", 20F);
            labelCurrentFlights.Location = new Point(838, 43);
            labelCurrentFlights.Name = "labelCurrentFlights";
            labelCurrentFlights.Size = new Size(213, 37);
            labelCurrentFlights.TabIndex = 1;
            labelCurrentFlights.Text = "Текущие рейсы:";
            // 
            // dataGridViewDestinations
            // 
            dataGridViewDestinations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDestinations.Location = new Point(639, 104);
            dataGridViewDestinations.Name = "dataGridViewDestinations";
            dataGridViewDestinations.Size = new Size(588, 469);
            dataGridViewDestinations.TabIndex = 2;
            // 
            // MainForm
            // 
            ClientSize = new Size(1260, 596);
            Controls.Add(dataGridViewDestinations);
            Controls.Add(labelCurrentFlights);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "AIRPLANE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelCurrentFlights;
        private DataGridView dataGridViewDestinations;
    }
}