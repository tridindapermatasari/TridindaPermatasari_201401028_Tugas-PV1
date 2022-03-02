/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 28/2/2022
 * Time: 11:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas_1._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.insertbarang = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.teksbarang = new System.Windows.Forms.TextBox();
			this.listbarang = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// insertbarang
			// 
			this.insertbarang.Location = new System.Drawing.Point(180, 88);
			this.insertbarang.Name = "insertbarang";
			this.insertbarang.Size = new System.Drawing.Size(75, 23);
			this.insertbarang.TabIndex = 0;
			this.insertbarang.Text = "insert";
			this.insertbarang.UseVisualStyleBackColor = true;
			this.insertbarang.Click += new System.EventHandler(this.InsertbarangClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(59, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Masukkan nama barang";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// teksbarang
			// 
			this.teksbarang.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.teksbarang.Location = new System.Drawing.Point(59, 62);
			this.teksbarang.Name = "teksbarang";
			this.teksbarang.Size = new System.Drawing.Size(196, 20);
			this.teksbarang.TabIndex = 2;
			// 
			// listbarang
			// 
			this.listbarang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.listbarang.FormattingEnabled = true;
			this.listbarang.Location = new System.Drawing.Point(59, 165);
			this.listbarang.Name = "listbarang";
			this.listbarang.Size = new System.Drawing.Size(196, 134);
			this.listbarang.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(59, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "List barang";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(321, 325);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listbarang);
			this.Controls.Add(this.teksbarang);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.insertbarang);
			this.Name = "MainForm";
			this.Text = "Aplikasi Sederhana";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listbarang;
		private System.Windows.Forms.TextBox teksbarang;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button insertbarang;
	}
}
