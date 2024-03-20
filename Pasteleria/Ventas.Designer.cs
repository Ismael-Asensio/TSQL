namespace Pasteleria
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            panel2 = new Panel();
            dgvProductos = new DataGridView();
            dgvCarrito = new DataGridView();
            NombreProducto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            BarraTitulo = new Panel();
            txtComprar = new TextBox();
            lblHora = new Label();
            panel1 = new Panel();
            lblFecha = new Label();
            btnCerrar = new PictureBox();
            btnRayita = new PictureBox();
            pictureBox2 = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            label1 = new Label();
            panel6 = new Panel();
            button2 = new Button();
            btnComprar = new Button();
            btnActualizar = new Button();
            comboBoxProductos = new ComboBox();
            txtPrecUnit = new TextBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            txtIDC = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRayita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 64);
            panel2.TabIndex = 9;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(94, 43);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(736, 196);
            dgvProductos.TabIndex = 11;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellValueChanged += dgvProductos_CellValueChanged;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { NombreProducto, Cantidad, PrecioUnitario, Total, IdCliente });
            dgvCarrito.Location = new Point(94, 396);
            dgvCarrito.Margin = new Padding(3, 4, 3, 4);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(621, 200);
            dgvCarrito.TabIndex = 12;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "NombreProducto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "PrecioUnitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "IdCliente";
            IdCliente.MinimumWidth = 6;
            IdCliente.Name = "IdCliente";
            IdCliente.Width = 125;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PeachPuff;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(94, 688);
            panel4.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(0, 47);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(95, 72);
            panel5.TabIndex = 11;
            panel5.Click += panel5_Click;
            panel5.Paint += panel5_Paint;
            panel5.MouseEnter += panel5_MouseEnter;
            panel5.MouseLeave += panel5_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OldLace;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 3);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(94, 44);
            panel3.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.Location = new Point(5, 5);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 10;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.OldLace;
            BarraTitulo.Controls.Add(txtComprar);
            BarraTitulo.Controls.Add(lblHora);
            BarraTitulo.Controls.Add(panel1);
            BarraTitulo.Controls.Add(lblFecha);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Controls.Add(btnRayita);
            BarraTitulo.Controls.Add(pictureBox2);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(94, 0);
            BarraTitulo.Margin = new Padding(3, 4, 3, 4);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(836, 47);
            BarraTitulo.TabIndex = 14;
            // 
            // txtComprar
            // 
            txtComprar.Location = new Point(302, 8);
            txtComprar.Margin = new Padding(3, 4, 3, 4);
            txtComprar.Name = "txtComprar";
            txtComprar.Size = new Size(229, 27);
            txtComprar.TabIndex = 57;
            txtComprar.TextChanged += txtComprar_TextChanged;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Sitka Text", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(741, 11);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(48, 20);
            lblHora.TabIndex = 10;
            lblHora.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(242, 8);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(53, 31);
            panel1.TabIndex = 56;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Sitka Text", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(661, 12);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(48, 20);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "label2";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.MediumSeaGreen;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(2160, 0);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(47, 47);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            // 
            // btnRayita
            // 
            btnRayita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRayita.BackColor = Color.MediumSeaGreen;
            btnRayita.Cursor = Cursors.Hand;
            btnRayita.Image = (Image)resources.GetObject("btnRayita.Image");
            btnRayita.Location = new Point(2064, 0);
            btnRayita.Margin = new Padding(3, 4, 3, 4);
            btnRayita.Name = "btnRayita";
            btnRayita.Size = new Size(47, 47);
            btnRayita.SizeMode = PictureBoxSizeMode.Zoom;
            btnRayita.TabIndex = 3;
            btnRayita.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.MediumSeaGreen;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1421, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.MediumSeaGreen;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(2118, 0);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(40, 47);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.MediumSeaGreen;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(2118, 0);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(47, 47);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(101, 323);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 15;
            label1.Text = "Carrito Compras";
            // 
            // panel6
            // 
            panel6.BackColor = Color.PeachPuff;
            panel6.Controls.Add(button2);
            panel6.Controls.Add(btnComprar);
            panel6.Location = new Point(94, 600);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(874, 88);
            panel6.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(12, 32);
            button2.Name = "button2";
            button2.Size = new Size(156, 29);
            button2.TabIndex = 30;
            button2.Text = "Exportar Compra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnComprar
            // 
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.Image = (Image)resources.GetObject("btnComprar.Image");
            btnComprar.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprar.Location = new Point(619, 0);
            btnComprar.Margin = new Padding(3, 4, 3, 4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(201, 88);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(837, 55);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(78, 75);
            btnActualizar.TabIndex = 17;
            btnActualizar.TextAlign = ContentAlignment.TopRight;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(101, 271);
            comboBoxProductos.Margin = new Padding(3, 4, 3, 4);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(138, 28);
            comboBoxProductos.TabIndex = 18;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // txtPrecUnit
            // 
            txtPrecUnit.Enabled = false;
            txtPrecUnit.Location = new Point(368, 271);
            txtPrecUnit.Margin = new Padding(3, 4, 3, 4);
            txtPrecUnit.Name = "txtPrecUnit";
            txtPrecUnit.Size = new Size(129, 27);
            txtPrecUnit.TabIndex = 20;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(247, 271);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 251);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 23;
            label2.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 251);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 24;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 251);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 25;
            label4.Text = "Precio Unitario";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(504, 271);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtIDC
            // 
            txtIDC.Enabled = false;
            txtIDC.Location = new Point(666, 271);
            txtIDC.Margin = new Padding(3, 4, 3, 4);
            txtIDC.Name = "txtIDC";
            txtIDC.Size = new Size(114, 27);
            txtIDC.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(551, 251);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 28;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(691, 251);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 29;
            label6.Text = "IDCliente";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(752, 396);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(61, 58);
            button3.TabIndex = 30;
            button3.TextAlign = ContentAlignment.TopRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(930, 688);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtIDC);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecUnit);
            Controls.Add(comboBoxProductos);
            Controls.Add(btnActualizar);
            Controls.Add(panel6);
            Controls.Add(label1);
            Controls.Add(BarraTitulo);
            Controls.Add(panel4);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ventas";
            Text = "Ventas";
            FormClosed += Ventas_FormClosed;
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRayita).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvProductos;
        private DataGridView dgvCarrito;
        private Panel panel4;
        private Panel BarraTitulo;
        private Label lblHora;
        private Panel panel1;
        private Label lblFecha;
        private PictureBox btnCerrar;
        private PictureBox btnRayita;
        private PictureBox pictureBox2;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private Panel panel5;
        private Panel panel3;
        private Label label1;
        private Panel panel6;
        private Button btnComprar;
        private TextBox txtComprar;
        private Button btnActualizar;
        private ComboBox comboBoxProductos;
        private TextBox txtPrecUnit;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Total;
        private TextBox txtCantidad;
        private DataGridViewTextBoxColumn IdCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox txtIDC;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}