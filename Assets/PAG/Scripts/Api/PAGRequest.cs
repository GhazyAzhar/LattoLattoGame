using System;
using UnityEngine;

namespace PAG.Scripts.Api
{
    [Serializable]
    public class PAGRequest
    {
        [SerializeField] private string extraInfo;

        public string ExtraInfoJson
        {
            get => extraInfo;
            set => extraInfo = value;
        }

        public string ToJson()
        {
            return JsonUtility.ToJson(this);
        }
    }
}