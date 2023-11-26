using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI inputScore;
    [SerializeField]
    private TMP_InputField inputName;

    public UnityEvent<string, int> SubmitScoreEvent;

    void Start()
    {
        //
    }
    public void SubmitScore() {
        
        SubmitScoreEvent.Invoke(inputName.text, int.Parse(inputScore.text));
        
    }
    
}
 