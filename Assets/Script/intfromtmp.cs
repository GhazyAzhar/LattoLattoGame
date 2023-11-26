using TMPro;
using UnityEngine;

public class intfromtmp: MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        string text = textMeshProUGUI.text;
        int number = int.Parse(text);
        Debug.Log("Number: " + number);
    }
}
