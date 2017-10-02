namespace WindowsFormsApp1
{
	partial class decision
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
			this.listView_resh = new System.Windows.Forms.ListView();
			this.listView_otv = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// listView_resh
			// 
			this.listView_resh.FullRowSelect = true;
			this.listView_resh.Location = new System.Drawing.Point(12, 12);
			this.listView_resh.Name = "listView_resh";
			this.listView_resh.Size = new System.Drawing.Size(421, 296);
			this.listView_resh.TabIndex = 0;
			this.listView_resh.UseCompatibleStateImageBehavior = false;
			this.listView_resh.View = System.Windows.Forms.View.Details;
			// 
			// listView_otv
			// 
			this.listView_otv.FullRowSelect = true;
			this.listView_otv.Location = new System.Drawing.Point(440, 13);
			this.listView_otv.Name = "listView_otv";
			this.listView_otv.Size = new System.Drawing.Size(136, 295);
			this.listView_otv.TabIndex = 1;
			this.listView_otv.UseCompatibleStateImageBehavior = false;
			this.listView_otv.View = System.Windows.Forms.View.Details;
			// 
			// decision
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 320);
			this.Controls.Add(this.listView_otv);
			this.Controls.Add(this.listView_resh);
			this.Name = "decision";
			this.Text = "Решение";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.decision_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView_resh;
		private System.Windows.Forms.ListView listView_otv;
	}
}