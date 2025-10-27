using System;

namespace SAL.Windows
{
	/// <summary>
	/// Represents a selectable option displayed on a <c>System.Windows.Forms.MenuStrip</c> or <c>System.Windows.Forms.ContextMenuStrip</c>.
	/// Although <c>System.Windows.Forms.ToolStripMenuItem</c>
	/// replaces and adds functionality to the <c>System.Windows.Forms.MenuItem</c> control of previous versions,
	/// <c>System.Windows.Forms.MenuItem</c> is retained for both backward compatibility and future use if you choose
	/// </summary>
	public interface IMenuItem : IMenu
	{
		/// <summary>Occurs when the <c>System.Windows.Forms.ToolStripItem</c> is clicked</summary>
		event EventHandler Click;

		/// <summary>Gets or sets the name of the item</summary>
		/// <returns>A string representing the name. The default value is null</returns>
		String Name { get; set; }
		
		/// <summary>Gets or sets the text that is to be displayed on the item</summary>
		/// <returns>A string representing the item's text. The default value is the empty string ("")</returns>
		String Text { get; set; }

		/// <summary>Gets the parent <c>System.Windows.Forms.ToolStripItem</c> of this <c>System.Windows.Forms.ToolStripItem</c></summary>
		/// <returns>The parent <c>System.Windows.Forms.ToolStripItem</c> of this <c>System.Windows.Forms.ToolStripItem</c></returns>
		IMenuItem ParentItem { get;}
		
		/// <summary>Gets or sets the owner of this item</summary>
		/// <returns>The <c>System.Windows.Forms.ToolStrip</c> that owns or is to own the <c>System.Windows.Forms.ToolStripItem</c></returns>
		IMenu Root { get; set; }
	}
}