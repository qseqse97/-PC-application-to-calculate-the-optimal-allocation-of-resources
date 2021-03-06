﻿using System;
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
	public partial class Form_inp : Form
	{
		public static int line ;
		public static int column;


		//решение
		public static double[,,] lit;

		//ответы решений
		public static double[,,] otv;

		//ответ и данные
		public static List<List<double>> dan = new List<List<double>>(2);


		public Form_inp()
		{
			InitializeComponent();

			dataGridView_otv.AllowUserToAddRows = false;
			dataGridView_inp.AllowUserToAddRows = false;

			dataGridView_inp.RowCount = line;
			dataGridView_inp.ColumnCount = column;

			//предприятия 
			for (int i =1; i <= column; i++)
			{
				dataGridView_inp.Columns[i-1].HeaderText = "предп " + Convert.ToString(i);

			}
			
			dataGridView_inp.TopLeftHeaderCell.Value = "Запас средств";


			//запрет на сортировку
			foreach (DataGridViewColumn currDgvColumn in dataGridView_inp.Columns)
			{
				currDgvColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			}

			//строки
			for (int i=1;i<=line;i++)
			{
				//dataGridView_inp.Rows[i].Cells[0].Value = Convert.ToString(i);
				dataGridView_inp.Rows[i-1].HeaderCell.Value = Convert.ToString( i);
			}

			listBox1.Text = "Введите значения и нажмите кнопку просчет ";

			dataGridView_inp.Rows[0].Cells[0].Value =  7.1;
			dataGridView_inp.Rows[1].Cells[0].Value = 9;
			dataGridView_inp.Rows[2].Cells[0].Value = 18.8;
			dataGridView_inp.Rows[3].Cells[0].Value = 25.8;
			dataGridView_inp.Rows[4].Cells[0].Value = 27.6;
			dataGridView_inp.Rows[5].Cells[0].Value = 32.3;
			dataGridView_inp.Rows[6].Cells[0].Value = 42.1;
			dataGridView_inp.Rows[7].Cells[0].Value = 45.7;
			dataGridView_inp.Rows[8].Cells[0].Value = 50.3;
			dataGridView_inp.Rows[9].Cells[0].Value =50.3;

			dataGridView_inp.Rows[0].Cells[1].Value = 7.4;
			dataGridView_inp.Rows[1].Cells[1].Value = 8.4;
			dataGridView_inp.Rows[2].Cells[1].Value = 13.9;
			dataGridView_inp.Rows[3].Cells[1].Value = 15.4;
			dataGridView_inp.Rows[4].Cells[1].Value = 23.4;
			dataGridView_inp.Rows[5].Cells[1].Value = 27.1;
			dataGridView_inp.Rows[6].Cells[1].Value = 36.8;
			dataGridView_inp.Rows[7].Cells[1].Value = 37.8;
			dataGridView_inp.Rows[8].Cells[1].Value = 37.8;
			dataGridView_inp.Rows[9].Cells[1].Value = 37.8;

			dataGridView_inp.Rows[0].Cells[2].Value = 1.2;
			dataGridView_inp.Rows[1].Cells[2].Value = 4.1;
			dataGridView_inp.Rows[2].Cells[2].Value = 5.9;
			dataGridView_inp.Rows[3].Cells[2].Value = 7.3;
			dataGridView_inp.Rows[4].Cells[2].Value = 15.9;
			dataGridView_inp.Rows[5].Cells[2].Value = 21.6;
			dataGridView_inp.Rows[6].Cells[2].Value = 21.9;
			dataGridView_inp.Rows[7].Cells[2].Value = 21.9;
			dataGridView_inp.Rows[8].Cells[2].Value = 21.9;
			dataGridView_inp.Rows[9].Cells[2].Value = 21.9;

			dataGridView_inp.Rows[0].Cells[3].Value = 7.5;
			dataGridView_inp.Rows[1].Cells[3].Value = 11.3;
			dataGridView_inp.Rows[2].Cells[3].Value = 17.8;
			dataGridView_inp.Rows[3].Cells[3].Value = 27.6;
			dataGridView_inp.Rows[4].Cells[3].Value = 29.2;
			dataGridView_inp.Rows[5].Cells[3].Value = 29.4;
			dataGridView_inp.Rows[6].Cells[3].Value = 29.4;
			dataGridView_inp.Rows[7].Cells[3].Value = 29.4;
			dataGridView_inp.Rows[8].Cells[3].Value = 29.4;
			dataGridView_inp.Rows[9].Cells[3].Value = 29.4;
		}

		//выход из программы
		private void Form_inp_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		//проверка на ввод
		private void dataGridView_inp_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			TextBox tb = (TextBox)e.Control;
			tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
			Convert.ToString(tb);
		}

		//дополнительно проверка на код 2 часть
		void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			string vlCell = ((TextBox)sender).Text;
			bool temp = (vlCell.IndexOf(",") == -1);
			if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (vlCell.IndexOf(",") == -1) && (vlCell.Length != 0)))
			{
				if (e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}
			}
		}

		//Проверка полей на 0 и null
		private Boolean neeel()
		{
			Boolean flag = true;
			for (int i = 0; i < column; i++)
			{
				for (int j = 0; j < line; j++)
				{
					if ((dataGridView_inp.Rows[j].Cells[i].Value == "") || (dataGridView_inp.Rows[j].Cells[i].Value == null))
					{
						flag = false;
						break;
					}


				}
				if (flag == false) break;
			}
			return flag;

		}

		//нажатие на кнопку расчитать
		private void button1_Click(object sender, EventArgs e)
		{
			lit = new double[column - 1, 2 + line, 2 + line];
			otv = new double[column , 2, line + 1];
			dan.Clear();
            comboBox_otv.Items.Clear();
			int g = 1;
			//проверка полей на 0
			if (neeel())
			{
				//запись в дано
				van(dan);

				//нахождение ответа
				Faind_otv(0,g);
				string resh="Решение";
				int k = column;
				for (int i = 0; i <= column - 2; i++)
				{

					string s;
					s=resh +Convert.ToString(k);
					--k;
					g++;
					//запись в lit начал знач
					Cset_lit(i);
					//просчет
					proscht(i);
					//нахождение ответа
					Faind_otv(i+1,g);
					comboBox_otv.Items.Add(s);
				}
				ris_otv();

			}
			else
			{
				MessageBox.Show("поля пустые");
			}
		}
		
		//считывает с datagrid в dan
		private void van(List<List<double>> mass)
		{
			for (int i = 0; i < line; i++)
			{
				List<double> m = new List<double>();
				for (int j = 0; j < column; j++)
				{					
					m.Add(Convert.ToDouble(dataGridView_inp.Rows[i].Cells[j].Value.ToString()));
				}
				mass.Add(m);
			}
			
		}

		//считывает с otv и записывает в lit
		private void Cset_lit(int x)
		{
			lit[x,0,0] = 0;
			lit[x,0,1] = 0;
			lit[x,1,0] = 0;
			lit[x,1,1] = 0;
			// считываем с dan
			if (x == 0)
			{
				for(int i = 0; i <= line-1; i++)
				{
					//лево
					lit[0,0,i + 2] = dan[i][column - 1];
					//вверх
					lit[0,i + 2,0] = dan[i][column - 2];

				}
			}
			else
			//считываем с otv
			{
				//otv
				for(int i = 1; i <= line+1; i++)
				{
					//лево
					lit[x,0,i] = otv[x,1,i-1];
					//lit[x, i+2, 0] = dan[0][i-1][column - 2 - x];
				}

				//dan
				for (int i = 0; i <= line-1; i++)
				{
					//вверх
					lit[x, i+2, 0] = dan[i][column - 2 - x];
				}
			}
		}

		//Поиск ответа
		private void Faind_otv(int x,int g)
		{
            //не первый и не последний
			if ((g!= column)&&(g!=1))
			{
				for (int j = 1; j <= line + 1; j++)
				{
					int ind = 0;
					double max = lit[x-1, 1, j];

					for (int i = 1; i <= line + 1; i++)
					{
						if (lit[x-1, i, j] > max)
						{
							max = lit[x-1, i, j];
							ind = i;
						}
					}
					if (ind == 0)
						otv[x, 0, j - 1] = ind;
					else
						otv[x, 0, j - 1] = ind - 1;
					otv[x, 1, j - 1] = max;
				}
			}
			else
			//первое
			if(g==1)
			{
				for (int i=0;i<=line;i++)
				{
					otv[x, 0, i] = i;
					if (i == 0) otv[x, 1, i] = 0;
					else
						otv[x, 1, i] = dan[i - 1][column - 1];
				}
			}
			else//последний
				if (g == column)
			{
				int ind = 0;
				double max = lit[x - 1, 0, 11];
				for (int i = 1; i <= line+1; i++)
				{
					if (lit[x - 1, i, 11] > max)
					{
						max = lit[x - 1, i, 11];
						ind = i;
					}
				}
				otv[x, 1, 10] = max;
				otv[x, 0, 10] = ind-1;
			}

		}

		//Просчет
		private void proscht(int x)
		{

				int h = 1, sas;
				for (int i = 1; i < line + 2; i++)
				{
					sas = 1;
					for (int j = h; j < line + 2; j++)
					{
						//             лево             вверх
						lit[x, i, j] = lit[x, 0, sas] + lit[x, i, 0];
						sas++;
					}
					h++;
				}	
		}

		//Рисует ответ
		private void ris_otv()
		{
			dataGridView_otv.Rows.Clear();
			dataGridView_otv.AllowUserToAddRows = false;

			//строк
			dataGridView_otv.RowCount = line+1;
			//столбцов
			dataGridView_otv.ColumnCount = (column*2);

            //запрет на сортировку
            foreach (DataGridViewColumn currDgvColumn in dataGridView_otv.Columns)
            {
                currDgvColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
           
			string x = "x";
			string w = "w";
			int s = column; ;

			//предприятия 
			for (int i = 1; i <dataGridView_otv.ColumnCount+1; i++)
			{
				if ((i % 2) == 0)
				{
					dataGridView_otv.Columns[i - 1].HeaderText = w +s+" (s)";
					--s;
				}
				else
				{
					dataGridView_otv.Columns[i - 1].HeaderText = x + s + " (s)";
				}

			}

			//строки
			for (int i = 0; i < dataGridView_otv.RowCount; i++)
			{
				dataGridView_otv.Rows[i].HeaderCell.Value = Convert.ToString(i);
			}

			s =0;

			//заполнение ответами
			for (int i=1;i<=dataGridView_otv.ColumnCount;i++)
			{
				for (int j=0;j<dataGridView_otv.RowCount;j++)
				{
					if (i % 2 != 0)
					{
						dataGridView_otv.Rows[j].Cells[i-1].Value = otv[s, 0, j ];
						dataGridView_otv.Rows[j].Cells[i-1].ReadOnly = true;
					}
					else
					{
						dataGridView_otv.Rows[j].Cells[i-1].Value =otv[s,1,j];
						dataGridView_otv.Rows[j].Cells[i-1].ReadOnly = true;
					}
				}
				if (i % 2 == 0) ++s;
			}



		}

		//смена item,,нажатие на решение
		private void comboBox_otv_SelectedIndexChanged(object sender, EventArgs e)
		{
			decision.ind =comboBox_otv.SelectedIndex ;
			decision g = new decision();
			this.Hide();
			
			g.ShowDialog();
			this.Show();
		}

        //закрыть
        private void button_naz_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form ifrm = Application.OpenForms[0];
			ifrm.Show();
		}
	}
}