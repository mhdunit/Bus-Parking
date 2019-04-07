using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RewardedSound : MonoBehaviour
{
    // Start is called before the first frame update
    public Text totalCointText;
    public AudioSource AS;
    public AudioClip AC;
    public GameObject[] Stars;
    int AwardedCoins;

    void OnEnable()
    {
        {
            if (Application.loadedLevelName == "Day_Bus")
            {
                for (int i = 0; i < Stars.Length; i++)
                {
                    if (Stars[i].activeSelf)
                    {
                        AwardedCoins = i + 1;
                    }
                }
            }
        }
    }

    public void RewardedAudioAndScore()
    {
        AS.PlayOneShot(AC);

        if (Application.loadedLevelName == "Garage_Bus")
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            totalCointText.text = PlayerPrefs.GetInt("Coins").ToString();
        }
           
        else
        {
            AwardedCoins++;
            totalCointText.text = "Awarded Coins : " + AwardedCoins;
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
        }
            

    }
}
