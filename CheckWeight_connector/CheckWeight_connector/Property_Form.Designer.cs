/*
 * Создано в SharpDevelop.
 * Пользователь: Дубовик
 * Дата: 07.02.2019
 * Время: 18:08
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace CheckWeight_connector
{
	partial class Property_Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage_Net;
		public System.Windows.Forms.PropertyGrid propertyGrid_Net;
		public System.Windows.Forms.TabPage tabPage_Visu;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.CheckBox checkBox_avtoconnect;
		private System.Windows.Forms.Button Connect;
		private System.Windows.Forms.Button Disconnect;
		
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage_Net = new System.Windows.Forms.TabPage();
			this.checkBox_avtoconnect = new System.Windows.Forms.CheckBox();
			this.Connect = new System.Windows.Forms.Button();
			this.Disconnect = new System.Windows.Forms.Button();
			this.propertyGrid_Net = new System.Windows.Forms.PropertyGrid();
			this.tabPage_Visu = new System.Windows.Forms.TabPage();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_OK = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage_Net.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage_Net);
			this.tabControl1.Controls.Add(this.tabPage_Visu);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(473, 453);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage_Net
			// 
			this.tabPage_Net.Controls.Add(this.checkBox_avtoconnect);
			this.tabPage_Net.Controls.Add(this.Connect);
			this.tabPage_Net.Controls.Add(this.Disconnect);
			this.tabPage_Net.Controls.Add(this.propertyGrid_Net);
			this.tabPage_Net.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Net.Name = "tabPage_Net";
			this.tabPage_Net.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Net.Size = new System.Drawing.Size(465, 427);
			this.tabPage_Net.TabIndex = 0;
			this.tabPage_Net.Text = "Связь";
			this.tabPage_Net.UseVisualStyleBackColor = true;
			// 
			// checkBox_avtoconnect
			// 
			this.checkBox_avtoconnect.Location = new System.Drawing.Point(44, 378);
			this.checkBox_avtoconnect.Name = "checkBox_avtoconnect";
			this.checkBox_avtoconnect.Size = new System.Drawing.Size(187, 24);
			this.checkBox_avtoconnect.TabIndex = 3;
			this.checkBox_avtoconnect.Text = "Подключать автоматически";
			this.checkBox_avtoconnect.UseVisualStyleBackColor = true;
			this.checkBox_avtoconnect.CheckedChanged += new System.EventHandler(this.CheckBox_avtoconnectCheckedChanged);
			// 
			// Connect
			// 
			this.Connect.Location = new System.Drawing.Point(358, 378);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(98, 25);
			this.Connect.TabIndex = 2;
			this.Connect.Text = "Подключить";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.ConnectClick);
			// 
			// Disconnect
			// 
			this.Disconnect.Location = new System.Drawing.Point(237, 378);
			this.Disconnect.Name = "Disconnect";
			this.Disconnect.Size = new System.Drawing.Size(98, 25);
			this.Disconnect.TabIndex = 1;
			this.Disconnect.Text = "Отключить";
			this.Disconnect.UseVisualStyleBackColor = true;
			// 
			// propertyGrid_Net
			// 
			this.propertyGrid_Net.Location = new System.Drawing.Point(6, 6);
			this.propertyGrid_Net.Name = "propertyGrid_Net";
			this.propertyGrid_Net.Size = new System.Drawing.Size(456, 338);
			this.propertyGrid_Net.TabIndex = 0;
			this.propertyGrid_Net.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid_NetPropertyValueChanged);
			// 
			// tabPage_Visu
			// 
			this.tabPage_Visu.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Visu.Name = "tabPage_Visu";
			this.tabPage_Visu.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Visu.Size = new System.Drawing.Size(465, 427);
			this.tabPage_Visu.TabIndex = 1;
			this.tabPage_Visu.Text = "Отображение";
			this.tabPage_Visu.UseVisualStyleBackColor = true;
			// 
			// button_cancel
			// 
			this.button_cancel.Location = new System.Drawing.Point(362, 479);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(98, 25);
			this.button_cancel.TabIndex = 4;
			this.button_cancel.Text = "Отмена";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.Button_cancelClick);
			// 
			// button_OK
			// 
			this.button_OK.Location = new System.Drawing.Point(241, 479);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(98, 25);
			this.button_OK.TabIndex = 3;
			this.button_OK.Text = "Ок";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.Button_OKClick);
			// 
			// Property_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 516);
			this.ControlBox = false;
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Property_Form";
			this.Text = "Настройки";
			this.tabControl1.ResumeLayout(false);
			this.tabPage_Net.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
