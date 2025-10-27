using System;
using SAL.Flatbed;

namespace SAL.Windows
{
	/// <summary>Application description interface for SAL shell</summary>
	public interface IKernelInfo : IPluginKernel
	{
		/// <summary>Application name</summary>
		String ApplicationName { get; }

		/// <summary>Application icon</summary>
		Object ApplicationIcon { get; }

		/// <summary>Application logo</summary>
		Object ApplicationLogo { get; }
	}
}