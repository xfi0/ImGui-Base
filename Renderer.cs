using ClickableTransparentOverlay;
using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ImGui_Base
{
    internal class Renderer : Overlay
    {
        private static Vector2 windowSize = new(800, 400);

        protected override void Render()
        {
            var screenSize = ImGui.GetIO().DisplaySize;

            ImGui.SetNextWindowSize(windowSize, ImGuiCond.FirstUseEver);
            ImGui.SetNextWindowPos(new Vector2((screenSize.X / 2) - windowSize.X, (screenSize.Y / 2) - windowSize.Y), ImGuiCond.FirstUseEver);
            ImGui.Begin("Base");
            ImGui.Text("Please star this if you used this base!");
            ImGui.Text("Put all widgets in between begin and end.");
            ImGui.End();
        }
    }
}
