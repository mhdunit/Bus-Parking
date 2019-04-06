using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticRewardedVideo : MonoBehaviour
{
    public bool IsSuccess;
    public GoogleAds GA;
    public TapSellUse TSU;
    void OnEnable()
    {
        if (IsSuccess)
        {
            if (!PlayerPrefs.HasKey("sucRewarded"))
                PlayerPrefs.SetInt("sucRewarded", 1);
            else
                PlayerPrefs.SetInt("sucRewarded", PlayerPrefs.GetInt("sucRewarded") + 1);

            if (PlayerPrefs.GetInt("sucRewarded") % 4 == 0)
            {
                if (GA.isActiveAndEnabled)
                    GA.ShowRewardedVideo();
                else
                    TSU.ShowTapSellVideo();
            }
        }
        else
        {
            if (GA.isActiveAndEnabled)
                GA.ShowRewardedVideo();
            else
                TSU.ShowTapSellVideo();
        }
        
    }
}
