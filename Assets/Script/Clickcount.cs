using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Clickcount : MonoBehaviour
{
    private TextMeshProUGUI score;
    public static int scoreAmount;
    bool isCurrentlyColliding;
    private int previousScore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        score = GetComponent<TextMeshProUGUI>();
    }

    
    // Update is called once per frame
    void Update()
    {
        score.text = scoreAmount.ToString();
        if (scoreAmount >= previousScore + 50)
        {

            SaveManagerx.instance.money += 9;
            previousScore += 50;
            Debug.Log("DAPET DUIT DARI SKOR");

        }
    }

    public void AddScore()
    {
        scoreAmount += 1;
    }
}
