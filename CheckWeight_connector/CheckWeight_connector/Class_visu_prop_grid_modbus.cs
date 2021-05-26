/*
 * Создано в SharpDevelop.
 * Пользователь: Дубовик
 * Дата: 07.02.2019
 * Время: 18:47
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;
using System.Diagnostics;
using System.Collections.Specialized;

namespace CheckWeight_connector
{
	public class Class_visu_prop_grid_modbus
	{

		public Class_visu_prop_grid_modbus()									// конструктор класса.
		{
			speed_net_method 		= Enum_speed.ALT1;							// какой элемент будет по умолчанию в выпадающих списках
			stop_bit_net_method 	= Enum_stop_bit.ALT1;
			quantity_bit_net_method = Enum_quantity_bit.ALT1;
			parity_net_method 		= Enum_parity.ALT1;
			post 					= PostTypeConverter.my_list_[0];
		}
		

	    [Browsable(true)]								// Отображение свойства. Отображать (true) или не отображать (false) данное свойство в окне “PropertyGrid”.	    
	    [Description("Адрес устройства в сети")]			// Описание свойства. Будет отображено в нижней части окна PropertyGrid.
	    [Category("Настройка соединения")]				// Категория свойства. Позволяет логически группировать свойства.	    
	    [DisplayName("Адрес устройства")]						// Имя, которое одображается в левой части сетки (если не указывать, то возьмёт строку по названию метода)
	    public string nomber_net_method  {get; set;}

	    
	    
	    
	    
	    int speed_net;
	    string speed_net_buf;
	    [Browsable(true)]														// Отображение свойства. Отображать (true) или не отображать (false) данное свойство в окне “PropertyGrid”.
		[Description("Скорость передачи данных выбраной сети. Должна согласовыватся с включёнными в неё устройствами")]		// Описание свойства. Будет отображено в нижней части окна PropertyGrid.
		[Category("Настройка соединения")]										// Категория свойства. Позволяет логически группировать свойства.
    	[DisplayName("Скорость передачи")]										// Имя, которое одображается в левой части сетки (если не указывать, то возьмёт строку по названию метода)
		[TypeConverter(typeof(Enum_speed))]
		public string speed_net_method
    	{
			get {
					speed_net_buf = Convert.ToString(speed_net);
					return speed_net_buf;
				}
	    	set {
					speed_net = Convert.ToInt32(value);
	    		}
		}			
		
		class Enum_speed : TypeConverter
	    {
	        public const string ALT1 = "50";
	        public const string ALT2 = "75";
	        public const string ALT3 = "110";
	        public const string ALT4 = "150";
	        public const string ALT5 = "300";
	        public const string ALT6 = "600";
	        public const string ALT7 = "1200";
	        public const string ALT8 = "2400";
	        public const string ALT9 = "4800";
	        public const string ALT10 = "9600";
	        public const string ALT11 = "19200";
	        public const string ALT12 = "38400";
	        public const string ALT13 = "57600";
	        public const string ALT14 = "115200";

	
	        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)  {return true;  }	
	        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)   {return true;  }	
	        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	        {
	            return new StandardValuesCollection(new[] {ALT1, ALT2, ALT3, ALT4, ALT5, ALT6, ALT7, ALT8, ALT9, ALT10, ALT11, ALT12, ALT13, ALT14});
	        }
	    }	




	    [Browsable(true)]														// Отображение свойства. Отображать (true) или не отображать (false) данное свойство в окне “PropertyGrid”.
		[Description("Стоп биты, которые используются в выбраной сети")]		// Описание свойства. Будет отображено в нижней части окна PropertyGrid.
		[Category("Настройка соединения")]										// Категория свойства. Позволяет логически группировать свойства.
    	[DisplayName("Стоп биты")]										// Имя, которое одображается в левой части сетки (если не указывать, то возьмёт строку по названию метода)
		[TypeConverter(typeof(Enum_stop_bit))]
		public string stop_bit_net_method {get; set;}
			
		
		class Enum_stop_bit : TypeConverter
	    {
	        public const string ALT1 = "None";
	        public const string ALT2 = "One";
	        public const string ALT3 = "OnePointFive";
	        public const string ALT4 = "Two";
	
	        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)  {return true;  }	
	        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)   {return true;  }	
	        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	        {
	            return new StandardValuesCollection(new[] {ALT1, ALT2, ALT3, ALT4});
	        }
	    }			
		


	    [Browsable(true)]														// Отображение свойства. Отображать (true) или не отображать (false) данное свойство в окне “PropertyGrid”.
		[Description("Количество бит в покете выбраной сети")]		// Описание свойства. Будет отображено в нижней части окна PropertyGrid.
		[Category("Настройка соединения")]										// Категория свойства. Позволяет логически группировать свойства.
    	[DisplayName("Количество бит")]										// Имя, которое одображается в левой части сетки (если не указывать, то возьмёт строку по названию метода)
		[TypeConverter(typeof(Enum_quantity_bit))]
		public string quantity_bit_net_method {get; set;}
			
		
		class Enum_quantity_bit : TypeConverter
	    {
	        public const string ALT1 = "4";
	        public const string ALT2 = "5";
	        public const string ALT3 = "6";
	        public const string ALT4 = "7";
	        public const string ALT5 = "8";
	
	        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)  {return true;  }	
	        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)   {return true;  }	
	        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	        {
	            return new StandardValuesCollection(new[] {ALT1, ALT2, ALT3, ALT4, ALT5});
	        }
	    }		

		
		
		
		
	    [Browsable(true)]														// Отображение свойства. Отображать (true) или не отображать (false) данное свойство в окне “PropertyGrid”.
		[Description("Проверка пакета на чётность выбраной сети")]		// Описание свойства. Будет отображено в нижней части окна PropertyGrid.
		[Category("Настройка соединения")]										// Категория свойства. Позволяет логически группировать свойства.
    	[DisplayName("Чётность")]										// Имя, которое одображается в левой части сетки (если не указывать, то возьмёт строку по названию метода)
		[TypeConverter(typeof(Enum_parity))]
		public string parity_net_method {get; set;}
			
		
		class Enum_parity : TypeConverter
	    {
	        public const string ALT1 = "Even";
	        public const string ALT2 = "Mark";
	        public const string ALT3 = "None";
	        public const string ALT4 = "Odd";
	        public const string ALT5 = "Space";
	
	        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)  {return true;  }	
	        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)   {return true;  }	
	        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	        {
	            return new StandardValuesCollection(new[] {ALT1, ALT2, ALT3, ALT4, ALT5});
	        }
	    }
		
		
		string _post;
	    [Browsable(true)]														// Отображение свойства. Отображать (true) или не отображать (false) данное свойство в окне “PropertyGrid”.
		[Description("Доступные для подключения порты. Для отображения устройства должны быть подключены")]		// Описание свойства. Будет отображено в нижней части окна PropertyGrid.
		[Category("Настройка соединения")]										// Категория свойства. Позволяет логически группировать свойства.
    	[DisplayName("COM порт")]										// Имя, которое одображается в левой части сетки (если не указывать, то возьмёт строку по названию метода)
		[TypeConverter(typeof(PostTypeConverter))]
		public string post
		{
		  get { return _post; }
		  set { _post = value; }
		  
		}
		
		public void upDate(List<string> inStr)
		{
			PostTypeConverter.my_list_ = inStr;		
		}
		
			
		
		class PostTypeConverter : StringConverter				
		{
			
			public static List<string> my_list_ = new List<string>() {"Не использовать"};
			
			public override bool GetStandardValuesSupported(ITypeDescriptorContext context) // 	Возвращает значение, показывающее, поддерживает ли объект стандартный набор значений, которые можно выбрать из списка.
			{
			    return true;
			}
			
			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
	    		return true;
	  		}
			
			public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) // Возвращает коллекцию стандартных значений для типа данных, для которого предназначен этот преобразователь типов при предоставлении с контекстом формата.
			{
				return new TypeConverter.StandardValuesCollection(my_list_);			
			}
			
		}
	}
}
