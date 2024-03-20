namespace Pasteleria
{
    partial class Catalogo
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
            dgvCatalogo = new DataGridView();
            label1 = new Label();
            txtCat = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Location = new Point(12, 71);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.RowTemplate.Height = 25;
            dgvCatalogo.Size = new Size(590, 244);
            dgvCatalogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stylus BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 30);
            label1.TabIndex = 1;
            label1.Text = "CATALOGO DE PRODUCTOS";
            // 
            // txtCat
            // 
            txtCat.BackColor = Color.Pink;
            txtCat.Location = new Point(607, 12);
            txtCat.Name = "txtCat";
            txtCat.Size = new Size(139, 23);
            txtCat.TabIndex = 2;
            txtCat.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1490793870_user_interface25_823551;
            pictureBox1.Location = new Point(752, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Location = new Point(1, 2);
            button1.Name = "button1";
            button1.Size = new Size(81, 33);
            button1.TabIndex = 4;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(807, 349);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(txtCat);
            Controls.Add(label1);
            Controls.Add(dgvCatalogo);
            Name = "Catalogo";
            Text = "Catalogo";
            Load += Catalogo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCatalogo;
        private Label label1;
        private TextBox txtCat;
        private PictureBox pictureBox1;
        private Button button1;
    }
}