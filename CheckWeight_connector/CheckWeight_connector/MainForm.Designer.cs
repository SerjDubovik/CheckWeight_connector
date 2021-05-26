/*
 * Пользователь: Дубовик
 * Дата: 17.01.2020
 * Время: 11:23
 */
namespace CheckWeight_connector
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.Timer timer_for_Displ;
		private System.Windows.Forms.MenuStrip Main_menu;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Property;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_transport_btn;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_help_btn;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_about;
		private System.Windows.Forms.Label label1;
		
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer_for_Displ = new System.Windows.Forms.Timer(this.components);
			this.Main_menu = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Property = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_transport_btn = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_help_btn = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.Main_menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.toolStripStatusLabel2,
			this.toolStripStatusLabel3,
			this.toolStripStatusLabel4,
			this.toolStripStatusLabel5});
			this.statusStrip1.Location = new System.Drawing.Point(0, 516);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(986, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
			this.toolStripStatusLabel1.Text = "    ";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(19, 17);
			this.toolStripStatusLabel2.Text = "    ";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(19, 17);
			this.toolStripStatusLabel3.Text = "    ";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(19, 17);
			this.toolStripStatusLabel4.Text = "    ";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(19, 17);
			this.toolStripStatusLabel5.Text = "    ";
			// 
			// timer_for_Displ
			// 
			this.timer_for_Displ.Enabled = true;
			this.timer_for_Displ.Interval = 300;
			this.timer_for_Displ.Tick += new System.EventHandler(this.Timer_for_DisplTick);
			// 
			// Main_menu
			// 
			this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ToolStripMenuItem_File,
			this.ToolStripMenuItem_Property,
			this.ToolStripMenuItem_Help});
			this.Main_menu.Location = new System.Drawing.Point(0, 0);
			this.Main_menu.Name = "Main_menu";
			this.Main_menu.Size = new System.Drawing.Size(986, 24);
			this.Main_menu.TabIndex = 5;
			this.Main_menu.Text = "menuStrip1";
			// 
			// ToolStripMenuItem_File
			// 
			this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ToolStripMenuItem_exit});
			this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
			this.ToolStripMenuItem_File.Size = new System.Drawing.Size(48, 20);
			this.ToolStripMenuItem_File.Text = "Файл";
			// 
			// ToolStripMenuItem_exit
			// 
			this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
			this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(108, 22);
			this.ToolStripMenuItem_exit.Text = "Выход";
			this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exitClick);
			// 
			// ToolStripMenuItem_Property
			// 
			this.ToolStripMenuItem_Property.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ToolStripMenuItem_transport_btn});
			this.ToolStripMenuItem_Property.Name = "ToolStripMenuItem_Property";
			this.ToolStripMenuItem_Property.Size = new System.Drawing.Size(79, 20);
			this.ToolStripMenuItem_Property.Text = "Настройки";
			// 
			// ToolStripMenuItem_transport_btn
			// 
			this.ToolStripMenuItem_transport_btn.Name = "ToolStripMenuItem_transport_btn";
			this.ToolStripMenuItem_transport_btn.Size = new System.Drawing.Size(170, 22);
			this.ToolStripMenuItem_transport_btn.Text = "Передача данных";
			this.ToolStripMenuItem_transport_btn.Click += new System.EventHandler(this.ToolStripMenuItem_transport_btnClick);
			// 
			// ToolStripMenuItem_Help
			// 
			this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ToolStripMenuItem_help_btn,
			this.ToolStripMenuItem_about});
			this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
			this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(68, 20);
			this.ToolStripMenuItem_Help.Text = "Помощь";
			// 
			// ToolStripMenuItem_help_btn
			// 
			this.ToolStripMenuItem_help_btn.Name = "ToolStripMenuItem_help_btn";
			this.ToolStripMenuItem_help_btn.Size = new System.Drawing.Size(149, 22);
			this.ToolStripMenuItem_help_btn.Text = "Справка";
			// 
			// ToolStripMenuItem_about
			// 
			this.ToolStripMenuItem_about.Name = "ToolStripMenuItem_about";
			this.ToolStripMenuItem_about.Size = new System.Drawing.Size(149, 22);
			this.ToolStripMenuItem_about.Text = "О программе";
			this.ToolStripMenuItem_about.Click += new System.EventHandler(this.ToolStripMenuItem_aboutClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(986, 538);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Main_menu);
			this.Controls.Add(this.statusStrip1);
			this.Name = "MainForm";
			this.Text = "CheckWeight_connector";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.Main_menu.ResumeLayout(false);
			this.Main_menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
