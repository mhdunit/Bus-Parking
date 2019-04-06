using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public enum Ads
    {
        googleAds,
        tapsell
    }

    public Ads adsController;
    void Start()
    {
        if (adsController == Ads.googleAds)
        {
            GetComponent<GoogleAds>().enabled = true;
        }
        else
        {
            GetComponent<TapSellUse>().enabled = true;
        }
    }
}
