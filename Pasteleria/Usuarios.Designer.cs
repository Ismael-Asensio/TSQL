namespace Pasteleria
{
    partial class Usuarios
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.catalog_icon_215654;
            pictureBox1.Location = new Point(12, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2849824_basket_buy_market_multimedia_shop_shopping_store_107977;
            pictureBox2.Location = new Point(273, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._3775748_check_date_list_planner_time_108972;
            pictureBox3.Location = new Point(533, 131);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(245, 157);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stylus BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 35);
            label1.TabIndex = 3;
            label1.Text = "¿Que desea realizar?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stylus BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 303);
            label2.Name = "label2";
            label2.Size = new Size(163, 26);
            label2.TabIndex = 4;
            label2.Text = "VER CATALOGO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stylus BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(345, 303);
            label3.Name = "label3";
            label3.Size = new Size(112, 26);
            label3.TabIndex = 5;
            label3.Text = "COMPRAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stylus BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(613, 303);
            label4.Name = "label4";
            label4.Size = new Size(98, 26);
            label4.TabIndex = 6;
            label4.Text = "PEDIDOS";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Location = new Point(1, -1);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}