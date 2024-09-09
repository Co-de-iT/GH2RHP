// NOTE:
// - Reference to RhinoCommmon.dll is added by default
// - Use #r "nuget: <package name>, <package version>" to install and reference nuget packages.
//       e.g. #r "nuget: Rhino.Scripting, 0.7.0"
//       e.g. #r "nuget: RestSharp, 106.11.7"
// - Use #r "<assembly name>" to reference other assemblies
//       e.g. #r "System.Text.Json.dll"
//       e.g. #r "path/to/your/Library.dll"
//       e.g. #r "path/to/your/Plugin.gha"

#r "Grasshopper.dll"

using Rhino;
using Grasshopper;

// Load Grasshopper with no Banner
// Banner: Disable, Window: Show
RhinoApp.RunScript("-Grasshopper B D W S _Enter", false);

// Collapse GH Window to title bar
Grasshopper.Instances.DocumentEditor.CollapseForm();

// Window: Hide
RhinoApp.RunScript("-Grasshopper W H _Enter", false);

// Add the RCP to the current GH/Rhino
Grasshopper.Instances.ShowRemotePanel();

// Launch the Grasshopper Script Headless with GH Player
RhinoApp.RunScript("Test_RCP ", true);