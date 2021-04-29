﻿using GraphX.Common.Models;
using GraphX.Measure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using YAXLib;

namespace ControlsLibrary.Model
{
    public class EdgeViewModel : EdgeBase<NodeViewModel>, INotifyPropertyChanged
    {
        public EdgeViewModel()
            : base(null, null, 1)
        { 
        }
        /// <summary>
        /// Constructor which gets two vertices and symbols of transition
        /// </summary>
        /// <param name="source">Source vertex</param>
        /// <param name="target">Target vertex</param>
        /// <param name="availableSymbols">Symbols of transition</param>
        public EdgeViewModel(NodeViewModel source, NodeViewModel target)
            : base(source, target, 1)
        {
        }

        private bool isEpsilon;

        public bool IsEpsilon
        {
            get => isEpsilon;
            set
            {
                isEpsilon = value;
                OnPropertyChanged();
                OnPropertyChanged("TransitionTokens");
                OnPropertyChanged("TransitionTokensString");
            }
        }

        private string transitionTokensString = "";

        public string TransitionTokensString
        {
            get
            {
                return transitionTokensString;
            }
            set
            {
                transitionTokensString = value;
                OnPropertyChanged();
            }
        }

        [YAXDontSerialize]
        public List<char> TransitionTokens 
        {
            get
            {
                if (transitionTokensString == "")
                {
                    return new List<char>();
                }
                return transitionTokensString.ToList();
            }
        }

        public override Point[] RoutingPoints { get; set; }

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
