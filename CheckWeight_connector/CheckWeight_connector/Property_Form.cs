/*
 * Создано в SharpDevelop.
 * Пользователь: Дубовик
 * Дата: 07.02.2019
 * Время: 18:08
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace CheckWeight_connector
{

	public partial class Property_Form : Form
	{
		public MainForm F;			// чтобы можно было обратится к форме в любом месте пространства
		
		
		public Property_Form()
		{	
			InitializeComponent();						
		}
		
		
		public Property_Form(MainForm f)
		{
			F = f;
			
			InitializeComponent();			

			F.visu_MyClass_modbus.nomber_net_method = F.nomber_net_buf;			// номер устройства для связи
			F.visu_MyClass_modbus.speed_net_method = F.speed_net_buf;			// скорость передачи по выбранному каналу модбас
			F.visu_MyClass_modbus.stop_bit_net_method = F.stop_bit_net_buf; 	// кол-во стоп бит
			F.visu_MyClass_modbus.quantity_bit_net_method = F.quantity_bit_buf; // кол-во бит в посылке
			F.visu_MyClass_modbus.parity_net_method = F.parity_net_buf; 		// выбранная проверка в посылке
			F.visu_MyClass_modbus.post = F.post_buf; 							// СОМ порт для каждого канала
			
			F.modBus_var.adrr_dev_in = Convert.ToByte(F.nomber_net_buf);						// в поток обработки модбаса закидываем адрес устройства
					
			F.visu_MyClass_modbus.upDate(F.existing_port_list);	
			propertyGrid_Net.SelectedObject = F.visu_MyClass_modbus;
			
			checkBox_avtoconnect.Checked = F.autoconnect_buf;
			
			

			if(checkBox_avtoconnect.Checked)									// если галка автоконнекта установлена, то автоконектимся)))
			{
				try
				{
					F.connect_modbus();
				}
				catch
				{
					checkBox_avtoconnect.Checked = false;						// если автоконнект не удался, сбрасываем галку автовключения
					
				MessageBox.Show(
				" Произошёл сбой автоподключения к устройству. \n" +				   
				" Проверьте подключение и перезапустите приложение\n"  +
				" \n"  +										
	    		" \n");
				}
			}
			
			
		}
		
		
		
		
		void Button_OKClick(object sender, EventArgs e)							// закрывает окно с подтверждением изменёных параметров
		{
			Hide();																// скрывает окно настроек	
		}
		
		
		void Button_cancelClick(object sender, EventArgs e)						// закрывает окно без подтверждения изменёных параметров
		{
			Hide();																// скрывает окно настроек без подтверждения изменений	
		}
		
		
		void PropertyGrid_NetPropertyValueChanged(object s, PropertyValueChangedEventArgs e) 	// случается при завершении редактировании элементов сетки параметров
		{
			F.nomber_net_buf = F.visu_MyClass_modbus.nomber_net_method;
			F.speed_net_buf = F.visu_MyClass_modbus.speed_net_method;											
			F.stop_bit_net_buf = F.visu_MyClass_modbus.stop_bit_net_method;										
			F.quantity_bit_buf = F.visu_MyClass_modbus.quantity_bit_net_method;									
			F.parity_net_buf = F.visu_MyClass_modbus.parity_net_method;	
			F.post_buf	= F.visu_MyClass_modbus.post;			
			
			F.modBus_var.adrr_dev_in = Convert.ToByte(F.nomber_net_buf);						// в поток обработки модбаса закидываем адрес устройства
			
			F.existing_port_list.Clear();
			F.existing_port_list.Add("Не использовать");										// создадим лист для отображения в сетке свойств										
			F.existing_port_list.AddRange(SerialPort.GetPortNames());
			
			propertyGrid_Net.Refresh();															// обновляет всю сетку при изменении одного параметра
		}
		
		
		void ConnectClick(object sender, EventArgs e)											// кнопка подключить из формы настроек. создаёт соединение
		{
			F.connect_modbus();
		}
		
		
		void CheckBox_avtoconnectCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_avtoconnect.Checked)
			{
				F.autoconnect_buf  = true;
			}
			else
			{
				F.autoconnect_buf  = false;
			}
		}
		
		
	}
}
