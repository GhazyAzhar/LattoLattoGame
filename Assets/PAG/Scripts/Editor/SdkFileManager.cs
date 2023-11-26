using System.IO;
using UnityEditor;
using UnityEngine;

namespace PAG.Scripts.Editor
{
    public static class SdkFileManager
    {
        private static readonly string[] OldFilePath =
        {
            "PangleAdapterScripts",
            "Example/Example.cs",
            "Example/PangleExampleP.cs",
            "Example/PangleToolsExample.cs",
            "Example/FeedView.java",
            "Example/IntersititialView.java",
            "Example/NativeAdManager.java",
            "Example/UnionAppController.mm",
            "Example/Tools.unity",
            "Example/Example.unity",
            "Example/Example_2018.unity",
        };
        

        private const string JavaFileDirectory = "PangleAdapterScripts/Scripts/Android";

        public static void DeleteOldFiles()
        {
            Debug.Log("Start delete old files");

            foreach (var t in OldFilePath)
            {
                AssetDatabase.DeleteAsset($"Assets/{t}");
                Debug.Log($"Delete Assets/{t}");
            }

            DeleteJavaFile();
            AssetDatabase.Refresh();
            Debug.Log($"Delete completed");
        }

        private static void DeleteJavaFile()
        {
            var javaDirectory = new DirectoryInfo(Path.Combine(Application.dataPath, JavaFileDirectory));
            if (!javaDirectory.Exists)
            {
                return;
            }

            foreach (var fileInfo in javaDirectory.GetFiles())
            {
                if (fileInfo.Extension != ".java") continue;
                var filePath = $"Assets/{JavaFileDirectory}/{fileInfo.Name}";
                AssetDatabase.DeleteAsset(filePath);
                Debug.Log($"Delete Assets/{filePath}");
            }
        }
    }
}