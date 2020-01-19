/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 04/12/2019
 * Time: 01:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlgoritmiaAct5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem crearAgenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem objetivoToolStripMenuItem;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button button3;
		
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
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.crearAgenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.objetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.button3 = new System.Windows.Forms.Button();
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(487, 497);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(505, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "Seleccionar Imagen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(586, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 34);
			this.button2.TabIndex = 2;
			this.button2.Text = "Analizar Imagen";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.crearAgenteToolStripMenuItem,
									this.objetivoToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(144, 48);
			// 
			// crearAgenteToolStripMenuItem
			// 
			this.crearAgenteToolStripMenuItem.Name = "crearAgenteToolStripMenuItem";
			this.crearAgenteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.crearAgenteToolStripMenuItem.Text = "Crear Agente";
			this.crearAgenteToolStripMenuItem.Click += new System.EventHandler(this.CrearAgenteToolStripMenuItemClick);
			// 
			// objetivoToolStripMenuItem
			// 
			this.objetivoToolStripMenuItem.Name = "objetivoToolStripMenuItem";
			this.objetivoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.objetivoToolStripMenuItem.Text = "Objetivo";
			this.objetivoToolStripMenuItem.Click += new System.EventHandler(this.ObjetivoToolStripMenuItemClick);
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(505, 265);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(121, 244);
			this.treeView1.TabIndex = 4;
			this.treeView1.Click += new System.EventHandler(this.TreeView1Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(505, 52);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 35);
			this.button3.TabIndex = 5;
			this.button3.Text = "Comenzar Animación";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// treeView2
			// 
			this.treeView2.Location = new System.Drawing.Point(505, 93);
			this.treeView2.Name = "treeView2";
			this.treeView2.Size = new System.Drawing.Size(246, 166);
			this.treeView2.TabIndex = 6;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(587, 53);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 34);
			this.button4.TabIndex = 7;
			this.button4.Text = "Reanudar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 521);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.treeView2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "AlgoritmiaAct5";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TreeView treeView2;
	}
}
