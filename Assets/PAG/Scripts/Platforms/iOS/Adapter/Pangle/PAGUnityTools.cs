#if UNITY_IOS
using System.Collections.Generic;
using UnityEngine;

namespace PAG.Scripts.Platforms.iOS.Adapter.Pangle
{
    public class PAGUnityTools
    {
        private static int mainThreadID = System.Threading.Thread.CurrentThread.ManagedThreadId;

        internal static bool isMainThread()
        {
            return System.Threading.Thread.CurrentThread.ManagedThreadId == mainThreadID;
        }

        internal static void LOGWithMessage(string className,string methodName,string msg)
        {
            Debug.Log($"Pangle-iOS-[{className}]-[{methodName}]-{msg}");
        }
    }
}
#endif