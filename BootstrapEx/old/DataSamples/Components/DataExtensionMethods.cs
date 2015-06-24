﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataSamples
{
    public static class DataExtensionMethods
    {
        public static T GetDataAs<T>(this DataRow dr, string colName, T defaultValue = default(T))
        {
            object value = dr[colName];

            try
            {
                if (value.Equals(DBNull.Value))
                    return (T)defaultValue;
                else
                    return (T)value;  // This can cause an error on certain data types
            }
            catch
            {
                try
                {
                    return (T)Convert.ChangeType(value, typeof(T));  // This will work on certain data types and cause errors on others
                }
                catch
                {
                    return (T)defaultValue;
                }
            }
        }
    }
}