using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio2
{
	public partial class MainForm : Form
	{
		public MainForm( )
		{
			InitializeComponent( );
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			numerosDigitales1.InitializePanels( );
			numerosDigitales2.InitializePanels( );
			numerosDigitales3.InitializePanels( );
		}
		
		void ButtonNumberClick(object sender, EventArgs e)
		{
			int num = Convert.ToInt32( (sender as Button).Text );
			
			if( num != numerosDigitales1.Number )
			{
				if( num == 10 )
					num = 0;
				
				numerosDigitales1.Number = num;
				numerosDigitales2.Number = num;
				numerosDigitales3.Number = num;
			}
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog( );
			
			if( cd.ShowDialog( ) == DialogResult.OK )
			{
				numerosDigitales1.BackColor = cd.Color;
				numerosDigitales2.BackColor = cd.Color;
				numerosDigitales3.BackColor = cd.Color;
			}
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog( );
			
			if( cd.ShowDialog( ) == DialogResult.OK )
			{
				numerosDigitales1.NumberColor = cd.Color;
				numerosDigitales2.NumberColor = cd.Color;
				numerosDigitales3.NumberColor = cd.Color;
			}
		}
	}
	
	public class NumerosDigitales : Panel
	{
		static bool[ , ] numberBools =
		{
			{ true, true, true, true, false, true, true, false, true, true, false, true, true, true, true },
			{ false, false, true, false, true, true, false, false, true, false, false, true, false, false, true },
			{ true, true, true, false, false, true, true, true, true, true, false, false, true, true, true },
			{ true, true, true, false, false, true, true, true, true, false, false, true, true, true, true },
			{ true, false, true, true, false, true, true, true, true, false, false, true, false, false, true },
			{ true, true, true, true, false, false, true, true, true, false, false, true, true, true, true },
			{ true, true, true, true, false, false, true, true, true, true, false, true, true, true, true },
			{ true, true, true, false, false, true, false, true, false, true, false, false, true, false, false },
			{ true, true, true, true, false, true, true, true, true, true, false, true, true, true, true },
			{ true, true, true, true, false, true, true, true, true, false, false, true, true, true, true }
		};
		
		private int number;
		private Color backColor;
		private Color numberColor;
		
		public void InitializePanels( )
		{
			Panel panelSmall;
			
			for( int i = 1; i <= 15; i++ )
			{
				panelSmall = new Panel( );
				
				panelSmall.Width = ( this.Width / 3 );
				panelSmall.Height = ( this.Height / 5 );
				
				panelSmall.Left = panelSmall.Width * ( ( i + 2 ) % 3 );
				panelSmall.Top = panelSmall.Height * ( ( i - 1 ) / 3 );
				
				this.Controls.Add( panelSmall );
			}
			
			this.number = 0;
			this.backColor = Color.Red;
			this.numberColor = Color.Blue;
			this.UpdatePanel( );
		}
		
		public int Number
		{
			get
			{
				return number;
			}
			set
			{
				number = value;
				this.UpdatePanel( );
			}
		}
		
		public Color NumberColor
		{
			get
			{
				return numberColor;
			}
			set
			{
				numberColor = value;
				this.UpdatePanel( );
			}
		}
		
		public override Color BackColor
		{
			get
			{
				return backColor;
			}
			set
			{
				backColor = value;
				this.UpdatePanel( );
			}
		}
		
		void UpdatePanel( )
		{
			for( int i = 0; i < 15; i++ )
			{
				if( numberBools[ number, i ] )
					(this.Controls[ i ] as Panel).BackColor = numberColor;
				else
					(this.Controls[ i ] as Panel).BackColor = backColor;
			}
		}
	}
}
