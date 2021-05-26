/*
 * Создано в SharpDevelop.
 * Пользователь: Дубовик
 * Дата: 11.02.2019
 * Время: 11:46
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */

using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Modbus.Device;


namespace CheckWeight_connector
{
	public partial class MainForm
	{		
		
		
		public void connect_modbus()
		{
			
			//F.visu_MyClass_modbus.nomber_net_method = F.nomber_net_buf;			// номер устройства для связи
			
					
			serialPort.PortName 	= post_buf;									// СОМ порт для каждого канала
			serialPort.BaudRate 	= Convert.ToInt32(speed_net_buf);			// скорость передачи по выбранному каналу модбас
			serialPort.DataBits 	= Convert.ToInt32(quantity_bit_buf);		// кол-во бит в посылке

			
			switch (parity_net_buf)												// проверка на чётность
			{
				case "Even": serialPort.Parity 		= 	Parity.Even;	break;
				case "Mark": serialPort.Parity 		= 	Parity.Mark;	break;
				case "None": serialPort.Parity 		= 	Parity.None;	break;
				case "Odd": serialPort.Parity 		= 	Parity.Odd;		break;
				case "Space": serialPort.Parity 	= 	Parity.Space;	break;			
			}
			
			
			
			switch (stop_bit_net_buf)											// кол-во стоп бит
			{
				case "None":  serialPort.StopBits				=	StopBits.None;	break;
				case "One":  serialPort.StopBits				=	StopBits.One;	break;
				case "OnePointFive":  serialPort.StopBits		=	StopBits.OnePointFive;	break;
				case "Two":  serialPort.StopBits				=	StopBits.Two;	break;								
										
			}

            try
            {
                serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.Retries = 0;       // don't have to do retries
                master.Transport.ReadTimeout = 50; // milliseconds

                toolStripStatusLabel2.Text = DateTime.Now.ToString() + " " + serialPort.PortName + " Открыт ";              // выводим сообщение в строку состояния
                
        

            }

            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                toolStripStatusLabel2.Text = DateTime.Now.ToString() + " " + serialPort.PortName + " Не удалось открыть ";  // выводим сообщение в строку состояния
            }


            try
            {
            	Thread_Modbus.Start(modBus_var);                                 // запуск процесса обработки ком порта
                toolStripStatusLabel4.Text = " Поток запущен ";                  // выводим сообщение в строку состояния

            }
            catch (Exception)
            {
                toolStripStatusLabel4.Text = " Поток не запущен ";               // выводим сообщение в строку состояния
            }
            
		}
		
		
		
		
		
		
		public static void Modbus_func(object obj)                                     // метод потока. для работы с ком портом
		{
			
			ModBus_var	modBus_var = (ModBus_var)obj;
			
			bool enable_loop = true;
						

			
            while (enable_loop)														// не забываем за бесконечный цикл в потоках =)
            {    

            	if(enable_loop == false)
            	{
            		break;
            	}
            	
    	        try
                {                    
    	        	ushort[] register;    	        	
    	        	
    	        	register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 0 , 2);			// тест
    	        	modBus_var.mb_mass[0] = register[0];
    	        	    	        		
					
    	        }
    	        	       	        	                
                catch { }
            	
            	
            	//Thread.Sleep(0);                                                 // откладываем выполнение процесса указанное кол-во мс       	
            }
			
        }
		
	}
	
}