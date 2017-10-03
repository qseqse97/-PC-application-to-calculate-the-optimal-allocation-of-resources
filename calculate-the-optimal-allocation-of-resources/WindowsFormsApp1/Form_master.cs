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
	public partial class Form_master : Form
	{
		public Form_master()
		{
			InitializeComponent();
			textBox_pred.Text =Convert.ToString( 4);
			textBox_str.Text = Convert.ToString(10);
		}

		//открытие 2 формы
		private void button1_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32( textBox_pred.Text )<=2  || textBox_pred.Text == "1" ||
				textBox_str.Text == "0" || textBox_str.Text == "1" ||
				textBox_str.Text == "" || textBox_pred.Text == ""
				)
				MessageBox.Show("0 и 1 не может быть значением ");
			else
			{
				Form_inp.column = Convert.ToInt32(textBox_pred.Text);
				Form_inp.line = Convert.ToInt32(textBox_str.Text);
				Form_inp inp = new Form_inp();
				this.Hide();
				inp.ShowDialog();
			}

		}
		
		//проверка на ввод чисел
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
			{
				// цифра
				return;
			}
			
			/*if (e.KeyChar == '.')
			{
				// точку заменим запятой
				e.KeyChar = ',';
			}

			if (e.KeyChar == ',')
			{
				if (textBox1.Text.IndexOf(',') != -1)
				{
					// запятая уже есть в поле редактирования
					e.Handled = true;
				}
				return;
			}*/

			if (Char.IsControl(e.KeyChar))
			{
				// <Enter>, <Backspace>, <Esc>
				if (e.KeyChar == (char)Keys.Enter)
					// нажата клавиша <Enter>
					// установить курсор на кнопку OK
					button_ok.Focus();
				return;
			}

			// остальные символы запрещены
			e.Handled = true;
		}

		//выход из программы
		private void Form_master_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
