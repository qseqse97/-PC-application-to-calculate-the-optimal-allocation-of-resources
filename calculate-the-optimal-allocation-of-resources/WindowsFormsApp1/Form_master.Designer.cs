namespace WindowsFormsApp1
{
	partial class Form_master
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox_pred = new System.Windows.Forms.TextBox();
			this.button_ok = new System.Windows.Forms.Button();
			this.textBox_str = new System.Windows.Forms.TextBox();
			this.label_pred = new System.Windows.Forms.Label();
			this.label_str = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox_pred
			// 
			this.textBox_pred.Location = new System.Drawing.Point(12, 25);
			this.textBox_pred.Name = "textBox_pred";
			this.textBox_pred.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox_pred.Size = new System.Drawing.Size(100, 20);
			this.textBox_pred.TabIndex = 1;
			this.textBox_pred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// button_ok
			// 
			this.button_ok.Location = new System.Drawing.Point(32, 90);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(75, 23);
			this.button_ok.TabIndex = 3;
			this.button_ok.Text = "ОК";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox_str
			// 
			this.textBox_str.Location = new System.Drawing.Point(12, 64);
			this.textBox_str.Name = "textBox_str";
			this.textBox_str.Size = new System.Drawing.Size(100, 20);
			this.textBox_str.TabIndex = 4;
			this.textBox_str.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label_pred
			// 
			this.label_pred.AutoSize = true;
			this.label_pred.Location = new System.Drawing.Point(9, 9);
			this.label_pred.Name = "label_pred";
			this.label_pred.Size = new System.Drawing.Size(134, 13);
			this.label_pred.TabIndex = 2;
			this.label_pred.Text = "Количество предприятий";
			// 
			// label_str
			// 
			this.label_str.AutoSize = true;
			this.label_str.Location = new System.Drawing.Point(9, 48);
			this.label_str.Name = "label_str";
			this.label_str.Size = new System.Drawing.Size(98, 13);
			this.label_str.TabIndex = 5;
			this.label_str.Text = "Количество строк\r\n";
			// 
			// Form_master
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(144, 115);
			this.Controls.Add(this.label_str);
			this.Controls.Add(this.textBox_str);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.label_pred);
			this.Controls.Add(this.textBox_pred);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_master";
			this.Text = "Главная форма";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_master_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_pred;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.TextBox textBox_str;
		private System.Windows.Forms.Label label_pred;
		private System.Windows.Forms.Label label_str;
	}
}

