#! python3
import rhinoscriptsyntax as rs
import Grasshopper as gh

# Disable command line echo
rs.Command("NoEcho")

# Load Grasshopper with no Banner
# Banner: Disable, Window: Show
rs.Command("-Grasshopper B D W S _Enter", echo=False)

# Collapse GH Window to title bar
gh.Instances.DocumentEditor.CollapseForm()

# Window: Hide
rs.Command("-Grasshopper W H _Enter", echo=False)

# Add the RCP to the current GH/Rhino
gh.Instances.ShowRemotePanel()

# Launch the Grasshopper Script Headless with GH Player
rs.Command("Test_RCP ")