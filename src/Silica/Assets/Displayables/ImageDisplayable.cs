using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Silica.Assets.Displayables
{
    public class ImageDisplayable : IDisplayable
    {
        public string Key { get; private set; }
        public string FileName { get; private set; }

        internal Image PairedUserControl { get; set; }

        internal ImageDisplayable(string key, string fileName)
        {
            //todo argument check

            Key = key;
            FileName = fileName;
        }
    }
}
