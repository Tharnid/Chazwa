﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SolutionName.Web.ViewModels
{
    public class ModelStateException : Exception
    {
        public Dictionary<string, string> Errors { get; set; }


        public override string Message
        {
            get
            {
                if (Errors.Count > 0)
                {
                    return String.Join(" | ", Errors.Values.ToArray());
                }
                return null;
            }
        }


        public ModelStateException(ModelStateDictionary modelState)
        {
            if (modelState == null)
            {
                throw new ArgumentNullException("modelState");
            }

            Errors = new Dictionary<string, string>();

            if (!modelState.IsValid)
            {
                StringBuilder errors;
                foreach (KeyValuePair<string, ModelState> state in modelState)
                {
                    if (state.Value.Errors.Count > 0)
                    {
                        errors = new StringBuilder();
                        foreach (ModelError err in state.Value.Errors)
                        {
                            errors.AppendLine(err.ErrorMessage);
                        }
                        Errors.Add(state.Key, errors.ToString());
                    }
                }
            }
        }
    }
}