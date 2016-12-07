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
    public class blackwidowAct : Activity 
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.blackwidow);

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
                    imgHero.SetBackgroundResource(Resource.Drawable.blackwidow);
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
                btnHintOne.Text = "Best spy and master of disguise";
                btnHintOne.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnHintTwo.Click += delegate
            {
                btnHintTwo.Text = "More deadly than the spider";
                btnHintTwo.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnHintThree.Click += delegate
            {
                btnHintThree.Text = "Real name: Natasha Romanova";
                btnHintThree.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnGiveUp.Click += delegate
            {
                //reveal hero
                imgHero.SetBackgroundResource(Resource.Drawable.blackwidow);
                txtUserInput.Text = "blackwidow";
                btnGiveUp.Text = "Finish";
                btnGiveUp.Click += delegate
                {
                    StartActivity(typeof(MainActivity));
                };

                //no points
                //score activity
            };
        }
    }
}