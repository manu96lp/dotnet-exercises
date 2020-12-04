using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Prueba
{
	public partial class MainForm : Form
	{
		DataSet ds = new DataSet( "Mi DataSet" );
		
		public MainForm( )
		{
			InitializeComponent( );
			
			DataTable dt = new DataTable( "Clientes" );
			
			dt.Columns.Add( "idCliente", typeof( int ) );
			dt.Columns.Add( "Nombre", typeof( string ) );
			dt.Columns.Add( "Apellido", typeof( string ) );
			dt.Columns.Add( "Edad", typeof( int ) );
			
			ds.Tables.Add( dt );
			
			dt = new DataTable( "Ordenes" );
			
			dt.Columns.Add( "idOrden", typeof( int ) );
			dt.Columns.Add( "idCliente", typeof( int ) );
			dt.Columns.Add( "Fecha", typeof( DateTime ) );
			
			ds.Tables.Add( dt );
			
			dt = new DataTable( "Proveedores" );
			
			dt.Columns.Add( "idProveedor", typeof( int ) );
			dt.Columns.Add( "Proveedor", typeof( string ) );
			dt.Columns.Add( "Telefono", typeof( string ) );
			dt.Columns.Add( "Pedidos", typeof( int ) );
			
			ds.Tables.Add( dt );
			
			dt = new DataTable( "Contactos" );
			
			dt.Columns.Add( "idContacto", typeof( int ) );
			dt.Columns.Add( "Nombre", typeof( string ) );
			dt.Columns.Add( "Descripcion", typeof( string ) );
			dt.Columns.Add( "Telefono", typeof( int ) );
			
			ds.Tables.Add( dt );
			
			dt = new DataTable( "Articulos" );
			
			dt.Columns.Add( "idArticulo", typeof( int ) );
			dt.Columns.Add( "Stock", typeof( int ) );
			dt.Columns.Add( "Descripcion", typeof( string ) );
			
			ds.Tables.Add( dt );
			
			dt = ds.Tables[ "Clientes" ];
			
			dt.Rows.Add( 1, "Rodrigo", "Perez", 32 );
			dt.Rows.Add( 2, "Sebastian", "Echeverria", 19 );
			dt.Rows.Add( 3, "Franco", "Bonomo", 22 );
			
			dt = ds.Tables[ "Ordenes" ];
			
			dt.Rows.Add( 33, 1, new DateTime( 2016, 6, 22 ) );
			dt.Rows.Add( 15, 2, new DateTime( 2016, 6, 21 ) );
			dt.Rows.Add( 54, 3, new DateTime( 2016, 6, 23 ) );
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			listBox1.DisplayMember = "TableName";
			listBox2.DisplayMember = "ColumnName";
			
			foreach( DataTable dt in ds.Tables )
				listBox1.Items.Add( dt );
			
			listBox1.SelectedItem = listBox1.Items[0];
			
			
			if( new FileInfo( Application.StartupPath + "\\dataset.xml" ).Exists )
				ds.ReadXml( "dataset.xml", XmlReadMode.ReadSchema );
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			ds.WriteXml( "dataset.xml", XmlWriteMode.WriteSchema );
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox2.Items.Clear( );
			
			if( listBox1.SelectedItem != null )
			{
				dataGridView1.DataSource = (DataTable)listBox1.SelectedItem;
				
				foreach( DataColumn dc in (listBox1.SelectedItem as DataTable).Columns )
					listBox2.Items.Add( dc );
				
				listBox2.SelectedItem = listBox2.Items[0];
			}
		}
		
		void ListBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			if( listBox2.SelectedItem != null )
			{
				foreach( DataGridViewColumn dc in dataGridView1.Columns )
					dc.Visible = false;
				
				dataGridView1.Columns[ listBox2.SelectedIndex ].Visible = true;
				dataGridView1.Columns[ listBox2.SelectedIndex ].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}
	}
}
