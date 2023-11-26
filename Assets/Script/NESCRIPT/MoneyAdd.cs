using UnityEngine;

public class MoneyAdd : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SaveManagerx.instance.money += 100;
            SaveManagerx.instance.Save();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            SaveManagerx.instance.money -= 100;
            SaveManagerx.instance.Save();
        }
    }
}