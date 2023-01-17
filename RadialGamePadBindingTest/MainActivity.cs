using AndroidX.AppCompat.App;
using Com.Swordfish.Radialgamepad.Library;
using Com.Swordfish.Radialgamepad.Library.Config;
using Com.Swordfish.Radialgamepad.Library.Event;
using Com.Swordfish.Radialgamepad.Library.Haptics;

namespace RadialGamePadBindingTest
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var _config = new RadialGamePadConfig(6,
            new PrimaryDialConfig.Cross(new CrossConfig(
                0,
                CrossConfig.Shape.Standard,
                null,
                new List<GestureType>(),
                new CrossContentDescription(),
                false,
                new RadialGamePadTheme()
                )),
                new List<SecondaryDialConfig>(),
                HapticConfig.Press,
                new RadialGamePadTheme(),
                false
                );

            var pad = new Com.Swordfish.Radialgamepad.Library.RadialGamePad(_config, 8f, this);

            this.FindViewById<FrameLayout>(Resource.Id.container)?.AddView(pad);
        }
    }
}