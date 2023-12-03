using System;
using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Toolbar interface</summary>
	public interface IToolBar : IHostItem
	{
		/// <summary>Toolbar name</summary>
		String Name { get; set; }

		/// <summary>Text describing the toolbar</summary>
		String Text { get; set; }

		/// <summary>Get an array of controls on the toolbar</summary>
		IToolBarItemCollection Items { get; }

		/// <summary>Create toolbar element</summary>
		/// <param name="text">Text to set on the created element</param>
		/// <returns>Created element interface</returns>
		IToolBarItem Create(String text);

		/// <summary>Create element on toolbar panel</summary>
		/// <param name="text">Text wich is set on created toolbar element</param>
		/// <param name="image">Image System.Drawing.Image set on created element (if supported)</param>
		/// <returns>Interface of created element</returns>
		IToolBarItem Create(String text, Object image);

		/// <summary>Create element on toolbar panel</summary>
		/// <param name="text">Text wich is set on created toolbar element</param>
		/// <param name="image">Image System.Drawing.Image that will be set on created element (if supported)</param>
		/// <param name="onClick">Event that will be invoked on element click</param>
		/// <returns>Interface of created element</returns>
		IToolBarItem Create(String text, Object image, EventHandler onClick);

		/// <summary>Search for element on toolbar by name</summary>
		/// <param name="text">The name of the element to be searchd on the toolbar</param>
		/// <returns>Found item or null of nothing found</returns>
		IToolBarItem FindToolBarItem(String text);
	}
}