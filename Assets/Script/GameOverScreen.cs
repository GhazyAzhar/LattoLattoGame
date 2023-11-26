using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    
    public TextMeshProUGUI pointsText;

    
    
    public void Setup(int scoreAmount)
    {
        gameObject.SetActive(true);
        pointsText.text = Clickcount.scoreAmount + " POINTrrrrrr";
    }

    
}
