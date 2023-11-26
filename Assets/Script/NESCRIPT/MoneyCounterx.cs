using UnityEngine;
using UnityEngine.UI;

public class MoneyCounterx : MonoBehaviour
{
    private Text txt;

    private void Awake()
    {
        txt = GetComponent<Text>();
    }
    private void Update()
    {
        txt.text = SaveManagerx.instance.money + " ";
    }
}