using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio2
{
	public partial class MainForm : Form
	{
		static DateTime horaInicio = DateTime.Now;
		
		public MainForm( )
		{
			InitializeComponent( );
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			label4.Text = string.Format( "Left={0} , Top={1}\nWidth={2} , Height={3}", label1.Left, label1.Top, label1.Width, label1.Height );
			
			for( int i = 1; i < 8; i++ )
				comboBox1.Items.Add(i);
			
			for( int i = 8; i <= 100; i++ )
			{
				comboBox1.Items.Add(i);
				domainUpDown1.Items.Add(i);
			}
			
			comboBox1.SelectedItem = comboBox1.Items[ 9 ];
			
			domainUpDown1.Items.Reverse( );
			domainUpDown1.SelectedItem = domainUpDown1.Items[ 88 ];
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int pasos = Convert.ToInt32( comboBox1.Text );
			
			label1.Text = "Arriba";
			label1.Top -= pasos;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int pasos = Convert.ToInt32( comboBox1.Text );
			
			label1.Text = "Derecha";
			label1.Left += pasos;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int pasos = Convert.ToInt32( comboBox1.Text );
			
			label1.Text = "Abajo";
			label1.Top += pasos;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int pasos = Convert.ToInt32( comboBox1.Text );
			
			label1.Text = "Izquierda";
			label1.Left -= pasos;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			label2.Text = (DateTime.Now - horaInicio).ToString( @"hh\:mm\:ss" );
		}
		
		void DomainUpDown1SelectedItemChanged(object sender, EventArgs e)
		{
			int fontSize;
			
			try {
				fontSize = Convert.ToInt32( domainUpDown1.Text );
				
				if( 8 > fontSize )
					fontSize = 8;
				else if( fontSize > 100 )
					fontSize = 100;
				
				label1.Font = new Font(label1.Font.Name, fontSize, label1.Font.Style, label1.Font.Unit);
			}
			catch {
				domainUpDown1.SelectedItem = domainUpDown1.Items[ 88 ];
			}
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			if( colorDialog1.ShowDialog( ) == DialogResult.OK )
				label1.BackColor = colorDialog1.Color;
		}
		
		void Label1Resize(object sender, EventArgs e)
		{
			if( checkBox1.Checked )
				CheckLabelLocation( );
			
			label4.Text = string.Format( "Left={0} , Top={1}\nWidth={2} , Height={3}", label1.Left, label1.Top, label1.Width, label1.Height );
		}
		
		void Label1LocationChanged(object sender, EventArgs e)
		{
			if( checkBox1.Checked )
				CheckLabelLocation( );
			
			label4.Text = string.Format( "Left={0} , Top={1}\nWidth={2} , Height={3}", label1.Left, label1.Top, label1.Width, label1.Height );
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if( checkBox1.Checked )
			{
				// A raiz de tener que verificar tanto al activar el checkbox como
				// al cambiar la font, hice un metodo para no repetir codigo.
				CheckLabelLocation( );
			}
			else
			{
				button1.Enabled = true;
				button2.Enabled = true;
				button3.Enabled = true;
				button4.Enabled = true;
			}
		}
		
		void CheckLabelLocation( )
		{
			if( label1.Top <= 0 )
			{
				label1.Top = 0;
				button1.Enabled = false;
			}
			else button1.Enabled = true;
			
			if( label1.Width + label1.Left >= panel1.Width )
			{
				label1.Left = ( panel1.Width - label1.Width );
				button2.Enabled = false;
			}
			else button2.Enabled = true;
			
			if( label1.Height + label1.Top >= panel1.Height )
			{
				label1.Top = ( panel1.Height - label1.Height );
				button3.Enabled = false;
			}
			else button3.Enabled = true;
			
			if( label1.Left <= 0 )
			{
				label1.Left = 0;
				button4.Enabled = false;
			}
			else button4.Enabled = true;
		}
	}
}
