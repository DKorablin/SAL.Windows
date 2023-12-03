using System;
using System.Collections;
using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Toolbar items collection</summary>
	public interface IToolBarCollection : IHostItem, IEnumerable
	{
		/// <summary>Count of items in current toolbars collection</summary>
		Int32 Count { get; }

		/// <summary>Get toolbar item by index</summary>
		/// <param name="index">Index in the collection</param>
		/// <returns>Found toolbar item by index</returns>
		IToolBar this[Int32 index] { get; }

		/// <summary>Get toolbar item by key</summary>
		/// <param name="name">Key name identifying toolbar item that need to be found</param>
		/// <returns>Found toolbar item by key</returns>
		IToolBar this[String name] { get; }

		/// <summary>Add toolbar item to collection</summary>
		/// <param name="item">Toolbar item to add to the collection</param>
		void Add(IToolBar item);

		/// <summary>Remove toolbar item from collection</summary>
		/// <param name="item">Toolbar interface item to remove</param>
		void Remove(IToolBar item);

		/// <summary>Remove toolbar item from collection by index</summary>
		/// <param name="index">Toolbar index to remove</param>
		void RemoveAt(Int32 index);

		/// <summary>Remove toolbar item by key</summary>
		/// <param name="name">The key of the toolbar to remove</param>
		void RemoveByName(String name);
	}
}