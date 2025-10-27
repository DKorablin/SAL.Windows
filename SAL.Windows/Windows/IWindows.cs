using System;
using SAL.Flatbed;
using System.Collections.Generic;

namespace SAL.Windows
{
	/// <summary>Interface to work with host windows</summary>
	/// <remarks>If windowing is supported</remarks>
	public interface IWindows : IHostItem, IEnumerable<IWindow>
	{
		/// <summary>Get count of opened windows</summary>
		Int32 Count { get; }

		/// <summary>Get window by window index from collection</summary>
		/// <param name="index">Windows index from the list of opened windows</param>
		/// <returns>Window interface</returns>
		IWindow this[Int32 index] { get; }

		/// <summary>Create window in the current host</summary>
		/// <param name="pluginId">Plugin identifier that contains opening window control</param>
		/// <param name="formType">Form type from plugin to open</param>
		/// <param name="searchForOpened">Before opening new window search for already opened window with same type and arguments</param>
		/// <param name="args">Arguments passed to the plugin from the main application</param>
		/// <remarks>
		/// The passed key/value parameters must match the properties in <c>IPluginSettings</c>.
		/// If non-null parameters match, then the window is considered a duplicate (<c>searchForOpened</c>)
		/// </remarks>
		IWindow CreateWindow(String pluginId, String formType, Boolean searchForOpened, Object args);

		/// <summary>Create window in main window host</summary>
		/// <param name="plugin">Plugin where window type is located</param>
		/// <param name="formType">Window type to open</param>
		/// <param name="searchForOpened">Search for opened window of the same type and with same parameters</param>
		/// <param name="showHint">Where to bind form by default</param>
		/// <param name="args">
		/// Arguments to transfer to <c>formType</c> after creation.
		/// Transferred parameters must match properties from <c>IPluginSettings</c>.
		/// If not null values match, then window considered equals to opened (<c>searchForOpened</c>)
		/// </param>
		/// <remarks>
		/// This method is used inside host and plugins to open window using reflection
		/// </remarks>
		/// <returns>Object, if window opened successfully or null if window don't opened successfully</returns>
		IWindow CreateWindow(IPlugin plugin, String formType, Boolean searchForOpened, DockState showHint, Object args);
	}
}