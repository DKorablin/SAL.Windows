using System.Reflection;
using System.Runtime.InteropServices;

[assembly: Guid("c276bad5-c579-4bac-8205-28e2bfe0926e")]
[assembly: ComVisible(false)]
[assembly: System.CLSCompliant(true)]

#if NETSTANDARD || NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://dkorablin.ru/project/Default.aspx?File=76")]
#else
[assembly: AssemblyTitle("SAL.Windows")]
[assembly: AssemblyProduct("SAL Interface for Windows applications .NET4-")]
[assembly: AssemblyCompany("Danila Korablin")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2009-2024")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
//[assembly: AssemblyVersion("1.2.9.2")]
#endif