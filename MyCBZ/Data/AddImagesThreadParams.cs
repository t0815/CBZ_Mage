﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_CBZ.Data
{
    internal class AddImagesThreadParams
    {
        public List<LocalFile> LocalFiles {  get; set; }

        public List<int> Stack { get; set;}
    }
}
