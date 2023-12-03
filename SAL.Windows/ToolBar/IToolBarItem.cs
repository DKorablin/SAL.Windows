using System;
using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Toolbar item</summary>
	public interface IToolBarItem : IHostItem
	{
		/// <summary>Toolbar key</summary>
		String Name { get; set; }

		/// <summary>Toolbar name visible for user</summary>
		String Text { get; set; }

		/// <summary>Parent toolbar that hosts current toolbar</summary>
		IToolBar Owner { get; }

		/// <summary>Occurs when the System.Windows.Forms.ToolStripItem is clicked</summary>
		event EventHandler Click;
	}
}