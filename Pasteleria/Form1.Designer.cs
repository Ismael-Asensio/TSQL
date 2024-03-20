namespace Pasteleria
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnUser = new Button();
            label5 = new Label();
            label6 = new Label();
            btnAdmin = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 474);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2023_11_14_at_6_42_14_PM;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 471);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 47);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a Rosa Pastel ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(339, 73);
            label2.Name = "label2";
            label2.Size = new Size(240, 21);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su cuenta para continuar ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(309, 221);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 23);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(309, 283);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(238, 23);
            txtPass.TabIndex = 6;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.SeaShell;
            btnUser.Location = new Point(309, 343);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(238, 41);
            btnUser.TabIndex = 7;
            btnUser.Text = "LOG IN ";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 408);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 8;
            label5.Text = "No tienes una cuenta?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 408);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 9;
            label6.Text = "Registrese";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.SeaShell;
            btnAdmin.Location = new Point(309, 343);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(238, 41);
            btnAdmin.TabIndex = 10;
            btnAdmin.Text = "LOG IN ";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(388, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 203);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 265);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 13;
            label4.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(711, 474);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(btnAdmin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnUser);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnUser;
        private Label label5;
        private Label label6;
        private Button btnAdmin;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
    }
}