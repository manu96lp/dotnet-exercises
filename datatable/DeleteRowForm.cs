using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio1
{
	public partial class DeleteRowForm : Form
	{
		public int rowCount { get; set; }
		private RemoveButtonClickEventHandler removeButtonClick;
		
		public DeleteRowForm( )
		{
			InitializeComponent( );
		}
		
		public event RemoveButtonClickEventHandler RemoveButtonClick
		{
			add { removeButtonClick += value; }
			remove { removeButtonClick -= value; }
		}
		
		void DeleteRowFormLoad(object sender, EventArgs e)
		{
			for( int i = 0; i < rowCount; i++ )
				comboBox1.Items.Add( String.Format( "Fila {0}", i ) );
			
			comboBox1.SelectedItem = comboBox1.Items[0];
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if( removeButtonClick != null )
				removeButtonClick( this, new RemoveButtonClickEventArgs( ) { rowIndex = comboBox1.SelectedIndex } );
			
			this.Close( );
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close( );
		}
	}
	
	public delegate void RemoveButtonClickEventHandler(object sender, RemoveButtonClickEventArgs e);
	public class RemoveButtonClickEventArgs:EventArgs { public int rowIndex { get; set; } }
}
