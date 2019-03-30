using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UpgradeSystem : MonoBehaviour
{

    public GameObject BusPlaceHolder;
    public Scrollbar Power, Speed, Brake;
    public GameObject [] LevelMax;




    void Start()
    {

    }

    public void BusUpgradePower()
    {
        if (Power.size < 0.8f)
        {
            Power.size += 0.2f;
            print("Power Upgrade Level " + Power.size * 5);
        }
        else if (Power.size == 0.8f)
        {
            Power.size += 0.2f;
            LevelMax[0].SetActive(true);
            print("Power Upgrade Level Max");
        }
    }
    public void BusUpgradeSpeed()
    {
        if (Speed.size < 0.8f)
        {
            Speed.size += 0.2f;
            print("Speed Upgrade Level " + Speed.size * 5);
        }
        else if (Speed.size == 0.8f)
        {
            Speed.size += 0.2f;
            LevelMax[1].SetActive(true);
            print("Speed Upgrade Level Max");
        }
    }
    public void BusUpgradeBrake()
    {
        if (Brake.size < 0.8f)
        {
            Brake.size += 0.2f;
            print("Brake Upgrade Level " + Brake.size * 5);
        }
        else if (Brake.size == 0.8f)
        {
            Brake.size += 0.2f;
            LevelMax[2].SetActive(true);
            print("Brake Upgrade Level Max");
        }
    }
}
