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
    public class thorAct : Activity
    {
        Button btnHintOne;
        Button btnHintTwo;
        Button btnHintThree;
        Button btnGiveUp;
        Button btnEnter;
        TextView txtUserInput;
        ImageView imgHero;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.thor);

            //GTH Game (copy&paste template for all heroes)
            btnHintOne = FindViewById<Button>(Resource.Id.btnHintOne);
            btnHintTwo = FindViewById<Button>(Resource.Id.btnHintTwo);
            btnHintThree = FindViewById<Button>(Resource.Id.btnHintThree);
            btnGiveUp = FindViewById<Button>(Resource.Id.btnGiveUp);
            btnEnter = FindViewById<Button>(Resource.Id.btnEnter);
            txtUserInput = FindViewById<TextView>(Resource.Id.txtUserInput);
            imgHero = FindViewById<ImageView>(Resource.Id.imgHero);

            // user text and enter
            btnEnter.Click += delegate
            {
                // answer in lowercase
                if (txtUserInput.Text == "thor")
                {
                    // reveal hero img
                    imgHero.SetBackgroundResource(Resource.Drawable.thor);
                    txtUserInput.Text = "CORRECT!";
                    btnGiveUp.Text = "Next";
                    btnGiveUp.Click += delegate
                    {                        
                        imgHero.Dispose();
                        GC.Collect();
                        base.OnDestroy();
                        StartActivity(typeof(blackwidowAct));
                    };
                    
                    // score activity
                    // 1 hint - 20pts 
                    // 2 hints - 10pts
                    // 3 hints - 5pts

                }
                else
                {
                    // clear txtUserInput
                    txtUserInput.Text = "Wrong. Try Again.";                    
                }
            };



            // btn hints and give up
            btnHintOne.Click += delegate
            {
                btnHintOne.Text = "Son of Odin";
                btnHintOne.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnHintTwo.Click += delegate
            {
                btnHintTwo.Text = "His entrance is electrifying";
                btnHintTwo.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnHintThree.Click += delegate
            {
                btnHintThree.Text = "Hammer-time!";
                btnHintThree.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnGiveUp.Click += delegate
            {
                //reveal hero
                imgHero.SetBackgroundResource(Resource.Drawable.thor);                              
                txtUserInput.Text = "thor";
                btnGiveUp.Text = "Next";
                btnGiveUp.Click += delegate
                {         
                    imgHero.Dispose();
                    StartActivity(typeof(blackwidowAct));
                };

                //no points
                //score activity
            };
            }
            
    }
}