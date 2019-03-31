using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UpgradeSystem : MonoBehaviour
{
    public Slider Power, Speed, Steer;
    public GameObject[] LevelMax;




    void Start()
    {

    }
    void OnEnable()
    {

        Power.value = PlayerPrefs.GetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Power");
        if (Power.value == 10)
            LevelMax[0].SetActive(true);
        else
            LevelMax[0].SetActive(false);

        Speed.value = PlayerPrefs.GetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Speed");
        if (Speed.value == 10)
            LevelMax[1].SetActive(true);
        else
            LevelMax[1].SetActive(false);


        Steer.value = PlayerPrefs.GetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Steer");
        if (Steer.value == 10)
            LevelMax[2].SetActive(true);
        else
            LevelMax[2].SetActive(false);

    }
    public void BusUpgradePower()
    {
        if (Power.value < 10)
        {
            Power.value += 1;
            PlayerPrefs.SetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Power", (int)Power.value);

            if (Power.value < 10)
                print("Power Upgrade Level to : " + Power.value);
            else
            {
                print("Power Upgrade Level to Max");
                LevelMax[0].SetActive(true);
            }
        }
    }
    public void BusUpgradeSpeed()
    {
        if (Speed.value < 10)
        {
            Speed.value += 1;
            PlayerPrefs.SetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Speed", (int)Speed.value);

            if (Speed.value < 10)
                print("Speed Upgrade Level to : " + Speed.value);
            else
            {
                print("Speed Upgrade Level to Max");
                LevelMax[1].SetActive(true);
            }
        }
    }
    public void BusUpgradeSteer()
    {
        if (Steer.value < 10)
        {
            Steer.value += 1;
            PlayerPrefs.SetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Steer", (int)Steer.value);

            if (Steer.value < 10)
                print("Steer Upgrade Level to : " + Steer.value);
            else
            {
                print("Power Upgrade Level to Max");
                LevelMax[2].SetActive(true);
            }
        }
    }
}