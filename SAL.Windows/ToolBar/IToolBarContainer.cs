using System;
using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Container for toolbars</summary>
	public interface IToolBarContainer : IHostItem
	{
		/// <summary>Get toolbar collection</summary>
		IToolBarCollection Items { get; }

		/// <summary>Create new toolbar</summary>
		/// <param name="text">Text for new toolbar</param>
		/// <returns>New toolbar instance</returns>
		IToolBar Create(String text);
	}
}