using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pasteleria
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private Form ActiveForm;
       


        private void OpenForm(Form OForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }

            ActiveForm = OForm;
            OForm.TopLevel = false;
            OForm.Dock = DockStyle.Fill;
            pContainer.Controls.Add(OForm);
            pContainer.Tag = OForm;
            OForm.FormBorderStyle = FormBorderStyle.None;

            // Ajustar la posición del formulario
            OForm.Location = new Point((pContainer.Width - OForm.Width) / 2, (pContainer.Height - OForm.Height) / 2);

            OForm.BringToFront();
            OForm.Show();

            foreach (Control control in OForm.Controls)
            {
                control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                control.Dock = DockStyle.Fill;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            OpenForm(new Clientes());

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new RegEmpleados());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
                ActiveForm = null;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenForm(new ProductosAdmin());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new RegMP());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm(new RegSucursales());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new DetalleVenta());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
