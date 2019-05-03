using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBusChecker : MonoBehaviour
{

    public Text TotalScoreMainText, TotalScoreBuyText, BusScoreMainText,BusScoreBuyText,Description;
    int TotalScore, BusScore;
    public AudioSource AS;
    public AudioClip GuiBus, GuiDef;
    public GameObject BuyBtn,falseColor,falseUpgrade,BusLockIcon;
    public GoogleAds GA;
    public TapSellUse TSU;


    public void BuyBusMenu()
    {
        TotalScore = PlayerPrefs.GetInt("Coins");
        BusScore = int.Parse(BusScoreMainText.text);
        BusScoreBuyText.text = BusScoreMainText.text;
        TotalScoreBuyText.text = PlayerPrefs.GetInt("Coins").ToString();
        if (TotalScore >= BusScore)
        {
            TotalScoreBuyText.color = Color.green;
            if (PlayerPrefs.GetString("Language") == "English")
                Description.text = "Do you want to buy this Bus ?";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                Description.text = "آیا میخوای این اتوبوس رو بخری ؟".faConvert();
        }
        else
        {
            TotalScoreBuyText.color = Color.red;
            if (PlayerPrefs.GetString("Language") == "English")
                Description.text = "No Enough Score . Do You Want Some ?";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                Description.text = "امتیاز کافی نداری . امتیاز میخوای ؟".faConvert();
        }
    }
    public void BusByeOrNot()
    {
        if (TotalScore >= BusScore)
        {
            PlayerPrefs.SetInt("Bus" + PlayerPrefs.GetInt("BusID"), 3);
            BuyBtn.SetActive(false);
            TotalScore -= BusScore;
            PlayerPrefs.SetInt("Coins", TotalScore);
            TotalScoreMainText.text = TotalScoreBuyText.text = PlayerPrefs.GetInt("Coins").ToString();
            AS.PlayOneShot(GuiBus);
            StartCoroutine(FalseColorAndUpgradeBtn());
        }
        else
        {
            if (GA.isActiveAndEnabled)
                GA.ShowRewardedVideo();
            else
                TSU.ShowTapSellVideo();

            AS.PlayOneShot(GuiDef);
        }
    }
    IEnumerator FalseColorAndUpgradeBtn()
    {
        yield return new WaitForSeconds(2);
        falseColor.SetActive(false);
        falseUpgrade.SetActive(false);
        BusLockIcon.SetActive(false);
    }
}
