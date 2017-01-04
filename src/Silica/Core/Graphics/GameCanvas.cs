using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Composition;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;

namespace Silica.Core.Graphics
{
    internal class GameCanvas: UserControl
    {
        private Canvas compositionBackdropCanvas;
        private Compositor compositionBackdropCompositor;
        private Visual compositionBackdropHostVisual;
        private Grid layoutRootGrid;
        private Canvas topLevelCanvas;

        internal GameCanvas()
        {
            //set up a canvas for basic graphics and an invisible canvas for the Windows.UI.Composition (Win2D) stuff.

            //first setup the Composition stuff
            compositionBackdropCanvas = new Canvas();
            compositionBackdropHostVisual = ElementCompositionPreview.GetElementVisual(compositionBackdropCanvas);
            compositionBackdropCompositor = compositionBackdropHostVisual.Compositor;

            //then setup the canvas for basic graphics
            topLevelCanvas = new Canvas();

            //finally, the grid that holds everything together
            layoutRootGrid = new Grid();

            layoutRootGrid.Children.Add(compositionBackdropCanvas);
            layoutRootGrid.Children.Add(topLevelCanvas);

            this.Content = layoutRootGrid;
        }
    }
}
