using System;
using System.Collections;
using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Represents a collection of <c>System.Windows.Forms.ToolStripItem</c> objects</summary>
	public interface IMenuItemCollection : IHostItem,IEnumerable
	{
		/// <summary>Gets the elemnts count in the collection</summary>
		Int32 Count { get; }

		/// <summary>Gets the item at the specified index</summary>
		/// <param name="index">The zero-based index of the item to get</param>
		/// <returns>The <c>System.Windows.Forms.ToolStripItem</c> located at the specified position in the <c>System.Windows.Forms.ToolStripItemCollection</c></returns>
		IMenuItem this[Int32 index] { get; }

		/// <summary>Adds a System.Windows.Forms.ToolStripItem that displays the specified text to the collection</summary>
		/// <param name="text">The text to be displayed on the System.Windows.Forms.ToolStripItem</param>
		/// <returns>An System.Int32 representing the zero-based index of the new item in the collection</returns>
		Int32 Add(String text);

		/// <summary>Adds the specified item to the end of the collection</summary>
		/// <param name="item">The System.Windows.Forms.ToolStripItem to add to the end of the collection</param>
		/// <returns>An System.Int32 representing the zero-based index of the new item in the collection</returns>
		Int32 Add(IMenuItem item);

		/// <summary>Add renge of menu items to current collection</summary>
		/// <param name="items">Array of menu items to add to the collection</param>
		void AddRange(IMenuItem[] items);

		/// <summary>Inserts the specified item into the collection at the specified index</summary>
		/// <param name="index">The location in the System.Windows.Forms.ToolStripItemCollection at which to insert the System.Windows.Forms.ToolStripItem</param>
		/// <param name="item">The System.Windows.Forms.ToolStripItem to insert</param>
		void Insert(Int32 index, IMenuItem item);

		/// <summary>Removes the specified item from the collection</summary>
		/// <param name="item">The System.Windows.Forms.ToolStripItem to remove from the System.Windows.Forms.ToolStripItemCollection</param>
		void Remove(IMenuItem item);

		/// <summary>Removes an item from the specified index in the collection</summary>
		/// <param name="index">The index value of the System.Windows.Forms.ToolStripItem to remove</param>
		void RemoveAt(Int32 index);
	}
}