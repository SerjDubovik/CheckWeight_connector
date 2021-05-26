/*
 * Пользователь: Дубовик
 * Дата: 17.01.2020
 * Время: 11:23
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Linq;
using Modbus.Device;    															        // for modbus master
using System.IO.Ports;  															        // for serial port
using System.Threading; 
using System.Text;

namespace CheckWeight_connector
{

	public partial class MainForm : Form
	{
		
		
		public List<string> existing_port_list	= new List<string>() {"Не использовать"};	// лист доступных в системе СОМ портов в данный момент
		
		public string	nomber_net_buf;														// номер устройства в сети
		public string	speed_net_buf;														// скорость передачи по выбранному каналу модбас
		public string	stop_bit_net_buf; 													// кол-во стоп бит
		public string	quantity_bit_buf; 													// кол-во бит в посылке
		public string	parity_net_buf; 													// выбранная проверка в посылке
		public string	post_buf; 															// СОМ порт для канала связи
		
		public bool 	autoconnect_buf;													// буль если тру, то прога самоподключается при старте
	
		public static ushort[] modbus_mass = new ushort[200];                             	// массив для взаимодействия с потоком обработки модбас
		
		public double const_volt = 118.0;
		public double const_volt_max = 1.0;
		
		public Property_Form property_Form;													// Объявляем класс с формой настроек				
		
		public Class_visu_prop_grid_modbus	visu_MyClass_modbus = new Class_visu_prop_grid_modbus(); // создаём экземпляр класса для отображения в сетке свойств настроек modbus
		
		Serializable_Class serializable_Class;
		
		SerialPort serialPort = new SerialPort(); 							        		// create a new SerialPort object with default settings.			
		
		public ModBus_var modBus_var = new ModBus_var();									// создаём экземпляр класса для передачи в поток
		Thread Thread_Modbus = new Thread(new ParameterizedThreadStart(Modbus_func));		// Вот так передаём в созданный поток класс

		public static ModbusSerialMaster master;

		
		public MainForm()
		{

			InitializeComponent();
			
						serializable_Class = new Serializable_Class(						// инициируем класс для работы с сериализером
			                                            nomber_net_buf,						// номер устройства в сети
														speed_net_buf,						// скорость передачи по выбранному каналу модбас
														stop_bit_net_buf, 					// кол-во стоп бит
														quantity_bit_buf, 					// кол-во бит в посылке
														parity_net_buf, 					// выбранная проверка в посылке
														post_buf, 	
														autoconnect_buf);
			                                            
			Deserialization("default.dat");													// десериализуем ранее сохранённые настройки
								
			
 		
									
		   	property_Form = new Property_Form(this);	
			property_Form.Tag = this;
												
			
			existing_port_list.AddRange( SerialPort.GetPortNames());						// узнаём какие порты активны сейчс и заносим их в лист			
		}
		
		void ToolStripMenuItem_exitClick(object sender, EventArgs e)
		{
			Serialization("default.dat");
			Thread_Modbus.Abort();                                                      	// заставляет прервать поток обработки модбас	
			Close();
		}
		
		void ToolStripMenuItem_transport_btnClick(object sender, EventArgs e)
		{
			property_Form.tabControl1.SelectTab(0);											// показываем окно с первой вкладки
			property_Form.Show();															// показываем окно	
		}
		
		void ToolStripMenuItem_aboutClick(object sender, EventArgs e)
		{
		        MessageBox.Show(
				" Программа реализует связь по протоколу Modbus \n" +
				" ////////с отладочной платой BluePill/////////\n"  +  
				" /////////////////////////////////////////////\n"  +
				" //////////////// Версия ПО 1.0 //////////////\n"  +										
	    		" ////////////// ООО Эрга. 2019 год. //////////\n");
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Serialization("default.dat");
			Thread_Modbus.Abort();                                                      	// заставляет прервать поток обработки модбас
		}
		
		
		void Timer_for_DisplTick(object sender, EventArgs e)
		{
			label1.Text = ( modBus_var.mb_mass[0]).ToString();
		}
		
		
	}	// скобка мейна
	
	
			public class ModBus_var
		{
			public byte adrr_dev_in;
			public ushort adrr_var_in;
			public ushort adrr_var_out;
			public ushort lenght_in;
			
			public ushort buton;
			
			public ushort flag_connect;
			public ushort flag_read_param;
			public ushort flag_write_param;
			
			public ushort[] mb_mass;

			
			public ModBus_var()
			{
				mb_mass = new ushort[200];

			}
			
		}
} // скобка неймспейса
