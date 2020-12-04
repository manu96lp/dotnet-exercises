using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace Ejercicio1
{
	public partial class MainForm : Form
	{
		public MainForm( )
		{
			InitializeComponent( );
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			verListaToolStripMenuItem.Checked = true;
			splitContainer1.Panel2.AutoScroll = true;
			
			for( int i = 1; i <= 5; i++ )
				toolStripComboBox1.Items.Add( String.Format( "Intervalo de presentación: {0} seg.", i * 2 ) );
			
			toolStripComboBox1.SelectedItem = toolStripComboBox1.Items[0];
		}
		
		void AbrirCarpetaToolStripMenuItemClick(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog( );
			
			if( fbd.ShowDialog( ) == DialogResult.OK )
			{
				toolStripStatusLabel1.Text = @fbd.SelectedPath;
				
				DirectoryInfo dir = new DirectoryInfo( @fbd.SelectedPath );
				string[ ] extensions = { ".jpeg", ".jpg", ".gif", ".ico", ".bmp", ".png" };
				
				listBox1.Items.Clear( );
				pictureBox1.Image = null;
				
				listBox1.Items.AddRange( dir.EnumerateFiles( ).Where( f => extensions.Contains( f.Extension.ToLower( ) ) ).ToArray( ) );
				
				if( listBox1.Items.Count > 0 )
					listBox1.SelectedItem = listBox1.Items[0];
			}
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			pictureBox1.Image = Image.FromFile( (listBox1.SelectedItem as FileInfo).FullName );
			toolStripStatusLabel1.Text = (listBox1.SelectedItem as FileInfo).FullName;
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Dispose( );
		}
		
		void AjustarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if( ajustarToolStripMenuItem.Checked )
			{
				ajustarToolStripMenuItem.Checked = false;
				
				pictureBox1.Dock = DockStyle.None;
				pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			}
			else
			{
				ajustarToolStripMenuItem.Checked = true;
				
				pictureBox1.Dock = DockStyle.Fill;
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}
		
		void VerListaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if( verListaToolStripMenuItem.Checked )
			{
				verListaToolStripMenuItem.Checked = false;
				splitContainer1.Panel1Collapsed = true;
			}
			else
			{
				verListaToolStripMenuItem.Checked = true;
				splitContainer1.Panel1Collapsed = false;
			}
		}
		
		void PresentacionToolStripMenuItemClick(object sender, EventArgs e)
		{
			Button cancelButton1 = new Button( );
			cancelButton1.Click += new System.EventHandler( this.cancelButton1Click );
			
			timer1.Enabled = true;
			timer1.Interval = (toolStripComboBox1.SelectedIndex + 1) * 1000;
			
			pictureBox2.Dock = DockStyle.Fill;
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.Image = Image.FromFile( (listBox1.SelectedItem as FileInfo).FullName ); 
			
			Form form2 = new Form( );
			
			form2.WindowState = FormWindowState.Maximized;
			form2.FormBorderStyle = FormBorderStyle.None;
			form2.CancelButton = cancelButton1;
			form2.Controls.Add( pictureBox2 );
			
			form2.ShowDialog( );
		}
		
		void VisualizaciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			presentacionToolStripMenuItem.Enabled = ( listBox1.Items.Count > 1 );
		}
		
		void cancelButton1Click(object sender, EventArgs e)
		{
			ActiveForm.Close( );
			timer1.Enabled = false;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if( listBox1.SelectedIndex < (listBox1.Items.Count - 1) )
				listBox1.SelectedItem = listBox1.Items[ listBox1.SelectedIndex+1 ];
			else
				listBox1.SelectedItem = listBox1.Items[ 0 ];
			
			pictureBox2.Image = Image.FromFile( (listBox1.SelectedItem as FileInfo).FullName ); 
		}
	}
}