using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardedSound : MonoBehaviour
{
    // Start is called before the first frame update
    public Text totalCointText;
    public AudioSource AS;
    public AudioClip AC;
   public void RewardedAudio()
    {
        AS.PlayOneShot(AC);
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
        totalCointText.text = PlayerPrefs.GetInt("Coins").ToString();
    }
}
