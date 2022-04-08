using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шифратор
{
    public partial class Form1 : Form
    {
        string _str, _keyword;
        static char[] ch_rus = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 
            'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 
            'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ','Э', 'Ю', 'Я', ' '
        };
        static char[] ch_eng = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G',
            'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y', 'Z', ' '
        };


        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private string Encode(string str, string key, char[] ch)
        {
            str = str.ToUpper();
            key = key.ToUpper();

            string res = "";
            int keyword_index = 0;
            int N = ch.Length;

            foreach (char str_sym in str)
            {
                int ch_index = 0, k_index = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (str_sym == ch[i]) ch_index = i;
                    if (key[keyword_index] == ch[i]) k_index = i;
                }
                int c = (ch_index + k_index) % N;
                res += ch[c];
                keyword_index++;

                if ((keyword_index + 1) == key.Length) keyword_index = 0;
            }

            return res;
        }

        private string Decode(string str, string key, char[] ch)
        {
            str = str.ToUpper();
            key = key.ToUpper();

            string res = "";
            int keyword_index = 0;
            int N = ch.Length;

            foreach (char str_sym in str)
            {
                int ch_index = 0, k_index = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (str_sym == ch[i]) ch_index = i;
                    if (key[keyword_index] == ch[i]) k_index = i;
                }
                int c = (ch_index + N - k_index) % N;
                res += ch[c];
                keyword_index++;

                if ((keyword_index + 1) == key.Length) keyword_index = 0;
            }

            return res;
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (rd_encoder.Checked == true)
            {
                if (textBox.Text != "" && textBox_keyword.Text != "")
                {
                    if(rd_rus.Checked == true)
                    {
                        _str = textBox.Text;
                        _keyword = textBox_keyword.Text;
                        textBox_result.Text = Encode(_str, _keyword, ch_rus);
                    }
                    else
                    {
                        _str = textBox.Text;
                        _keyword = textBox_keyword.Text;
                        textBox_result.Text = Encode(_str, _keyword, ch_eng);
                    }
                    
                }
            }
            else
            {
                if (textBox.Text != "" && textBox_keyword.Text != "")
                {
                    if (rd_rus.Checked == true)
                    {
                        _str = textBox.Text;
                        _keyword = textBox_keyword.Text;
                        textBox_result.Text = Decode(_str, _keyword, ch_rus);
                    }
                    else
                    {
                        _str = textBox.Text;
                        _keyword = textBox_keyword.Text;
                        textBox_result.Text = Decode(_str, _keyword, ch_eng);
                    }
                }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textBox_result.Text);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rd_eng.Checked == true)
            {
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                    (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                    e.KeyChar == (char)Keys.Back ||
                    e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    textBox_result.Text = "Был установлен запрет на ввод, так как выбран алфавит 'Английский'. ";
                }
            }
            else
            {
                if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') ||
                    (e.KeyChar >= 'а' && e.KeyChar <= 'я') ||
                    e.KeyChar == (char)Keys.Back ||
                    e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = false;
                }
                else { 
                    e.Handled = true;
                    textBox_result.Text = "Был установлен запрет на ввод, так как выбран алфавит 'Русский'. ";
                }
            }
        }

        private void textBox_keyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_KeyPress(sender, e);
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            textBox.Text = (string)(Clipboard.GetData(DataFormats.Text));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBox_result.Clear();
        }
    }
}



