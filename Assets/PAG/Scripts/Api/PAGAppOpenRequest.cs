using System;
using UnityEngine;

namespace PAG.Scripts.Api
{
    [Serializable]
    public class PAGAppOpenRequest : PAGRequest
    {
        [SerializeField] private int timeout = 3500;

        public int Timeout
        {
            get => timeout;
            set => timeout = value;
        }
    }
}