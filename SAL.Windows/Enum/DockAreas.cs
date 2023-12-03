using System;

namespace SAL.Windows
{
	/// <summary>Regions where the plugin window can be installed</summary>
	[Serializable]
	[Flags]
	public enum DockAreas
	{
		/// <summary>Floating window (Not modal)</summary>
		Float = 1 << 0,
		/// <summary>Can be snapped to the left border</summary>
		DockLeft = 1 << 1,
		/// <summary>Can be snapped to the right border</summary>
		DockRight = 1 << 2,
		/// <summary>Can be snapped to the upper border</summary>
		DockTop = 1 << 3,
		/// <summary>Can be snapped to the lower border</summary>
		DockBottom = 1 << 4,
		/// <summary>It is possible to bind the window to the entire area of the document</summary>
		Document = 1 << 5,
	}
}