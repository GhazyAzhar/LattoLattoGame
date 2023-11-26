using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    public enum PurchaseType {coin30, coin80, coin155, coin500, coin1075};
    public PurchaseType purchaseType;

    public void ClickPurchaseButton()
    {
        switch (purchaseType)
        {
            case PurchaseType.coin80:
                IAPManager.instance.BuyCoin80();
                break;
            case PurchaseType.coin30:
                IAPManager.instance.BuyCoin30();
                break;
            case PurchaseType.coin155:
                IAPManager.instance.BuyCoin155();
                break;
            case PurchaseType.coin500:
                IAPManager.instance.BuyCoin500();
                break;
            case PurchaseType.coin1075:
                IAPManager.instance.BuyCoin1075();
                break;
        }
    }
   

        
    
}
