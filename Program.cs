

using ImGui_Base;

class Program
{
    public static void Main(string[] args)
    {
        Renderer renderer = new();
        Thread renderThread = new(() => renderer.Start().Wait())
        {
            IsBackground = true,
        };

        renderThread.Start();

        while (true)
        {
            Thread.Sleep(1);
        }
    }
}