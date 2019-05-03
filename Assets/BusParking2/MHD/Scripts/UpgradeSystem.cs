using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class UpgradeSystem : MonoBehaviour
{
    public Slider Power, Speed, Steer;
    public GameObject[] LevelMax;
    public Text [] LevelNumber;
    public Text TotalMain,TotalScore,UpgradeScore,Description;
    int TotalScoreNumber,UpgradeScoreNumber,UpgradeID;
    public AudioSource AS;
    public AudioClip GuiDef, GuiUpgrade;
    public TapSellUse TSU;
    public GoogleAds GA;


    void OnEnable()
    {
        TotalScoreNumber = PlayerPrefs.GetInt("Coins");

        TotalScore.text = TotalScoreNumber.ToString();


        // Power Level Checker
        Power.value = PlayerPrefs.GetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Power");
        if (Power.value == 10)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                LevelNumber[0].text = "Max";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                LevelNumber[0].text = "حداکثر".faConvert();

            LevelNumber[0].color = Color.green;
            LevelMax[0].SetActive(true);
        }
            
        else
        {
            LevelMax[0].SetActive(false);
            LevelNumber[0].color = Color.white;
            LevelNumber[0].text = Power.value.ToString();
        }

        // Speed Level Checker
        Speed.value = PlayerPrefs.GetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Speed");
        if (Speed.value == 10)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                LevelNumber[0].text = "Max";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                LevelNumber[0].text = "حداکثر".faConvert();
            LevelNumber[1].color = Color.green;
            LevelMax[1].SetActive(true);
        }
            
        else
        {
            LevelNumber[1].text = Speed.value.ToString();
            LevelNumber[1].color = Color.white;
            LevelMax[1].SetActive(false);
        }
            

        // Steer Level Checker
        Steer.value = PlayerPrefs.GetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Steer");
        if (Steer.value == 10)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                LevelNumber[0].text = "Max";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                LevelNumber[0].text = "حداکثر".faConvert();
            LevelNumber[2].color = Color.green;
            LevelMax[2].SetActive(true);
        }
            
        else
        {
            LevelNumber[2].text = Steer.value.ToString();
            LevelNumber[2].color = Color.white;
            LevelMax[2].SetActive(false);
        }
            

    }
    public void BusUpgradePower()
    {
        AS.PlayOneShot(GuiUpgrade);
        if (Power.value < 10)
        {
            Power.value += 1;
           
            PlayerPrefs.SetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Power", (int)Power.value);

            if (Power.value < 10)
                LevelNumber[0].text = Power.value.ToString();
            else
            {
                if (PlayerPrefs.GetString("Language") == "English")
                    LevelNumber[0].text = "Max";
                else if (PlayerPrefs.GetString("Language") == "Farsi")
                    LevelNumber[0].text = "حداکثر".faConvert();
                LevelNumber[0].color = Color.green;
                LevelMax[0].SetActive(true);
            }
        }
    }
    public void BusUpgradeSpeed()
    {
        AS.PlayOneShot(GuiUpgrade);
        if (Speed.value < 10)
        {
            Speed.value += 1;
            PlayerPrefs.SetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Speed", (int)Speed.value);

            if (Speed.value < 10)
                LevelNumber[1].text = Speed.value.ToString();
            else
            {
                if (PlayerPrefs.GetString("Language") == "English")
                    LevelNumber[0].text = "Max";
                else if (PlayerPrefs.GetString("Language") == "Farsi")
                    LevelNumber[0].text = "حداکثر".faConvert();
                LevelNumber[1].color = Color.green;
                LevelMax[1].SetActive(true);
            }
        }
    }
    public void BusUpgradeSteer()
    {
        AS.PlayOneShot(GuiUpgrade);
        if (Steer.value < 10)
        {
            Steer.value += 1;
            PlayerPrefs.SetInt("UpgradeBus" + PlayerPrefs.GetInt("BusID") + "Steer", (int)Steer.value);

            if (Steer.value < 10)
                LevelNumber[2].text = Steer.value.ToString();
            else
            {
                if (PlayerPrefs.GetString("Language") == "English")
                    LevelNumber[0].text = "Max";
                else if (PlayerPrefs.GetString("Language") == "Farsi")
                    LevelNumber[0].text = "حداکثر".faConvert();
                LevelNumber[2].color = Color.green;
                LevelMax[2].SetActive(true);
            }
        }
    }
    public void UpgradePrice(Slider Upgrade)
    {
        //Check for Which Upgrade ?
        if (Upgrade.name == "Power Scroolbar")
            UpgradeID = 0;
        else if (Upgrade.name == "Speed Scroolbar")
            UpgradeID = 1;
        else
            UpgradeID = 2;


        UpgradeScoreNumber = (PlayerPrefs.GetInt("BusID") * 3) + ((((int)Upgrade.value) + 1) * 5);
            UpgradeScore.text = UpgradeScoreNumber.ToString();
        TotalScoreNumber = PlayerPrefs.GetInt("Coins");
        if (TotalScoreNumber < UpgradeScoreNumber)
        {
            TotalScore.color = Color.red;
            if (PlayerPrefs.GetString("Language") == "English")
                Description.text = "No Enough Score Do You Want Some ?";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                Description.text = "امتیاز کافی نداری . امتیاز میخوای ؟".faConvert();
            
        }
        else
        {   
            TotalScore.color = Color.green;
            if (PlayerPrefs.GetString("Language") == "English")
                Description.text = "Do you want to buy this Upgrade?";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                Description.text = "آیا میخوای این ارتقا رو انجام بدی ؟".faConvert();
        }
           
    }
    public void UpgradeBuyYesOrNo()
    {

        if (TotalScoreNumber >= UpgradeScoreNumber)
        {
            TotalScoreNumber -= UpgradeScoreNumber;
            PlayerPrefs.SetInt("Coins", TotalScoreNumber);
            TotalMain.text = TotalScore.text = PlayerPrefs.GetInt("Coins").ToString();
            if (UpgradeID == 0)
                BusUpgradePower();
            else if (UpgradeID == 1)
                BusUpgradeSpeed();
            else
                BusUpgradeSteer();
            }
        else
        {
            // Watch Video
            if (GA.isActiveAndEnabled)
                GA.ShowRewardedVideo();
            else
                TSU.ShowTapSellVideo();

            AS.PlayOneShot(GuiDef);
        }
    }
}