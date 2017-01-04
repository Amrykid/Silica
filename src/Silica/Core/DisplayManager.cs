using Silica.Core.Graphics;
using System;
using Windows.UI.Xaml;

namespace Silica.Core
{
    public class DisplayManager
    {
        private GameCanvas gameCanvas;

        public static DisplayManager Instance { get; private set; }
        internal static void CreateInstance(Window current)
        {
            Instance = new DisplayManager(current);
        }

        private DisplayManager(Window window)
        {
            gameCanvas = new GameCanvas();
            window.Content = gameCanvas;
        }
    }
}