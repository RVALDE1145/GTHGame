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
    public class grnArrowAct : Activity
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

            SetContentView(Resource.Layout.greenArrow);

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
                if (txtUserInput.Text == "green arrow")
                {
                    // reveal hero img
                    imgHero.SetBackgroundResource(Resource.Drawable.greenarrow);
                    txtUserInput.Text = "CORRECT!";
                    btnGiveUp.Text = "Next";
                    btnGiveUp.Click += delegate
                    {                        
                        imgHero.Dispose();
                        GC.Collect();
                        base.OnDestroy();
                        StartActivity(typeof(hawkeyeAct));
                    };
                    // wait for a sec then open
                    // score activity
                    // 1 hint - 20pts 
                    // 2 hints - 10pts
                    // 3 hints - 5pts

                }
                else
                {
                    // clear txtUserInput
                    txtUserInput.Text = "Wrong. Try Again.";
                    // popup dialog "incorrect. try again"
                }
            };


        // btn hints and give up
        btnHintOne.Click += delegate
            {
                btnHintOne.Text = "Uses a Bow";
                btnHintOne.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnHintTwo.Click += delegate
            {
                btnHintTwo.Text = "Real name: Oliver Queen";
                btnHintTwo.SetBackgroundColor(Android.Graphics.Color.Black);
            };

            btnHintThree.Click += delegate
            {
                btnHintThree.Text = "His sidekick is Speedy";
                btnHintThree.SetBackgroundColor(Android.Graphics.Color.Black);                
            };

            btnGiveUp.Click += delegate
            {
                //reveal hero
                imgHero.SetBackgroundResource(Resource.Drawable.greenarrow);
                
                txtUserInput.Text = "green arrow";
                btnGiveUp.Text = "Next";
                btnGiveUp.Click += delegate
                {           
                    imgHero.Dispose();
                    StartActivity(typeof(hawkeyeAct));
                };
                //no points
                //score activity
            };      

            


    }


    //public static void score()
    //{
    //score sequence
    //}
}    

}