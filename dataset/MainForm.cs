using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Ejercicio3
{
	public partial class MainForm : Form
	{
		DataSet ds = new DataSet( "DataSet" );
		
		public MainForm( )
		{
			DataTable t1 = new DataTable( "Clientes" );
			
			t1.Columns.Add( new DataColumn( "idCliente", typeof( int ) ) );
			t1.Columns.Add( new DataColumn( "Apellido", typeof( string ) ) );
			t1.Columns.Add( new DataColumn( "Nombre", typeof( string ) ) );
			t1.Columns.Add( new DataColumn( "Direccion", typeof( string ) ) );
			t1.Columns.Add( new DataColumn( "Telefono", typeof( string ) ) );
			
			DataTable t2 = new DataTable( "Ordenes" );
			
			t2.Columns.Add( new DataColumn( "idCliente", typeof( int ) ) );
			t2.Columns.Add( new DataColumn( "idOrden", typeof( int ) ) );
			t2.Columns.Add( new DataColumn( "Fecha", typeof( DateTime ) ) );
			t2.Columns.Add( new DataColumn( "Detalle", typeof( string ) ) );
			
			ds.Tables.Add( t1 );
			ds.Tables.Add( t2 );
			
			DataColumn colPadre = ds.Tables[ "Clientes" ].Columns[ "idCliente" ];
			DataColumn colHijo = ds.Tables[ "Ordenes" ].Columns[ "idCliente" ];
			
			DataRelation dr = new DataRelation( "Relacion", colPadre, colHijo );
			
			ds.Relations.Add( dr );
			ds.Relations[ "Relacion" ].Nested = true;
			
			InitializeComponent( );
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			if( new FileInfo( Application.StartupPath + "\\dataset.xml" ).Exists )
				ds.ReadXml( "dataset.xml", XmlReadMode.ReadSchema );
			
			bindingSource1.DataSource = ds.Tables[ "Clientes" ];
			
			dataGridView1.DataSource = bindingSource1;
			dataGridView2.DataSource = bindingSource1;
			
			dataGridView2.DataMember = "Relacion";
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			ds.WriteXml( "dataset.xml", XmlWriteMode.WriteSchema );
		}
		
		void CargarToolStripMenuItemClick(object sender, EventArgs e)
		{
			// Datos de prueba
			ds.Tables[ "Clientes" ].Rows.Add( 1, "Lozano", "Manuel", "38 nº 661", "(221) 545-1124" );
			ds.Tables[ "Clientes" ].Rows.Add( 2, "Crosta", "Ivan Leonel", "49 nº 336", "(221) 712-3361" );
			ds.Tables[ "Clientes" ].Rows.Add( 3, "Gonzales", "German", "36 nº 432", "(221) 342-4466" );
			
			ds.Tables[ "Ordenes" ].Rows.Add( 1, 23, new DateTime( 2016, 4, 11 ), "Detalle 1" ) ;
			ds.Tables[ "Ordenes" ].Rows.Add( 2, 61, new DateTime( 2016, 5, 25 ), "Detalle 2" );
			ds.Tables[ "Ordenes" ].Rows.Add( 3, 75, new DateTime( 2016, 6, 14 ), "Detalle 3" );
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close( );
		}
	}
}
