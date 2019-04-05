using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedSuccessRewardedVideo : MonoBehaviour
{
    public Text TotalScore;
    public AudioSource AS;
    public AudioClip RewardedAudio;
    //Reward For Rewarded Video

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetReward()
    {
        GetComponent<Animator>().SetTrigger("Set Reward Trigger");
    }
    public void RewardedAnimationFinished()
    {
        PlayerPrefs.SetInt("Coins", (PlayerPrefs.GetInt("Coins") + 1));
        TotalScore.text = "Total Scores is : " + PlayerPrefs.GetInt("Coins").ToString();
        AS.PlayOneShot(RewardedAudio);
    }
}
