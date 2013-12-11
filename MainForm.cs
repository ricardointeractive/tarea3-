/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 10/12/2013
 * Time: 10:54 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tarea3_usuario
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
		
		void Button1Click(object sender, EventArgs e)
		{
         if(textBox1.Text =="ricardo" && textBox2.Text =="1234")
                        {
                                MessageBox. Show("bienvenido al sistema");
                                
                        }
                        else 
                        
                                MessageBox.Show("Acceso Denegado!!!");			
		}
	}
}
