using SAL.Flatbed;
using System;
using System.ComponentModel;

namespace SAL.Windows
{
	/// <summary>Open window interface</summary>
	public interface IWindow : IHostItem
	{
		/// <summary>The plugin that created the element</summary>
		IPlugin Plugin { get; }

		/// <summary>Control that hosted in current window</summary>
		/// <remarks>
		/// For WinForms - <c>System.Windows.Forms.UserControl</c>
		/// For WPF - <c>System.Windows.Controls.UserControl</c>
		/// </remarks>
		Object Control { get; }

		/// <summary>Window caption</summary>
		String Caption { get; set; }

		/// <summary>Show or hide window</summary>
		Boolean Visible { get; set; }

		/// <summary>The windows is first shown</summary>
		event EventHandler Shown;

		/// <summary>The window is starting closing</summary>
		event EventHandler<CancelEventArgs> Closing;

		/// <summary>Window is closed</summary>
		event EventHandler Closed;

		/*/// <summary>The array of settings passed to the window has changed</summary>
		event EventHandler SettingsChanged;*/

		/// <summary>Set window tab picture</summary>
		/// <param name="icon">Icon that will be installed in the window. System.Drawing.Image</param>
		void SetTabPicture(Object icon);

		/// <summary>Set the dock areas where the window can be installed</summary>
		/// <param name="dockAreas">Dock areas where window can be shown</param>
		void SetDockAreas(DockAreas dockAreas);

		/// <summary>Close window</summary>
		void Close();

		/// <summary>Add event to the window public event</summary>
		/// <param name="eventName">Event name</param>
		/// <param name="handler">Callback method that will receive eent from window</param>
		void AddEventHandler(String eventName, EventHandler<DataEventArgs> handler);

		/// <summary>Remove previously attached event from window</summary>
		/// <param name="eventName">Event name</param>
		/// <param name="handler">Callback method that need to be removed from window</param>
		void RemoveEventHandler(String eventName, EventHandler<DataEventArgs> handler);
	}
}