﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataSamples
{
    public class AppSettings
    {
        #region Singleton of AppSettings
        private static AppSettings _Instance = null;

        public static AppSettings Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AppSettings();

                return _Instance;
            }
        }
        #endregion

        protected string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        public string ConnectString
        {
            get { return GetConnectionString("Sandbox"); }
        }
    }
}
