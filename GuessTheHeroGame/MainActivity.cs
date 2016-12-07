using Android.App;
using Android.Widget;
using Android.OS;

namespace GuessTheHeroGame
{
    [Activity(Label = "GuessTheHeroGame", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btnStart = FindViewById<Button>(Resource.Id.btnStart);
            Button btnExit = FindViewById<Button>(Resource.Id.btnExit);

            btnStart.Click += delegate
            {
                //start hero game
                StartActivity(typeof(grnArrowAct));
                
            };

            btnExit.Click += delegate
            {
                System.Environment.Exit(0);
            };









        }
    }
}

