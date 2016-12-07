using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GuessTheHeroGame
{
    [Activity(Label = "Activity1")]
    public class hawkeyeAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.hawkeye);

            //GTH Game (copy&paste template for all heroes)
            Button btnHintOne = FindViewById<Button>(Resource.Id.btnHintOne);
            Button btnHintTwo = FindViewById<Button>(Resource.Id.btnHintTwo);
            Button btnHintThree = FindViewById<Button>(Resource.Id.btnHintThree);
            Button btnGiveUp = FindViewById<Button>(Resource.Id.btnGiveUp);
            Button btnEnter = FindViewById<Button>(Resource.Id.btnEnter);
            TextView txtUserInput = FindViewById<TextView>(Resource.Id.txtUserInput);
            ImageView imgHero = FindViewById<ImageView>(Resource.Id.imgHero);

            // user text and enter
            btnEnter.Click += delegate
            {
                txtUserInput.Text.ToLower();

                // answer in lowercase
                if (txtUserInput.Text == "hero name")
                {
                    // reveal hero img
                    imgHero.SetBackgroundResource(Resource.Drawable.hawkeye);
                    // wait for a sec then open
                    // score activity
                    // 1 hint - 20pts 
                    // 2 hints - 10pts
                    // 3 hints - 5pts

                }
                else
                {
                    // clear txtUserInput
                    txtUserInput.Text = "";
                    // popup dialog "incorrect. try again"
                }
            };



            // btn hints and give up
            btnHintOne.Click += delegate
            {
                btnHintOne.Text = "Original Costume is Purple";
                btnHintOne.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnHintTwo.Click += delegate
            {
                btnHintTwo.Text = "Has customized trick arrows";
                btnHintTwo.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnHintThree.Click += delegate
            {
                btnHintThree.Text = "He is from Iowa (hint hint)";
                btnHintThree.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnGiveUp.Click += delegate
            {
                //reveal hero
                imgHero.SetBackgroundResource(Resource.Drawable.hawkeye);
                // btnGiveUp changes to advance to next act.
                txtUserInput.Text = "hawkeye";
                btnGiveUp.Text = "Next";
                btnGiveUp.Click += delegate
                {
                    StartActivity(typeof(thorAct)); 
                };
           
                //no points
                //score activity
            };
        }
    }
}