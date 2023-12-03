using System;

namespace SAL.Windows
{
	/// <summary>Default messages that need to be resolved in plugin to fully interact with windows host</summary>
	public struct PluginMessage
	{
		/// <summary>Get the UI element from the plugin to embed it in the application shell</summary>
		/// <remarks>
		/// Method can take 1 or 2 parameters:
		/// formType (String) - Window type that need to be created in windows host (IWindows.CreateWindow(String, ...)
		/// args (KeyValuePair&lt;String,Object&gt;) - Arguments that need to be transferred to the opened form (When possible, passing arguments to the form)
		/// </remarks>
		public const String GetPluginControl = "GetPluginControl";

		/// <summary>Get the UI element that is embedded in the plugin's settings dialog</summary>
		public const String GetPluginOptionsControl = "GetPluginOptionsControl";
	}
}