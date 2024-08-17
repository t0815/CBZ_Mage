﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Win_CBZ.Data
{
    internal class ParseFilesThreadParams
    {
        public List<StackItem> Stack { get; set; }
         
        public List<string> FileNamesToAdd { get; set; }

        public bool HasMetaData { get; set; }

        public MetaData.PageIndexVersion PageIndexVerToWrite { get; set; } = MetaData.PageIndexVersion.VERSION_1;

        public CancellationToken CancelToken { get; set; }
    }
}
