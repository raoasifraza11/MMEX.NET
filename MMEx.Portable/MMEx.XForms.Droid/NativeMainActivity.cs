using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;

namespace MMEx.XForms.Droid
{
    [Activity(Label = "MMEx.Net.Android", Icon = "@drawable/icon", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class NativeMainActivity : Activity
    {
        private DrawerLayout mDrawer;
        //private MyActionBarDrawerToggle mDrawerToggle;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // todo ShowTutorial();

            //SetContentView(Resource.Layout.Main);
            CreateLayout();

            // todo set event handlers here.
        }

        private void ShowTutorial()
        {
            StartActivity(typeof(TutorialActivity));
        }

        private void CreateLayout()
        {
            SetContentView(Resource.Layout.Main);

            // todo toolbar

            // todo fragmentDetail

            InitializeDrawer();
        }

        private void InitializeDrawer()
        {
            // navigation drawer
            mDrawer = (DrawerLayout) FindViewById(Resource.Id.drawerLayout);

            // set a custom shadow that overlays the main content when the drawer opens
            if (mDrawer == null) return;

            //todo mDrawerToggle = new MyActionBarDrawerToggle(this, mDrawer, R.string.open, R.string.closed);
            //todo mDrawer.setDrawerListener(mDrawerToggle);

            // create drawer menu
            // todo initializeDrawerVariables();
            // todo createExpandableDrawer();

            // enable ActionBar app icon to behave as action to toggle nav drawer
            // todo setDisplayHomeAsUpEnabled(true);
            // todo getSupportActionBar().setDisplayShowTitleEnabled(true);
        }
    }
}