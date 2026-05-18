# ImGui-Base

A simple ImGui base with the window already configured and ready to use.

## Overview

ImGui-Base provides a minimal boilerplate setup for getting an ImGui window up and running quickly. The window comes pre-configured with a default size of 800x400, which can be easily adjusted to fit your needs.

## Getting Started

Clone the repository and open the project in your preferred IDE. No additional dependencies are required beyond ImGui itself.

## Configuration

The default window size is set to 800x400. To change it, locate the size definition and update the values:

```csharp
public static Vector2 windowSize = new Vector2(800, 400); // change these values
```
If you want the window to be frozen change this:
```csharp
ImGui.SetNextWindowSize(windowSize, ImGuiCond.Once);
ImGui.SetNextWindowPos(new Vector2((screenSize.X / 2) - windowSize.X, (screenSize.Y / 2) - windowSize.Y), ImGuiCond.FirstUseEver);
```
To this:
```csharp
ImGui.SetNextWindowSize(windowSize);
ImGui.SetNextWindowPos(new Vector2((screenSize.X / 2) - windowSize.X, (screenSize.Y / 2) - windowSize.Y), ImGuiCond.FirstUseEver);
```

## Notes

- The window is moveable and resizeable by default
- All core ImGui rendering logic is already handled in the base.
