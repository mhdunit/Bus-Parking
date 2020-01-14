using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectToggle : MonoBehaviour
{
    public CarSelect CS;

    void OnEnable()
    {
        StartCoroutine(CS.BusAndCarPriceWithDelay());
    }

}
