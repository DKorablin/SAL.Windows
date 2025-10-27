# SAL.Windows

SAL.Windows is a .NET library that provides a plugin-based architecture for developing extensible Windows Forms applications.
It's part of the SAL (Software Abstraction Layer) framework that enables modular and flexible application development.

## Features

- **Plugin-based Architecture**: Build applications using modular, reusable plugins
- **Multiple UI Support**: Works with various interface types (MDI/SDI/Dialog/VS IDE integration)
- **Centralized Settings Management**: Flexible storage of user settings and configurations
- **Dynamic Module Loading**: Load required modules based on user roles or server requirements
- **Interface Abstraction**: Common interfaces for Windows Forms controls and menus
- **Cross-platform Compatibility**: Supports .NET Framework 3.5 and .NET Standard 2.0

## Architecture Overview

The SAL architecture consists of three main components:

1. **Application Host**: The main application that implements one of the supported interfaces
2. **SAL Host**: Core component managing plugin communication and loading
3. **Plugins**: Modular components that provide specific functionality

### Plugin System

The architecture is built around the `IPlugin` interface, allowing plugins to:

- Extend or use other modules
- Access code from other plugins without recompilation
- Save and restore control states between sessions
- Integrate easily with existing applications
- Use standard WinForms UserControl or WPF components

### Host Types

SAL supports multiple host types:
- MDI Applications
  1. [Flatbed.MDI](https://dkorablin.github.io/Flatbed-MDI/)
  2. [Flatbed.MDI (Avalon)](https://dkorablin.github.io/Flatbed-MDI-Avalon/)
- Dialog-based Applications
  1. [Flatbed.Dialog](https://dkorablin.github.io/Flatbed-Dialog/)
  2. [Flatbed.Dialog (Lite)](https://dkorablin.github.io/Flatbed-Dialog-Lite/)
- Visual Studio Integration (EnvDTE)
- Windows Services
  1. [Flatbed.Service](https://dkorablin.github.io/Flatbed-WorkerService/)
- ASP.NET Applications

## Getting Started

### Basic Plugin Implementation

```csharp
public class Plugin : IPlugin, IPluginSettings<PluginSettings>
{
    private readonly IHost _host;
    private PluginSettings _settings;

    public Plugin(IHost host)
    {
        _host = host;
    }

    public PluginSettings Settings
    {
        get
        {
            if(_settings == null)
            {
                _settings = new PluginSettings(this);
                _host.Plugins.Settings(this).LoadAssemblyParameters(_settings);
            }
            return _settings;
        }
    }
}
```

### Adding UI Elements

```csharp
IHostWindows host = this.Host as IHostWindows;
if(host != null)
{
    IMenuItem menuTools = host.MainMenu.FindMenuItem("Tools");
    if(menuTools != null)
    {
        var newMenuItem = menuTools.Create("New Feature");
        newMenuItem.Name = "tsmiToolsNewFeature";
        newMenuItem.Click += OnNewFeatureClick;
        menuTools.Items.Insert(0, newMenuItem);
    }
}
```

### Creating Windows

```csharp
IWindow window = hostWindows.Windows.CreateWindow(
    plugin: this,
    formType: typeof(MyUserControl).ToString(),
    searchForOpened: false,
    showHint: DockState.DockLeft
);
```
### Adding menus and toolbars
```csharp
internal IHost Host { get; private set; }//It's allowed to launch the plugin with any host, and at startup - the plugin decides how to start

public Plugin(IHost host){
    this.Host = host;
}

Boolean IPlugin.OnConnection(ConnectMode mode)
{
    IHostWindows host = this.Host as IHostWindows;
    if(host != null)
    {
        IMenuItem menuTools = host.MainMenu.FindMenuItem("Tools");
        if(menuTools != null)
        {
            _pluginMenuItem = menuTools.Create("Menu Item Name");
            _pluginMenuItem.Name = "tsmiToolsPluginMenuItem";
            _pluginMenuItem.Click += new EventHandler(_pluginMenuItem_Click);
            menuTools.Items.Insert(0, _pluginMenuItem);
            return true;
        }
    }
    return false;
}
```

### Opening window (UI should be inherited from UserControl class)
```csharp
internal IHostWindows HostWindows { get; private set; }

public Plugin(IHostWindows host) {
    this.HostWindows = host;
}//Creating an instance of a plugin is only possible in a host that implements the IHostWindows interface

internal IWindow CreateWindow(String typeName, Boolean searchForOpened, Object args = null)
{
   return this.HostWindows.Windows.CreateWindow(this, typeof(PanelRdpClient).ToString(), false, DockState.DockLeft);
}
```

### Receiving objects IWindow and IPlugin in the opened window.
```csharp
public partial class PanelRdpClient : UserControl
{
    private IWindow Window { get { return (IWindow)base.Parent; } }
    private PluginRdp Plugin { get { return (PluginWindows)this.Window.Plugin; } }
    ...
    protected override void OnCreateControl()
    {
        this.Window.Caption = "I want cookie";

        base.OnCreateControl();
    }
    ...
}
```

## Core Components

### SAL.Flatbed
- Base assembly containing core interfaces
- Minimal set of abstractions for plugins and hosts
- Platform-independent functionality

### SAL.Windows
- Windows Forms and WPF specific implementation
- UI component interfaces
- Menu and toolbar abstractions
- Window management

## Plugin Architecture

### Plugin Lifecycle

1. **Loading**: Plugins are discovered and loaded from configured locations
2. **Provider Resolution**: Settings and plugin providers are initialized
3. **Kernel Plugin Detection**: System identifies and initializes kernel plugins
4. **Plugin Initialization**: Remaining plugins are initialized with dependencies

### Plugin Communication

- Inter-plugin communication through public methods, properties, and events
- Host communication via `IHost` interface and its extensions
- Settings management through `IPluginSettings` interface

## Configuration

### Settings Management

```csharp
// Loading data
using(Stream stream = plugin.Host.Plugins.Settings(plugin).LoadAssemblyBlob("config.xml"))
{
    if(stream != null)
        // Process configuration
}

// Saving data
using(MemoryStream stream = new MemoryStream())
{
    // Write configuration
    plugin.Host.Plugins.Settings(plugin).SaveAssemblyBlob("config.xml", stream);
}
```

## Compatibility

- .NET Framework 3.5
- .NET Standard 2.0

## Contributing

Contributions are welcome. Please ensure your changes maintain compatibility with the supported .NET versions.