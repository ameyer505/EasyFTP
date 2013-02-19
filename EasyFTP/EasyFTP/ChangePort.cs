/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 2/19/2013
 * Time: 2:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyFTP
{
	/// <summary>
	/// Description of ChangePort.
	/// </summary>
	public partial class ChangePort : Form
	{
		int port = 0;
		MainForm mainform;
		
		public ChangePort(MainForm form)
		{
		mainform = form;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Cancel Button
		void Button2Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		//OK button
		void Button1Click(object sender, EventArgs e)
		{
			string stringPort = textBox1.Text;
			port = Int32.Parse(stringPort);
			if(port > 1024){
			mainform.setNewPort(port);
			this.Dispose();
			}
			else{
				MessageBox.Show("Please choose an unused port above 1024");
				textBox1.ResetText();
				textBox1.Focus();
			}
		}
		
		public int getPort(){
			return port;
		}
	}
}
