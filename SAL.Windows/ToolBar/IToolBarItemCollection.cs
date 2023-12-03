using System;
using System.Collections;
using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Array of elements on the toolbar</summary>
	public interface IToolBarItemCollection : IHostItem, IEnumerable
	{
		/// <summary>Number of elements on the toolbar</summary>
		Int32 Count { get; }

		/// <summary>Get toolbar element by index</summary>
		/// <param name="index">Toolbar item index</param>
		/// <returns>Toolbar item at a specific index</returns>
		IToolBarItem this[Int32 index] { get; }

		/// <summary>Add toolbar element in specific index</summary>
		/// <param name="index">Position where to add an element on the toolbar</param>
		/// <param name="item">Toolbar item to add</param>
		void Insert(Int32 index, IToolBarItem item);

		/// <summary>Add toolbar element at the end of collection</summary>
		/// <param name="item">Toolbar item to add</param>
		/// <returns>Index where toolbar item was added</returns>
		Int32 Add(IToolBarItem item);

		/// <summary>Remove toolbar by toolbar item</summary>
		/// <param name="item">Toolbar item to remove</param>
		void Remove(IToolBarItem item);

		/// <summary>Remove toolbar item from specific index</summary>
		/// <param name="index">The position of the toolbar element to remove</param>
		void RemoveAt(Int32 index);
	}
}