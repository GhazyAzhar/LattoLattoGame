using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAPManagerLama : MonoBehaviour
{
    private string coin80 = "com.playcastle.lattolatto.coin80";
    private string coin30 = "com.playcastle.lattolatto.coin30";
    private string coin155 = "com.playcastle.lattolatto.coin155";
    private string coin500 = "com.playcastle.lattolatto.coin500";
    private string coin1075 = "com.playcastle.lattolatto.coin1075";

    public void OnPurchaseComplete(Product product)
    {
        if(product.definition.id == coin30)
        {
            //reward the player
            Debug.Log("You've gained 30 coins");
            SaveManagerx.instance.money += 30;
            SaveManagerx.instance.Save();
        }
        if (product.definition.id == coin80)
        {
            //reward the player
            Debug.Log("You've gained 80 coins");
            SaveManagerx.instance.money += 80;
            SaveManagerx.instance.Save();
        }
        if (product.definition.id == coin155)
        {
            //reward the player
            Debug.Log("You've gained 155 coins");
            SaveManagerx.instance.money += 155;
            SaveManagerx.instance.Save();
        }
        if (product.definition.id == coin500)
        {
            //reward the player
            Debug.Log("You've gained 500 coins");
            SaveManagerx.instance.money += 500;
            SaveManagerx.instance.Save();
        }
        if (product.definition.id == coin1075)
        {
            //reward the player
            Debug.Log("You've gained 1075 coins");
            SaveManagerx.instance.money += 1075;
            SaveManagerx.instance.Save();
        }

    }
    
   public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(product.definition.id + " failed because" + failureReason);
    }    

}
