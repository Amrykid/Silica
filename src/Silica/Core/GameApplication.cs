using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace Silica.Core
{
    public abstract class GameApplication: Application
    {
        public GameApplication()
        {

        }

        #region Boiling Plate
        protected sealed override void OnActivated(IActivatedEventArgs args)
        {
            base.OnActivated(args);
        }

        protected sealed override void OnBackgroundActivated(BackgroundActivatedEventArgs args)
        {
            base.OnBackgroundActivated(args);
        }

        protected sealed override void OnCachedFileUpdaterActivated(CachedFileUpdaterActivatedEventArgs args)
        {
            base.OnCachedFileUpdaterActivated(args);
        }

        protected sealed override void OnFileActivated(FileActivatedEventArgs args)
        {
            base.OnFileActivated(args);
        }

        protected sealed override void OnFileOpenPickerActivated(FileOpenPickerActivatedEventArgs args)
        {
            base.OnFileOpenPickerActivated(args);
        }

        protected sealed override void OnFileSavePickerActivated(FileSavePickerActivatedEventArgs args)
        {
            base.OnFileSavePickerActivated(args);
        }

        protected sealed override void OnSearchActivated(SearchActivatedEventArgs args)
        {
            base.OnSearchActivated(args);
        }

        protected sealed override void OnShareTargetActivated(ShareTargetActivatedEventArgs args)
        {
            base.OnShareTargetActivated(args);
        }

        protected sealed override void OnWindowCreated(WindowCreatedEventArgs args)
        {
            base.OnWindowCreated(args);
        }
        #endregion

        protected sealed override void OnLaunched(LaunchActivatedEventArgs args)
        {
            DisplayManager.CreateInstance(Window.Current);
            AudioManager.CreateInstance();
            AssetManager.CreateInstance();
            LoadAssets(AssetManager.Instance);
        }

        public abstract void LoadAssets(AssetManager assetManager);
    }
}
