using Restaurant_Order_App.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_Order_App
{
    public partial class Form1 : Form
    {
        private readonly Connect demo = new Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                demo.getConnect();
                MessageBox.Show("Kết nối CSDL thành công!");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Kết nối CSDL thất bại!");
            }
        }
    }
}
