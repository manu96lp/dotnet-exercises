/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 21/06/2016
 * Time: 04:19 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(331, 137);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(132, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Palabra";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.LocationChanged += new System.EventHandler(this.Label1LocationChanged);
			this.label1.Click += new System.EventHandler(this.Label1Click);
			this.label1.Resize += new System.EventHandler(this.Label1Resize);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 155);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(150, 194);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Controles de movimiento";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 158);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(26, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Paso del movimiento";
			// 
			// button4
			// 
			this.button4.ImageIndex = 2;
			this.button4.ImageList = this.imageList1;
			this.button4.Location = new System.Drawing.Point(6, 95);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(40, 40);
			this.button4.TabIndex = 4;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Button Download-01.png");
			this.imageList1.Images.SetKeyName(1, "Button Next-01.png");
			this.imageList1.Images.SetKeyName(2, "Button Previous-01.png");
			this.imageList1.Images.SetKeyName(3, "Button Upload-01.png");
			// 
			// button3
			// 
			this.button3.ImageIndex = 0;
			this.button3.ImageList = this.imageList1;
			this.button3.Location = new System.Drawing.Point(58, 95);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 3;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.ImageIndex = 1;
			this.button2.ImageList = this.imageList1;
			this.button2.Location = new System.Drawing.Point(104, 95);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 2;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.ImageIndex = 3;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(58, 49);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(26, 19);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Limitar al panel";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 355);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(331, 52);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tiempo";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(319, 28);
			this.label2.TabIndex = 0;
			this.label2.Text = "00:00:00";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(193, 259);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(150, 90);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Información";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(15, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 46);
			this.label4.TabIndex = 0;
			this.label4.Text = "label4";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.domainUpDown1);
			this.groupBox4.Location = new System.Drawing.Point(193, 155);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(150, 90);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Tamaño de la letra";
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Location = new System.Drawing.Point(15, 40);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
			this.domainUpDown1.TabIndex = 0;
			this.domainUpDown1.Text = "12";
			this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.DomainUpDown1SelectedItemChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 419);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Ejercicio2";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
