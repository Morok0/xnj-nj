using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox3.Text = "";
            int move = 0;
            string[] array = new string[] { "а", "б", "в",
 "г", "д", "е", "ё", "ж",
"з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с",
"т", "у", "ф", "х",
 "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            try
            {
                move = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Установите шаг шифрования!");
                return;
            }

            string[] array2;
            array2 = array.Skip(move).Concat(array.Take(move)).ToArray();
            //Данная функция смещает по кругу ячейки массива.Для расшифровки стоит просто поменять move на 33 - move
                foreach (string element in array2)
                {
                 listBox1.Items.Add(element.ToString()); //добвляем в ЛистБокс новый алфавит
                }

            string text = textBox2.Text;
            foreach (char bykva in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (bykva.ToString().ToLower() == array[i])
                    {
                        textBox3.Text += array2[i];
                        break;
                    }
                    else
                    {
                        if (bykva.ToString() == " " || bykva.ToString() == "." ||
                        bykva.ToString() == "," || bykva.ToString() == ":" ||
                        bykva.ToString() == ";" || bykva.ToString() == "?" ||
                        bykva.ToString() == "!") // эти знаки печатаются без зашифровки
                        {
                            textBox3.Text += " ";
                            break;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox6.Text = "";
            int move = 0;
            string[] array = new string[] { "а", "б", "в",
 "г", "д", "е", "ё", "ж",
"з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с",
"т", "у", "ф", "х",
 "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            try
            {
                move = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Установите шаг шифрования!");
                return;
            }

            string[] array2;
            array2 = array.Skip(33 - move).Concat(array.Take(33 - move)).ToArray();
            //Данная функция смещает по кругу ячейки массива.Для расшифровки стоит просто поменять move на 33 - move
            foreach (string element in array2)
            {
                listBox1.Items.Add(element.ToString()); //добвляем в ЛистБокс новый алфавит
            }

            string text = textBox5.Text;
            foreach (char bykva in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (bykva.ToString().ToLower() == array[i])
                    {
                        textBox6.Text += array2[i];
                        break;
                    }
                    else
                    {
                        if (bykva.ToString() == " " || bykva.ToString() == "." ||
                        bykva.ToString() == "," || bykva.ToString() == ":" ||
                        bykva.ToString() == ";" || bykva.ToString() == "?" ||
                        bykva.ToString() == "!") // эти знаки печатаются без зашифровки
                        {
                            textBox6.Text += " ";
                            break;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " "; textBox2.Text = " "; textBox3.Text = " "; textBox4.Text = " "; textBox5.Text = " "; textBox6.Text = " ";
        }

        private void label7_Click(object sender, EventArgs e)
        {
           

        }
    }
}
