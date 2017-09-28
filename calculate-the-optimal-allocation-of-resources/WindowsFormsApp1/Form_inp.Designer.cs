namespace WindowsFormsApp1
{
	partial class Form_inp
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label_inp = new System.Windows.Forms.Label();
			this.button_bill = new System.Windows.Forms.Button();
			this.dataGridView_inp = new System.Windows.Forms.DataGridView();
			this.comboBox_otv = new System.Windows.Forms.ComboBox();
			this.dataGridView_otv = new System.Windows.Forms.DataGridView();
			this.button_naz = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_inp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_otv)).BeginInit();
			this.SuspendLayout();
			// 
			// label_inp
			// 
			this.label_inp.AutoSize = true;
			this.label_inp.Location = new System.Drawing.Point(9, 9);
			this.label_inp.Name = "label_inp";
			this.label_inp.Size = new System.Drawing.Size(123, 13);
			this.label_inp.TabIndex = 0;
			this.label_inp.Text = "Таблица ввода данных";
			// 
			// button_bill
			// 
			this.button_bill.Location = new System.Drawing.Point(11, 227);
			this.button_bill.Name = "button_bill";
			this.button_bill.Size = new System.Drawing.Size(75, 23);
			this.button_bill.TabIndex = 2;
			this.button_bill.Text = "Подсчитать ";
			this.button_bill.UseVisualStyleBackColor = true;
			this.button_bill.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView_inp
			// 
			this.dataGridView_inp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_inp.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_inp.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_inp.Location = new System.Drawing.Point(11, 25);
			this.dataGridView_inp.Name = "dataGridView_inp";
			this.dataGridView_inp.Size = new System.Drawing.Size(240, 196);
			this.dataGridView_inp.TabIndex = 5;
			this.dataGridView_inp.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_inp_EditingControlShowing_1);
			// 
			// comboBox_otv
			// 
			this.comboBox_otv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_otv.FormattingEnabled = true;
			this.comboBox_otv.Location = new System.Drawing.Point(130, 227);
			this.comboBox_otv.Name = "comboBox_otv";
			this.comboBox_otv.Size = new System.Drawing.Size(121, 21);
			this.comboBox_otv.TabIndex = 6;
			// 
			// dataGridView_otv
			// 
			this.dataGridView_otv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_otv.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_otv.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_otv.Location = new System.Drawing.Point(257, 25);
			this.dataGridView_otv.Name = "dataGridView_otv";
			this.dataGridView_otv.Size = new System.Drawing.Size(104, 196);
			this.dataGridView_otv.TabIndex = 7;
			// 
			// button_naz
			// 
			this.button_naz.Location = new System.Drawing.Point(286, 225);
			this.button_naz.Name = "button_naz";
			this.button_naz.Size = new System.Drawing.Size(75, 23);
			this.button_naz.TabIndex = 8;
			this.button_naz.Text = "Назад";
			this.button_naz.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(13, 257);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(348, 43);
			this.listBox1.TabIndex = 9;
			// 
			// Form_inp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 305);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button_naz);
			this.Controls.Add(this.dataGridView_otv);
			this.Controls.Add(this.comboBox_otv);
			this.Controls.Add(this.dataGridView_inp);
			this.Controls.Add(this.button_bill);
			this.Controls.Add(this.label_inp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_inp";
			this.Text = "Форма ввода";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_inp_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_inp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_otv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_inp;
		private System.Windows.Forms.Button button_bill;
		private System.Windows.Forms.DataGridView dataGridView_inp;
		private System.Windows.Forms.ComboBox comboBox_otv;
		private System.Windows.Forms.DataGridView dataGridView_otv;
		private System.Windows.Forms.Button button_naz;
		private System.Windows.Forms.ListBox listBox1;
	}
}