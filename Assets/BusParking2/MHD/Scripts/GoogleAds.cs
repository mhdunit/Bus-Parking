﻿using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoogleAds : MonoBehaviour {

    public Animator RewardedAnim;
    public GameObject Win, Lose;
    BannerView bannerView;
    InterstitialAd interstitialAd;
    public RewardBasedVideoAd rewardBasedVideo;
    public object IronSourceEvents { get; private set; }
    // Use this for initialization

    void OnDestroy()
    {
     //   bannerView.Destroy();
    }
    private void OnEnable()
    {
        
      //  RequestBanner();
    }
    void Start () {
        rewardBasedVideo = RewardBasedVideoAd.Instance;
        //event
        rewardBasedVideo.OnAdLoaded += HandleOnAdLoaded;
        rewardBasedVideo.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        rewardBasedVideo.OnAdOpening += HandleOnAdOpening;
        rewardBasedVideo.OnAdStarted += HandleOnAdStarted;
        rewardBasedVideo.OnAdClosed += HandleOnAdClosed;
        rewardBasedVideo.OnAdRewarded += HandleOnAdRewarded;
        rewardBasedVideo.OnAdLeavingApplication += HandleOnAdLeavingApplication;
        //end event


        if (Application.loadedLevelName == "Garage_Bus")
        {
            RequestRewardBasedVideo();
        }
        else
        {
            RequestInterstitial();
            RequestRewardBasedVideo();
        }

        


    }

    // Update is called once per frame
    void Update () {

    }
    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1957678521576263/6833331778";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-1957678521576263/9211536031";
#else
        string adUnitId ="unexpected_platform";
#endif


            //Create a smart banner at the top of the screen.
            bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        //Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        //Load the banner with the request.
        bannerView.LoadAd(request);


    }
    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1957678521576263/5988824475";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-1957678521576263/1481604233";
#else
        string adUnitId ="unexpected_platform";
#endif
        //Create a 320X50 banner at the top of the screen.
        interstitialAd = new InterstitialAd(adUnitId);
        //Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        //Load the banner with the request.
        interstitialAd.LoadAd(request);
    }
    public void ShowInterstitial()
    {
        if (interstitialAd.IsLoaded())
        {
            interstitialAd.Show();
        }
    }
    public void RequestRewardBasedVideo()
    {

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1957678521576263/6141415521";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-1957678521576263/7060455960";
#else
        string adUnitId = "unexpected_platform";
#endif

        rewardBasedVideo = RewardBasedVideoAd.Instance;

        AdRequest request = new AdRequest.Builder().Build();
        rewardBasedVideo.LoadAd(request, adUnitId);
    }
    public void ShowRewardedVideo()
    {
        if (rewardBasedVideo.IsLoaded())
        {
            rewardBasedVideo.Show();
            print("ShowGoogleRewardedVideo");
        }
    }
    //Handle 
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {

    }
    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        RequestRewardBasedVideo();
    }
    public void HandleOnAdOpening(object sender, EventArgs args)
    {

    }
    public void HandleOnAdStarted(object sender, EventArgs args)
    {

    }
    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        RequestRewardBasedVideo();
    }
    public void HandleOnAdRewarded(object sender, EventArgs args)
    {
        
            RewardedAnim.SetTrigger("Set Reward Trigger");
            RequestRewardBasedVideo();
       
    }
    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {

    }
}
