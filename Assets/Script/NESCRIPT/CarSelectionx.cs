using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class CarSelectionx : MonoBehaviour
{
    [Header("Navigation Buttons")]
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;

    [Header("Play/Buy Buttons")]
    [SerializeField] private Button Play;
    [SerializeField] private Button Buy;
    [SerializeField] private Text priceText;

    [Header("Car Attributes")]
    [SerializeField] private int[] carPrices;
    private int currentCar;

    [Header("Sound")]
    [SerializeField] private AudioClip purchase;
    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        currentCar = SaveManagerx.instance.currentCar;
        SelectCar(currentCar);
    }

    private void SelectCar(int _index)
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).gameObject.SetActive(i == _index);

        UpdateUI();
    }
    private void UpdateUI()
    {
        //If current car unlocked show the play button
        if (SaveManagerx.instance.carsUnlocked[currentCar])
        {
            Play.gameObject.SetActive(true);
            Buy.gameObject.SetActive(false);
            
        }
        //If not show the buy button and set the price
        else
        {
            Play.gameObject.SetActive(false);
            Buy.gameObject.SetActive(true);
            priceText.text = carPrices[currentCar] + " ";
        }
    }

    private void Update()
    {
        //Check if we have enough money
        if (Buy.gameObject.activeInHierarchy)
            Buy.interactable = (SaveManagerx.instance.money >= carPrices[currentCar]);
    }

    public void ChangeCar(int _change)
    {
        currentCar += _change;

        if (currentCar > transform.childCount - 1)
            currentCar = 0;
        else if (currentCar < 0)
            currentCar = transform.childCount - 1;

        SaveManagerx.instance.currentCar = currentCar;
        SaveManagerx.instance.Save();
        SelectCar(currentCar);
    }
    public void BuyCar()
    {
        SaveManagerx.instance.money -= carPrices[currentCar];
        SaveManagerx.instance.carsUnlocked[currentCar] = true;
        SaveManagerx.instance.Save();
        source.PlayOneShot(purchase);
        Debug.Log("TERBELI");
        UpdateUI();
    }
}