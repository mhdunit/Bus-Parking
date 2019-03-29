using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UpgradeSystem : MonoBehaviour
{

    public GameObject BusPlaceHolder;
    public Scrollbar Power, Speed, Brake;




    void Start()
    {

    }

    public void BusUpgradePower()
    {
        if (Power.size < 1)
        {
            Power.size += 0.2f;
           
            print("Power Upgrade Level " + Power.size * 5);
        }
       
    }
    public void BusUpgradeSpeed()
    {
       if (Speed.size < 1)
        {
            Speed.size += 0.2f;
            print("Speed Upgrade Level " + Speed.size * 5);
        }
    }
    public void BusUpgradeBrake()
    {
        if (Brake.size < 1)
        {
            Brake.size += 0.2f;
            print("Brake Upgrade Level " + Brake.size * 5);
        }
    }
}
