﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_CBZ
{
    internal class GeneralTaskProgressEvent
    {

        public const int TASK_RELOAD_IMAGE_METADATA = 0;
        public const int TASK_ = 1;

        public const int TASK_STATUS_IDLE = 10;
        public const int TASK_STATUS_RUNNING = 11;
        public const int TASK_STATUS_COMPLETED = 12;

        public int Type { get; set; }

        public int Status { get; set; }

        public int Current { get; set; }

        public int Total { get; set; }

        public string Message { get; set; }



        public GeneralTaskProgressEvent(int type, int status, string message, int current, int total)
        {
            Current = current; 
            Total = total;
            Type = type;
            Status = status;
            Message = message;
        }   
    }
}
