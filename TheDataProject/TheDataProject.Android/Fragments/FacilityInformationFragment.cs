﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace TheDataProject.Droid.Fragments
{
    public class FacilityInformationFragment : Android.Support.V4.App.Fragment, IFragmentVisible
    {
        public static FacilityInformationFragment NewInstance() => new FacilityInformationFragment { Arguments = new Bundle() };
        

        ProgressBar progress;
        public static FacilityDetailViewModel ViewModel { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewModel = new FacilityDetailViewModel();

            View view = inflater.Inflate(Resource.Layout.fragment_facility_information, container, false);

            return view;
        }

        public void BecameVisible()
        {

        }
    }
}