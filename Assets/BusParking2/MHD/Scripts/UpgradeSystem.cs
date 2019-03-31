using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UpgradeSystem : MonoBehaviour
{
    int CurrntLevelNumber;
    public Scrollbar Power, Speed, Steer;
    public GameObject[] LevelMax;




    void Start()
    {

    }
    void OnEnable()
    {

        Power.size = PlayerPrefs.GetFloat("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Power");
        if (Power.size == 1)
            LevelMax[0].SetActive(true);
        else
            LevelMax[0].SetActive(false);

        Speed.size = PlayerPrefs.GetFloat("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Speed");
        if (Speed.size == 1)
            LevelMax[1].SetActive(true);
        else
            LevelMax[1].SetActive(false);


        Steer.size = PlayerPrefs.GetFloat("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Steer");
        if (Steer.size == 1)
            LevelMax[2].SetActive(true);
        else
            LevelMax[2].SetActive(false);

    }
    public void BusUpgradePower()
    {
        if (Power.size < 1)
        {
            Power.size += 0.1f;
            CurrntLevelNumber = (int)(Power.size * 10);
            PlayerPrefs.SetFloat("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Power", Power.size);

            if (CurrntLevelNumber < 10)
                print("Power Upgrade Level to : " + CurrntLevelNumber);
            else
            {
                print("Power Upgrade Level to Max");
                LevelMax[0].SetActive(true);
            }
        }
    }
    public void BusUpgradeSpeed()
    {
        if (Speed.size < 1)
        {
            Speed.size += 0.1f;
            CurrntLevelNumber = (int)(Speed.size * 10);
            PlayerPrefs.SetFloat("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Speed", Speed.size);

            if (CurrntLevelNumber < 10)
                print("Speed Upgrade Level to : " + CurrntLevelNumber);
            else
            {
                print("Speed Upgrade Level to Max");
                LevelMax[1].SetActive(true);
            }
        }
    }
    public void BusUpgradeSteer()
    {
        if (Steer.size < 1)
        {
            Steer.size += 0.1f;
            CurrntLevelNumber = (int)(Steer.size * 10);
            PlayerPrefs.SetFloat("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Steer", Steer.size);

            if (CurrntLevelNumber < 10)
                print("Steer Upgrade Level to : " + CurrntLevelNumber);
            else
            {
                print("Power Upgrade Level to Max");
                LevelMax[2].SetActive(true);
            }
        }
    }
}