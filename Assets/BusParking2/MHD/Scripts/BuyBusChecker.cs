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
    public GameObject BuyBtn,falseColor,falseUpgrade;


    public void BuyBusMenu()
    {
        TotalScore = PlayerPrefs.GetInt("Coins");
        BusScore = int.Parse(BusScoreMainText.text);
        BusScoreBuyText.text = BusScoreMainText.text;
        TotalScoreBuyText.text = PlayerPrefs.GetInt("Coins").ToString();
        if (TotalScore >= BusScore)
        {
            TotalScoreBuyText.color = Color.green;
            Description.text = "Do you want to buy this Bus ?";
        }
        else
        {
            TotalScoreBuyText.color = Color.red;
            Description.text = "No Enough Score \n Do You Want Some ?";
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
            print("Watch video");
            AS.PlayOneShot(GuiDef);
        }
    }
    IEnumerator FalseColorAndUpgradeBtn()
    {
        yield return new WaitForSeconds(2);
        falseColor.SetActive(false);
        falseUpgrade.SetActive(false);
    }
}
