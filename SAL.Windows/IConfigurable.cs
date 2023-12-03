using System;

namespace Interface.Windows
{
	public interface IConfigurable
	{
		/// <summary>Настройка осуществляется через пользовательский интерфейс или через диалоговое окно</summary>
		/// <remarks>
		/// При установке свойства в True, ожидается что свойство <see cref="T:MainInterface"/> отдаст <see cref="T:System.Windows.Forms.UserControl"/>,
		/// в противном случае в контекстном меню будет свойство,
		/// при нажатии на которое будет запрос у свойства диалогового окна
		/// </remarks>
		Boolean IsUserControl { get; }
		/// <summary>При запросе пользователя будет запрос на <see cref="T:System.Windows.Forms.UserControl"/> или на <see cref="T:System.Windows.Forms.Form"/>, в зависимости от свойства <see cref="T:IsUserControl"/></summary>
		Object MainInterface { get; }
	}
}
