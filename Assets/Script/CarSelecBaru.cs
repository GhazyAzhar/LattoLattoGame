using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarSelecBaru : MonoBehaviour
{
    [Header("Navigation Buttons")]
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
    public Button buyButton;

    [Header("Car Attribute")]
    public GameObject[] carModels;
    public CarBlueprint[] cars;
    public static int currentCar;
    // Start is called before the first frame update
    private void Start()
    {
 
        foreach(CarBlueprint car in cars)
        {
            if (car.price == 0)
                car.isUnlocked = true;
            else
                car.isUnlocked = PlayerPrefs.GetInt(car.name, 0)== 0 ? false : true;
        }    
        currentCar = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach (GameObject car in carModels)
            car.SetActive(false);
        carModels[currentCar].SetActive(true);

    }

    private void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        CarBlueprint c = cars[currentCar];
        if(c.isUnlocked)
        {
            buyButton.gameObject.SetActive(false);
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            buyButton.GetComponentInChildren<Text>().text = " " + c.price;
            if (c.price < PlayerPrefs.GetInt("NumberOfCoins", 0))
            {
                buyButton.interactable = true;
            }
            else
            {
                buyButton.interactable = false;
            }    
        }
    }

    

   

    public void ChangeNext()
    {
        carModels[currentCar].SetActive(false);

        currentCar++;
        if (currentCar == carModels.Length)
            currentCar = 0;

        carModels[currentCar].SetActive(true);
        CarBlueprint c = cars[currentCar];
        if (!c.isUnlocked)
            return;
        PlayerPrefs.SetInt("SelectedCar", currentCar);
       
    }    

    public void ChangePrevious()
    {
        carModels[currentCar].SetActive(false);
        
        currentCar--;
        if (currentCar == - 1)
            currentCar = carModels.Length - 1;

        carModels[currentCar].SetActive(true);
        CarBlueprint c = cars[currentCar];
        if (!c.isUnlocked)
            return;
        PlayerPrefs.SetInt("SelectedCar", currentCar);

    }

    public void UnlockCar()
    {
        CarBlueprint c = cars[currentCar];

        PlayerPrefs.SetInt(c.name, 1);
        PlayerPrefs.SetInt("SelectedCar", currentCar);
        c.isUnlocked = true;
        PlayerPrefs.SetInt("NumberOfCoins", PlayerPrefs.GetInt("NumberOfCoins", 0) - c.price);
    }
}
