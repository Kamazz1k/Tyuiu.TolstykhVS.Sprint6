using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TolstykhVS.Sprint6.Task0.V25.Lib;
using Tyuiu.TolstykhVS.Sprint6.Task0;
namespace Tyuiu.TolstykhVS.Sprint6.Task0.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DataService ds = new DataService();
                try
                {
                    textBoxRezult_TVS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_GDV.Text)));
                }
                catch
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-23-1 Толстых Вячеслав Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxRezult_TVS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
