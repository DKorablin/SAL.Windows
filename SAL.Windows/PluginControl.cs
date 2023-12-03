using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Interface.Windows
{
	/// <summary>Родительский класс окна плагина которое привязвается в основной интерфейс хоста</summary>
	private class PluginControl : UserControl
	{
		#region Properties
		/// <summary>Иконка отображаемая на форме</summary>
		public virtual Icon Icon { get { return null; } }
		/// <summary>Куда привязывать форму по умолчанию</summary>
		public virtual DockState ShowHint { get { return DockState.Document; } }
		/// <summary>Куда можно привязать форму по умолчанию</summary>
		public virtual DockAreas DockAreas { get { return DockAreas.Document; } }
		/// <summary>Массив аргументов передаваемых пользовательскому элементу управления</summary>
		public virtual String[] Args { get { return new String[] { }; } }
		#endregion Properties
		#region Methods
		/// <summary>Создание экземпляра элемента UI интерфейса плагина</summary>
		public PluginControl()
		{
		}
		/// <summary>Событие отображения окна плагина в первый раз</summary>
		/// <param name="e">Аргументы передаваемые с событием</param>
		public virtual void OnShown(EventArgs e)
		{
		}
		/// <summary>Событие закрытия окна плагина</summary>
		/// <param name="e">Аргументы передаваемые с событием</param>
		public virtual void OnClosed(EventArgs e)
		{
		}
		/// <summary>Событие запроса на закрытия окна плагина</summary>
		/// <param name="e">Аргументы передаваемые с событием</param>
		public virtual void OnClosing(CancelEventArgs e)
		{
		}
		#endregion Methods
	}
}