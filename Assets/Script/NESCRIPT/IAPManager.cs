using System;
using UnityEngine;
using UnityEngine.Purchasing;


public class IAPManager : MonoBehaviour, IStoreListener
{
    public static IAPManager instance;

    private static IStoreController m_StoreController;
    private static IExtensionProvider m_StoreExtensionProvider;

    //Step 1 create your products
    private string coin80 = "com.playcastle.lattolatto.coin80";
    private string coin30 = "com.playcastle.lattolatto.coin30";
    private string coin155 = "com.playcastle.lattolatto.coin155";
    private string coin500 = "com.playcastle.lattolatto.coin500";
    private string coin1075 = "com.playcastle.lattolatto.coin1075";


    //************************** Adjust these methods **************************************
    public void InitializePurchasing()
    {
        if (IsInitialized()) { return; }
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        //Step 2 choose if your product is a consumable or non consumable
        builder.AddProduct(coin80,ProductType.Consumable);
        builder.AddProduct(coin30,ProductType.Consumable);
        builder.AddProduct(coin155,ProductType.Consumable);
        builder.AddProduct(coin500,ProductType.Consumable);
        builder.AddProduct(coin1075,ProductType.Consumable);

        UnityPurchasing.Initialize(this, builder);
    }


    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }


    //Step 3 Create methods
    public void BuyCoin80()
    {
        BuyProductID(coin80);
    }

    public void BuyCoin30()
    {
        BuyProductID(coin30);
    }
    public void BuyCoin155()
    {
        BuyProductID(coin155);
    }
    public void BuyCoin500()
    {
        BuyProductID(coin500);
    }
    public void BuyCoin1075()
    {
        BuyProductID(coin1075);
    }
    


    //Step 4 modify purchasing
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        if (String.Equals(args.purchasedProduct.definition.id, coin30, StringComparison.Ordinal))
        {
            Debug.Log("You've gained 30 coins");
            SaveManagerx.instance.money += 30;
            SaveManagerx.instance.Save();
        }
        else if (String.Equals(args.purchasedProduct.definition.id, coin80, StringComparison.Ordinal))
        {
            Debug.Log("You've gained 80 coins");
            SaveManagerx.instance.money += 80;
            SaveManagerx.instance.Save();
        }
        else if (String.Equals(args.purchasedProduct.definition.id, coin155, StringComparison.Ordinal))
        {
            Debug.Log("You've gained 155 coins");
            SaveManagerx.instance.money += 155;
            SaveManagerx.instance.Save();
        }
        else if (String.Equals(args.purchasedProduct.definition.id, coin500, StringComparison.Ordinal))
        {
            Debug.Log("You've gained 500 coins");
            SaveManagerx.instance.money += 500;
            SaveManagerx.instance.Save();
        }
        else if (String.Equals(args.purchasedProduct.definition.id, coin1075, StringComparison.Ordinal))
        {
            Debug.Log("You've gained 1075 coins");
            SaveManagerx.instance.money += 1075;
            SaveManagerx.instance.Save();
        }
        else
        {
            Debug.Log("Purchase Failed");
        }
        return PurchaseProcessingResult.Complete;
    }










    //**************************** Dont worry about these methods ***********************************
    private void Awake()
    {
        TestSingleton();
    }

    void Start()
    {
        if (m_StoreController == null) { InitializePurchasing(); }
    }

    private void TestSingleton()
    {
        if (instance != null) { Destroy(gameObject); return; }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void BuyProductID(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);
            if (product != null && product.availableToPurchase)
            {
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }
            else
            {
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        else
        {
            Debug.Log("BuyProductID FAIL. Not initialized.");
        }
    }

    public void RestorePurchases()
    {
        if (!IsInitialized())
        {
            Debug.Log("RestorePurchases FAIL. Not initialized.");
            return;
        }

        if (Application.platform == RuntimePlatform.IPhonePlayer ||
            Application.platform == RuntimePlatform.OSXPlayer)
        {
            Debug.Log("RestorePurchases started ...");

            var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
            apple.RestoreTransactions((result) => {
                Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
            });
        }
        else
        {
            Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
        }
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("OnInitialized: PASS");
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }


    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }
}