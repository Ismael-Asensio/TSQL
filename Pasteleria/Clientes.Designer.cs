namespace Pasteleria
{
    partial class Clientes
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            TelfC = new Label();
            Estado = new Label();
            SA = new Label();
            DirC = new Label();
            PA = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBoxEstado = new ComboBox();
            txtSN = new TextBox();
            txtPRA = new TextBox();
            txtSA = new TextBox();
            txtTelf = new TextBox();
            txtDirC = new TextBox();
            txtPN = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtBuscarxID = new TextBox();
            panel3 = new Panel();
            dgvClientes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 740);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 131);
            label1.Name = "label1";
            label1.Size = new Size(93, 31);
            label1.TabIndex = 3;
            label1.Text = "Clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.users_clients_group_16774;
            pictureBox1.Location = new Point(32, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TelfC);
            panel2.Controls.Add(Estado);
            panel2.Controls.Add(SA);
            panel2.Controls.Add(DirC);
            panel2.Controls.Add(PA);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxEstado);
            panel2.Controls.Add(txtSN);
            panel2.Controls.Add(txtPRA);
            panel2.Controls.Add(txtSA);
            panel2.Controls.Add(txtTelf);
            panel2.Controls.Add(txtDirC);
            panel2.Controls.Add(txtPN);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBuscarxID);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvClientes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(183, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 740);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 622);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 30;
            // 
            // TelfC
            // 
            TelfC.AutoSize = true;
            TelfC.Location = new Point(201, 666);
            TelfC.Name = "TelfC";
            TelfC.Size = new Size(67, 20);
            TelfC.TabIndex = 29;
            TelfC.Text = "Telefono";
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Location = new Point(409, 524);
            Estado.Name = "Estado";
            Estado.Size = new Size(54, 20);
            Estado.TabIndex = 28;
            Estado.Text = "Estado";
            // 
            // SA
            // 
            SA.AutoSize = true;
            SA.Location = new Point(194, 520);
            SA.Name = "SA";
            SA.Size = new Size(129, 20);
            SA.TabIndex = 27;
            SA.Text = "Segundo Apellido";
            // 
            // DirC
            // 
            DirC.AutoSize = true;
            DirC.Location = new Point(195, 597);
            DirC.Name = "DirC";
            DirC.Size = new Size(72, 20);
            DirC.TabIndex = 26;
            DirC.Text = "Direccion";
            // 
            // PA
            // 
            PA.AutoSize = true;
            PA.Location = new Point(25, 666);
            PA.Name = "PA";
            PA.Size = new Size(113, 20);
            PA.TabIndex = 25;
            PA.Text = "Primer Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 597);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 24;
            label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 524);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 23;
            label2.Text = "Primer Nombre";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "1", "0" });
            comboBoxEstado.Location = new Point(371, 544);
            comboBoxEstado.Margin = new Padding(3, 4, 3, 4);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(138, 28);
            comboBoxEstado.TabIndex = 22;
            // 
            // txtSN
            // 
            txtSN.Location = new Point(25, 621);
            txtSN.Margin = new Padding(3, 4, 3, 4);
            txtSN.Name = "txtSN";
            txtSN.Size = new Size(114, 27);
            txtSN.TabIndex = 21;
            // 
            // txtPRA
            // 
            txtPRA.Location = new Point(25, 690);
            txtPRA.Margin = new Padding(3, 4, 3, 4);
            txtPRA.Name = "txtPRA";
            txtPRA.Size = new Size(114, 27);
            txtPRA.TabIndex = 20;
            // 
            // txtSA
            // 
            txtSA.Location = new Point(194, 544);
            txtSA.Margin = new Padding(3, 4, 3, 4);
            txtSA.Name = "txtSA";
            txtSA.Size = new Size(114, 27);
            txtSA.TabIndex = 19;
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(195, 690);
            txtTelf.Margin = new Padding(3, 4, 3, 4);
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(114, 27);
            txtTelf.TabIndex = 18;
            // 
            // txtDirC
            // 
            txtDirC.Location = new Point(195, 621);
            txtDirC.Margin = new Padding(3, 4, 3, 4);
            txtDirC.Name = "txtDirC";
            txtDirC.Size = new Size(114, 27);
            txtDirC.TabIndex = 17;
            // 
            // txtPN
            // 
            txtPN.Location = new Point(25, 544);
            txtPN.Margin = new Padding(3, 4, 3, 4);
            txtPN.Name = "txtPN";
            txtPN.Size = new Size(114, 27);
            txtPN.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            pictureBox4.Location = new Point(546, 16);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.new_add_user_16734;
            pictureBox3.Location = new Point(438, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.note_task_comment_message_edit_write_108613__1_1;
            pictureBox2.Location = new Point(492, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtBuscarxID
            // 
            txtBuscarxID.Anchor = AnchorStyles.Top;
            txtBuscarxID.BackColor = Color.Snow;
            txtBuscarxID.ForeColor = SystemColors.ControlDark;
            txtBuscarxID.Location = new Point(70, 37);
            txtBuscarxID.Margin = new Padding(3, 4, 3, 4);
            txtBuscarxID.Name = "txtBuscarxID";
            txtBuscarxID.Size = new Size(302, 27);
            txtBuscarxID.TabIndex = 10;
            txtBuscarxID.TextChanged += txtBuscarxID_TextChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(70, 37);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 35);
            panel3.TabIndex = 12;
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(7, 109);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(586, 315);
            dgvClientes.TabIndex = 11;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(811, 740);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            BackgroundImageChanged += textBox1_TextChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtBuscarxID;
        private Panel panel3;
        private DataGridView dgvClientes;
        private Label label1;
        private PictureBox pictureBox1;
        private Label TelfC;
        private Label Estado;
        private Label SA;
        private Label DirC;
        private Label PA;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxEstado;
        private TextBox txtSN;
        private TextBox txtPRA;
        private TextBox txtSA;
        private TextBox txtTelf;
        private TextBox txtDirC;
        private TextBox txtPN;
        private Label label4;
    }
}