﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_CBZ
{
    internal class MetaDataValidationException : ApplicationException
    {

        public MetaDataEntry Item;

        public string ControlName;

        public bool RemoveEntry;

        public MetaDataValidationException(MetaDataEntry item, string control, String message, bool showErrorDialog = false, bool removeEntry = false) : base(message, showErrorDialog)
        {
            Item = item;
            RemoveEntry = removeEntry;
            ControlName = control;
        }

        public MetaDataValidationException(String key, String value, string control, String message, bool showErrorDialog = false, bool removeEntry = false) : base(message, showErrorDialog)
        {
            Item = new MetaDataEntry(key, value);
            RemoveEntry = removeEntry;
            ControlName = control;
        }
    }
}
