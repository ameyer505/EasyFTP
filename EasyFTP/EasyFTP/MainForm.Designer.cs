/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 2/19/2013
 * Time: 10:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 using System;
 using System.Net;
 using System.Net.Sockets;
 using System.Windows.Forms;
 
namespace EasyFTP
{
	partial class MainForm
	{
		string IPaddr = "";
		int port = 54321;
		
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 111);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(163, 69);
			this.button1.TabIndex = 0;
			this.button1.Text = "Send Request";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(185, 111);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(163, 69);
			this.button2.TabIndex = 1;
			this.button2.Text = "Import Setup";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 186);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(163, 69);
			this.button3.TabIndex = 2;
			this.button3.Text = "Pick Custom Port";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(185, 186);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(163, 69);
			this.button4.TabIndex = 3;
			this.button4.Text = "Google 2-Way Auth";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 261);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(163, 69);
			this.button5.TabIndex = 4;
			this.button5.Text = "Upload User";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(229, 307);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Created by r00tk1t";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(217, 287);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Powered by Google GMail";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Your IP Address is:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Current Port:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(119, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Text = getIP();
			this.textBox1.Size = new System.Drawing.Size(229, 20);
			this.textBox1.TabIndex = 10;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(119, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Text = getPort().ToString();
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(229, 20);
			this.textBox2.TabIndex = 11;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(360, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.importUserToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// importUserToolStripMenuItem
			// 
			this.importUserToolStripMenuItem.Name = "importUserToolStripMenuItem";
			this.importUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.importUserToolStripMenuItem.Text = "Change Port";
			this.importUserToolStripMenuItem.Click += new System.EventHandler(this.ImportUserToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(360, 337);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "MainForm";
			this.Text = "EasyFTP";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		
		//Get first IP in local Network, may not be public IP (may be NAT'd)
		public string getIP(){
			IPHostEntry host;
			string ip = "";
			host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress addr in host.AddressList){
				if(addr.AddressFamily == AddressFamily.InterNetwork){
					ip = addr.ToString();
					break;
					}
				}
			IPaddr = ip;
			return ip;
			}
		
		public int getPort(){
			return port;
		}
		
		//Change Port Menu Item
		void ImportUserToolStripMenuItemClick(object sender, EventArgs e)
		{
			ChangePort cp = new ChangePort(this);
			cp.Show();
			
		}
		
		//Exit Menu Item
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		//Set Port Number
		public void setNewPort(int i){
			port = i;
			textBox2.Text = port.ToString();
		}
	}
}
