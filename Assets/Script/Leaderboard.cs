using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro;
using Dan.Main; 

public class Leaderboard : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> names;
    [SerializeField]
    private List<TextMeshProUGUI> scores;

    private string publicLeaderboardKey = "dcdc47027a5db4e37c57deb5c63cb769694f232fc526c7736c4eaa6fc62bab93";

    private void Start() {
        GetLeaderboard();
    }
    
    public void GetLeaderboard() {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) => {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for (int i = 0; i < loopLength; ++i) {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));
    }

    public void SetLeaderboardEntry(string username, int score) {
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score, ((msg) => {
            // username.Substring(0, 4);
            // if(System.Array.IndexOf (badWords, name) != -1) return;
            GetLeaderboard();
        }));
    }
}
