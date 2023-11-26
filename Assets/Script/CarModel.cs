using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarModel : MonoBehaviour
{
    [SerializeField] private GameObject[] carModels;
    private static int currentCar;
    private void Awake()
    {
        ChooseCarModel(SaveManagerx.instance.currentCar);
    }
    private void ChooseCarModel(int _index)
    {
        Instantiate(carModels[_index], transform.position = new Vector3(0f, 0f, 0f) , Quaternion.identity, transform);
    }
}
