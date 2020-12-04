using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Ejercicio1
{
	public partial class MainForm : Form
	{
		DataSet ds = new DataSet( "DataSet" );
		
		public MainForm( )
		{
			DataTable dt = new DataTable( "Usuarios" );
			
			dt.Columns.Add( new DataColumn( "Nombre", typeof( string ) ) );
			dt.Columns.Add( new DataColumn( "Apellido", typeof( string ) ) );
			dt.Columns.Add( new DataColumn( "Edad", typeof( int ) ) );
			
			ds.Tables.Add( dt );
			
			if( new FileInfo( Application.StartupPath + "\\dataset.xml" ).Exists )
				ds.ReadXml( "dataset.xml", XmlReadMode.ReadSchema );
			
			InitializeComponent( );
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ds.Tables[ "Usuarios" ];
			dataGridView1.AllowUserToAddRows = false;
			
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			ds.WriteXml( "dataset.xml", XmlWriteMode.WriteSchema );
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
				int edad = Convert.ToInt32( textBox3.Text );
				
				if( edad >= 0 )
				{
					ds.Tables[ "Usuarios" ].Rows.Add( textBox1.Text, textBox2.Text, edad );
					CleanTextBoxes( );
				}
				else
					MessageBox.Show( "No se puede introducir edades negativas", "Error", MessageBoxButtons.OK );
			}
			catch {
				MessageBox.Show( "La edad debe ser un numero natural", "Error", MessageBoxButtons.OK );
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			CleanTextBoxes( );
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			DeleteRowForm f = new DeleteRowForm( );
			
			f.rowCount = ds.Tables[ "Usuarios" ].Rows.Count;
			f.RemoveButtonClick += RemoveButtonClick;
			
			f.ShowDialog( );
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if( MessageBox.Show( "¿Está seguro de borrar todas las filas?", "Confirmación", MessageBoxButtons.YesNo ) == DialogResult.Yes )
			{
				ds.Tables[ "Usuarios" ].Clear( );
			}
		}
		
		void RemoveButtonClick(object sender, RemoveButtonClickEventArgs e)
		{
			ds.Tables[ "Usuarios" ].Rows.RemoveAt( e.rowIndex );
		}
		
		void NewRowTextBoxesTextChanged(object sender, EventArgs e)
		{
			button1.Enabled = ( textBox1.Text.Length >= 3 && textBox2.Text.Length >= 3 && textBox3.Text.Length >= 1 );
			button2.Enabled = ( textBox1.Text.Length + textBox2.Text.Length + textBox3.Text.Length > 0 );
		}
		
		void DataGridView1RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if( !button3.Enabled )
			{
				button3.Enabled = true;
				button4.Enabled = true;
			}
		}
		
		void DataGridView1RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if( ( ds.Tables[ "Usuarios" ].Rows.Count - e.RowCount ) <= 0 )
			{
				button3.Enabled = false;
				button4.Enabled = false;
			}
		}
		
		void CleanTextBoxes( )
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}
	}
}
