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
	public partial class decision : Form
	{
		public static int ind;
		public decision()
		{
			InitializeComponent();
			//решение
			otv(Form_inp.lit, Form_inp.line +1, Form_inp.line + 1,listView_resh);
			//ответ
			otv(Form_inp.otv,1, Form_inp.line,listView_otv);

		}

		//закрытие формы
		private void decision_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Close();
		}

		//ответ рисует
		private void otv(double [,,] mass,int x,int y,ListView lol)
		{
			
			for (int i = 0; i <= x; i++)
			{
				lol.Columns.Add("");
			}
			
			for (int i = 0; i <= y; i++)
			{
				ListViewItem joj;
				string[] f = new string[x+1];
				for (int j = 0; j <= x; j++)
				{
					f[j]=Convert.ToString( mass[ind, j, i]);
				}
				joj= new ListViewItem(f);
				lol.Items.Add(joj);

			}

		}
	}
}
