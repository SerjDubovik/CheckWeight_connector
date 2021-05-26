/*
 * Создано в SharpDevelop.
 * Пользователь: Дубовик
 * Дата: 11.02.2019
 * Время: 10:55
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CheckWeight_connector
{

	public partial class MainForm
	{
		public void Deserialization (string path)											// функция для сериализации в выбраный файл
		{
				// десериализация из файла
			BinaryFormatter formatter = new BinaryFormatter();									// создаем объект BinaryFormatter           
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))		// десериализация из файла default.dat
            {
                serializable_Class = (Serializable_Class)formatter.Deserialize(fs);
            }
			
            nomber_net_buf			=	serializable_Class.Nomber_net;
            speed_net_buf 			= 	serializable_Class.Speed_net;
			stop_bit_net_buf 		= 	serializable_Class.Stop_bit_net;
			quantity_bit_buf 		= 	serializable_Class.Quantity_bit;
			parity_net_buf 			= 	serializable_Class.Parity_net;
			post_buf 				= 	serializable_Class.Post;
			autoconnect_buf			= 	serializable_Class.Autoconnect;
		}
		
	
		public void Serialization (string path)											// функция для сериализации в выбраный файл
		{
			serializable_Class.Nomber_net	= nomber_net_buf;
			serializable_Class.Speed_net	= speed_net_buf;
			serializable_Class.Stop_bit_net	= stop_bit_net_buf;
			serializable_Class.Quantity_bit	= quantity_bit_buf;
			serializable_Class.Parity_net	= parity_net_buf;
			serializable_Class.Post			= post_buf;
			serializable_Class.Autoconnect  = autoconnect_buf;
			
			BinaryFormatter formatter = new BinaryFormatter();						// создаем объект BinaryFormatter
	        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))		// получаем поток, куда будем записывать сериализованный объект
            {
                formatter.Serialize(fs, serializable_Class);
            }
		}
		
	}
}