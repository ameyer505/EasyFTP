/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 2/19/2013
 * Time: 10:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EasyFTP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Send Request button
		void Button1Click(object sender, EventArgs e)
		{
			GMailLogin gmail = new GMailLogin();
			gmail.Show();
		}
		
		//Import Setup button
		void Button2Click(object sender, EventArgs e)
		{
			
		}
		
		//Pick Custom Port Button
		void Button3Click(object sender, EventArgs e)
		{
			
		}
		
		//Google 2-Way Auth button
		void Button4Click(object sender, EventArgs e)
		{
			
		}
		
		//Upload User Button
		void Button5Click(object sender, EventArgs e)
		{
			
		}
		
		//Exit Button
		void Button6Click(object sender, EventArgs e)
		{
			
		}
	}
}
