/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 22/06/2016
 * Time: 05:14 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(239, 152);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nueva fila";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(125, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(19, 113);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(73, 77);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(145, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.TextChanged += new System.EventHandler(this.NewRowTextBoxesTextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(73, 51);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(145, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.NewRowTextBoxesTextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Edad";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(73, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(145, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.NewRowTextBoxesTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(279, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(345, 258);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView1RowsAdded);
			this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView1RowsRemoved);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Location = new System.Drawing.Point(12, 170);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(238, 100);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Opciones de borrado";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(19, 58);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(199, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "Borrar todas las filas";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(19, 29);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(199, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "Borrar una fila";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 282);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Datatables";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
