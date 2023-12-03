using System;
using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Base menu interface</summary>
	public interface IMenu : IHostItem
	{
		/// <summary>Menu items collection</summary>
		IMenuItemCollection Items { get; }

		/// <summary>Draw menu as drop down menu</summary>
		Boolean IsDropDown { get; }

		/// <summary>Find menu item by text</summary>
		/// <param name="text">Menu item text</param>
		/// <returns>Founded menu item</returns>
		IMenuItem FindMenuItem(String text);

		/// <summary>Initializes a new instance of the System.Windows.Forms.ToolStripMenuItem class that displays the specified text</summary>
		/// <param name="text">The text to display on the menu item.</param>
		IMenuItem Create(String text);

		/// <summary>Initializes a new instance of the System.Windows.Forms.ToolStripMenuItem class that displays the specified text and image</summary>
		/// <param name="text">The text to display on the menu item</param>
		/// <param name="image">The System.Drawing.Image to display on the control</param>
		IMenuItem Create(String text, Object image);

		/// <summary>Initializes a new instance of the System.Windows.Forms.ToolStripMenuItem class that displays the specified text and image and that does the specified action when the System.Windows.Forms.ToolStripMenuItem is clicked</summary>
		/// <param name="text">The text to display on the menu item</param>
		/// <param name="image">The System.Drawing.Image to display on the control</param>
		/// <param name="onClick">An event handler that raises the System.Windows.Forms.Control.Click event when the control is clicked</param>
		IMenuItem Create(String text, Object image, EventHandler onClick);
	}
}