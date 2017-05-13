﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace EfficienSee.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigatingAware, IDestructible
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _timeSavedLabelText;
        public string TimeSavedLabelText
        {
            get { return _timeSavedLabelText; }
            set { SetProperty(ref _timeSavedLabelText, value); }
        }

        private int _timeSavedPerTask;
        public int TimeSavedPerTask
        {
            get { return _timeSavedPerTask; }
            set { SetProperty(ref _timeSavedPerTask, value); }
        }

        private string _taskFrequencyLabelText;
        public string TaskFrequencyLabelText
        {
            get { return _taskFrequencyLabelText; }
            set { SetProperty(ref _taskFrequencyLabelText, value); }
        }

        private int _taskFrequency;
        public int TaskFrequency
        {
            get { return _taskFrequency; }
            set { SetProperty(ref _taskFrequency, value); }
        }

        private string _taskLifetimeLabelText;
        public string TaskLifetimeLabelText
        {
            get { return _taskLifetimeLabelText; }
            set { SetProperty(ref _taskLifetimeLabelText, value); }
        }

        private int _taskLifetime;
        public int TaskLifetime
        {
            get { return _taskLifetime; }
            set { SetProperty(ref _taskLifetime, value); }
        }

        public MainPageViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(MainPageViewModel)}:  ctor");

            Title = "EfficienSee!";
            TimeSavedLabelText = "By how much time could you shorten your task, given some effort to make some part of it automated, or more efficient?";
            TaskFrequencyLabelText = "How frequently do you it?";
            TaskLifetimeLabelText = "How long will you keep performing this task?";
        }

        ~MainPageViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(MainPageViewModel)}:  dtor");
        }

        #region INavigatingAware

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatingTo)}");
        }

        #endregion End INavigatingAware

        #region IDestructible

        public void Destroy()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(Destroy)}");
        }

        #endregion End IDestructible
    }
}

