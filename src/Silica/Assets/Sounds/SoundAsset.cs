using System;

namespace Silica.Assets.Sounds
{
    public class SoundAsset: IKeyedAsset
    {
        public string Key { get; private set; }
        public SoundAssetType SoundType { get; private set; }
        public string FileName { get; private set; }

        internal SoundAsset(string key, SoundAssetType soundType, string fileName)
        {
            //todo argument check

            Key = key;
            SoundType = soundType;
            FileName = fileName;
        }
    }
}