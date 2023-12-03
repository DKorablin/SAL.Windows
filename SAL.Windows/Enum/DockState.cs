using System;

namespace SAL.Windows
{
	/// <summary>Plugin window anchor status in interface</summary>
	public enum DockState
	{
		/// <summary>Unknown</summary>
		Unknown = 0,
		/// <summary>Can be binded to interface. (Not modal window)</summary>
		Float = 1,
		/// <summary>Anchor to the top edge of the window with the auto-hide feature</summary>
		DockTopAutoHide = 2,
		/// <summary>Anchor to the left edge of the window with the auto-hide feature</summary>
		DockLeftAutoHide = 3,
		/// <summary>Anchor to the bottom edge of the window with the auto-hide feature</summary>
		DockBottomAutoHide = 4,
		/// <summary>Anchor to the right edge of the window with the auto-hide feature</summary>
		DockRightAutoHide = 5,
		/// <summary>Open a window to the entire area of the document</summary>
		Document = 6,
		/// <summary>Snap to the top of the window</summary>
		DockTop = 7,
		/// <summary>Snap to the left of the window</summary>
		DockLeft = 8,
		/// <summary>Snap to the bottom of the window</summary>
		DockBottom = 9,
		/// <summary>Snap to the right of the window</summary>
		DockRight = 10,
		/// <summary>Plugin window not showing</summary>
		Hidden = 11,
	}
}