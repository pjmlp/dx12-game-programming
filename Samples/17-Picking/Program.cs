using System;

namespace DX12GameProgramming
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (var app = new PickingApp())
            {
                app.Initialize();
                app.Run();
            }
        }
    }
}
