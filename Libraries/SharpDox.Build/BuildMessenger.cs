﻿using System;
using SharpDox.Model.Repository;
using SharpDox.Sdk.Build;

namespace SharpDox.Build
{
    public class BuildMessenger : IBuildMessenger
    {
        public event Action<SDRepository> OnParseCompleted;

        public event Action<string> OnBuildMessage;
        public event Action<string> OnStepMessage;
        public event Action<int> OnBuildProgress;
        public event Action<int> OnStepProgress;
        public event Action OnBuildStopped;

        internal void ExecuteOnParseCompleted(SDRepository repository)
        {
            if (OnParseCompleted != null)
            {
                OnParseCompleted(repository);
            }
        }

        internal void ExecuteOnBuildMessage(string message)
        {
            if (OnBuildMessage != null)
            {
                OnBuildMessage(message);
            }
        }

        internal void ExecuteOnStepMessage(string message)
        {
            if (OnStepMessage != null)
            {
                OnStepMessage(message);
            }
        }

        internal void ExecuteOnBuildProgress(int value)
        {
            if (OnBuildProgress != null)
            {
                OnBuildProgress(value);
            }
        }

        internal void ExecuteOnStepProgress(int value)
        {
            if (OnStepProgress != null)
            {
                OnStepProgress(value);
            }
        }

        internal void ExecuteOnBuildStopped()
        {
            if (OnBuildStopped != null)
            {
                OnBuildStopped();
            }
            ExecuteOnStepMessage("");
        }
    }
}