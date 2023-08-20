﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_CBZ
{
    internal class PipelineEvent
    {
        public const int PIPELINE_FILES_PARSED = 0;
        public const int PIPELINE_PAGES_ADDED = 1;
        public const int PIPELINE_SAVE_REQUESTED = 2;
        public const int PIPELINE_SAVE_UPDATE_INDICES = 3;
        public const int PIPELINE_SAVE_RUN_RENAMING = 4;
        public const int PIPELINE_SAVE_ARCHIVE = 5;
        public const int PIPELINE_INDICES_UPDATED = 6;

        public ProjectModel ArchiveInfo { get; set; }

        public int State { get; set; }

        public PipelinePayload payload { get; set; }


        public delegate void Operation();


        public PipelineEvent.Operation Callback;


        public PipelineEvent(ProjectModel project, int state)
        {
            ArchiveInfo = project;
            State = state;

        }

        public PipelineEvent(ProjectModel project, int state, PipelinePayload pipelineConfig)
        {
            ArchiveInfo = project;
            State = state;
            payload = pipelineConfig;
        }

        public PipelineEvent(ProjectModel project, int state, PipelinePayload pipelineConfig, PipelineEvent.Operation callback)
        {
            ArchiveInfo = project;
            State = state;
            payload = pipelineConfig;
            Callback = callback;
        }   
    }
}
