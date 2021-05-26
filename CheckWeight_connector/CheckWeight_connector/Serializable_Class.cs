/*
 * Создано в SharpDevelop.
 * Пользователь: Дубовик
 * Дата: 08.02.2019
 * Время: 13:08
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace CheckWeight_connector
{
	[Serializable]
	public class Serializable_Class
	{
		public string 	Nomber_net;
		public string	Speed_net;														// скорость передачи по выбранному каналу модбас
		public string	Stop_bit_net; 													// кол-во стоп бит
		public string	Quantity_bit; 													// кол-во бит в посылке
		public string	Parity_net; 													// выбранная проверка в посылке
		public string	Post; 															// СОМ порт для канала связи
		public bool		Autoconnect;
		
		public Serializable_Class(
									 string nomber_net,
									 string	speed_net,									// скорость передачи по выбранному каналу модбас
									 string	stop_bit_net, 								// кол-во стоп бит
									 string	quantity_bit, 								// кол-во бит в посылке
									 string	parity_net, 								// выбранная проверка в посылке
									 string	post, 										// СОМ порт для канала связи
									 bool autoconnect
								  )
		{
			Nomber_net		= nomber_net;
			Speed_net		= speed_net;
			Stop_bit_net	= stop_bit_net;
			Quantity_bit	= quantity_bit;
			Parity_net		= parity_net;
			Post			= post;
			Autoconnect 	= autoconnect;
		}
	}	
}
