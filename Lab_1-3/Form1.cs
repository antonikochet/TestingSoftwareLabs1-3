using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            List<int> listNumber = null;
            try
            {
                listNumber = Module1.ConvertStringInInt(Module1.ConvertStringInMasString(text));
                if (Module1.CheckList(listNumber))
                {
                    int countList = listNumber.Count;
                    listNumber = Module2.MainsFor(listNumber);
                    if (listNumber.Count!=countList)
                        MessageBox.Show(Module1.ConvertListInString(listNumber));
                    else
                        MessageBox.Show("Чисел удовлетворяющих условию нет!", "Предупреждение!");
                }
                else
                    MessageBox.Show("Ошибка ввода данных","Ошибка!");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message,"Ошибка");
            }
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
