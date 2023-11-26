using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    private int highscore = 0;
    public TextMeshProUGUI textMeshProUGUI;


    private void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        highscoreText.text = "Highscore: " + highscore.ToString();
        
    }

    private void Update()
    {
        //tmp to int
        string text = textMeshProUGUI.text;
        int number;
        if (int.TryParse(text, out number))
        {
            Debug.Log("Number: " + number);
        }
        else
        {
            Debug.LogError("Text is not a valid integer number");
        }
    }

    public void SetHighscore(int number)
    {
        if (number > highscore)
        {
            highscore = number;
            PlayerPrefs.SetInt("Highscore", highscore);
            highscoreText.text = "Highscore: " + highscore.ToString();
        }
    }
}
