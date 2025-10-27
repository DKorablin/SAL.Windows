using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Extended host interface to support working with windows</summary>
	public interface IHostWindows : IHost
	{
		/// <summary>Menu in current host</summary>
		IMenu MainMenu { get; }

		/// <summary>Toolbar container</summary>
		IToolBarContainer ToolBar { get; }

		/// <summary>Windows functions in the host</summary>
		IWindows Windows { get; }
	}
}