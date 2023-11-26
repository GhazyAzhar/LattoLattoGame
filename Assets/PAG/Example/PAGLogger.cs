using UnityEngine;
using UnityEngine.UI;

namespace PAG.Example
{
    public class PAGLogger : MonoBehaviour
    {
        private static string _log;
        private const int MaxChars = 10000;
        // private Vector2 _scrollPos;

        private bool _showLogsOnScreen = false;
        private string _buttonText = "show log panel";

        public GameObject logPanel;
        public Text logTextView;

        void Start()
        {
            Application.logMessageReceived += HandleLog;
        }

        private void HandleLog(string condition, string stackTrace, LogType type)
        {
            Log(condition);
            if (type == LogType.Exception)
            {
                Log(stackTrace);
            }
        }

        private void Log(string msg)
        {
            _log = $"\n {msg} {_log}";
            if (_log.Length > MaxChars)
                _log = _log.Substring(0, MaxChars);

            if (!logTextView.IsDestroyed())
            {
                logTextView.text = _log;
            }
        }

        void OnGUI()
        {
            // if (_showLogsOnScreen)
            // {
            //     GUI.skin.box.fontSize = 30;
            //     GUI.skin.button.fontSize = 30;
            //     GUI.skin.verticalScrollbar.fixedWidth = 60;
            //     GUI.skin.verticalScrollbarThumb.fixedWidth = 60;
            //     GUI.skin.label.fontSize = 40;
            //     GUILayout.BeginArea(new Rect(0, Screen.height - 400, Screen.width, 400));
            //     GUI.Box(new Rect(0, 0, Screen.width, 400), "logs");
            //     using var scrollView =
            //         new GUILayout.ScrollViewScope(_scrollPos, GUILayout.Width(Screen.width),
            //             GUILayout.Height(400));
            //     _scrollPos = scrollView.scrollPosition;
            //     GUILayout.Label(_log);
            //     GUILayout.EndArea();
            // }

            GUI.skin.button.fontSize = 25;
            if (GUI.Button(new Rect(Screen.width - 250, Screen.height - 100, 200, 60), _buttonText))
            {
                _showLogsOnScreen = !_showLogsOnScreen;
                _buttonText = _showLogsOnScreen ? "hide log panel" : "show log panel";
                logPanel.SetActive(_showLogsOnScreen);
            }
        }
    }
}