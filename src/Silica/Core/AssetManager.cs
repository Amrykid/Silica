using Silica.Assets;
using Silica.Assets.Displayables;
using Silica.Assets.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silica.Core
{
    public class AssetManager
    {
        public static AssetManager Instance { get; private set; }
        internal static void CreateInstance()
        {
            Instance = new AssetManager();
        }


        private List<ImageDisplayable> imageDisplayables = null;
        private List<SoundAsset> soundAssets = null;

        public IReadOnlyList<ImageDisplayable> Images { get; private set; }
        public IReadOnlyList<SoundAsset> Sounds { get; private set; }

        private AssetManager()
        {
            imageDisplayables = new List<ImageDisplayable>();
            soundAssets = new List<SoundAsset>();

            Images = imageDisplayables.AsReadOnly();
            Sounds = soundAssets.AsReadOnly();
        }

        public ImageDisplayable LoadImage(string key, string fileName)
        {
            if (Images.Any(x => x.Key.Equals(key)))
                throw new ArgumentException("Image with that key already exists!", nameof(key));

            ImageDisplayable display = new ImageDisplayable(key, fileName);
            imageDisplayables.Add(display);

            return display;
        }

        public SoundAsset LoadSound(string key, SoundAssetType soundType, string fileName)
        {
            if (Sounds.Any(x => x.Key.Equals(key)))
                throw new ArgumentException("Sound with that key already exists!", nameof(key));

            SoundAsset sound = new SoundAsset(key, soundType, fileName);
            soundAssets.Add(sound);

            return sound;
        }
    }
}