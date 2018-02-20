﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Preferences;
using Android.Graphics;
using Android.Util;

namespace TheDataProject.Droid.Helpers
{
    public class AppPreferences
    {
        private ISharedPreferences nameSharedPrefs;
        private ISharedPreferencesEditor namePrefsEditor; //Declare Context,Prefrences name and Editor name  
        private Context mContext;
        private static String PREFERENCE_ACCESS_KEY = "PREFERENCE_ACCESS_KEY"; //Value Access Key Name  
        public static String NAME = "NAME"; //Value Variable Name  
        private static String PREFERENCE_ACCESS_List; //Value Access Key Name  
        public static String NAMES; //Value Variable Name  
        public AppPreferences(Context context)
        {
            this.mContext = context;
            nameSharedPrefs = PreferenceManager.GetDefaultSharedPreferences(mContext);
            namePrefsEditor = nameSharedPrefs.Edit();
        }
        public void SaveUserId(string key) // Save data Values  
        {
            namePrefsEditor.PutString(PREFERENCE_ACCESS_KEY, key);
            namePrefsEditor.Commit();
        }
        public void SaveFacilityId(string key) // Save data Values  
        {
            namePrefsEditor.PutString(PREFERENCE_ACCESS_List, key);
            namePrefsEditor.Commit();
        }
        public string GetUserId() // Return Get the Value  
        {
            return nameSharedPrefs.GetString(PREFERENCE_ACCESS_KEY, "");
        }
        public string GetFacilityId() // Return Get the Value  
        {
            return nameSharedPrefs.GetString(PREFERENCE_ACCESS_KEY, "");
        }

        public Bitmap StringToBitMap(String encodedString)
        {
            try
            {
                byte[] encodeByte = Base64.Decode(encodedString, Base64.Default);
                return BitmapFactory.DecodeByteArray(encodeByte, 0, encodeByte.Length);               
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Bitmap SetImageBitmap(string filePath)
        {
            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    var image = new Java.IO.File(filePath);
                    return BitmapFactory.DecodeFile(image.AbsolutePath);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Java.IO.File CreateDirectoryForPictures()
        {
            Java.IO.File _dir = new Java.IO.File(
                Android.OS.Environment.GetExternalStoragePublicDirectory(
                    Android.OS.Environment.DirectoryPictures), "TheDataProjectImages");
            if (!_dir.Exists())
            {
                _dir.Mkdirs();
            }

            return _dir;
        }
    }
}