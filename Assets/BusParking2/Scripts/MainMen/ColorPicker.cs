//--------------------------------------------------------------
//
//                    Car Parking Kit
//          Writed by AliyerEdon in summer 2016
//           Contact me : aliyeredon@gmail.com
//
//--------------------------------------------------------------

// This script used for color picking system in game menu(garage)

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorPicker : MonoBehaviour {

    // List of the colors
    int ColorId;

    public Color[] Colors;

    public GameObject[] ColorLock;

    int ColorPrice;

    public Text TotalScore, ItemScore, MainTotalScore, Descripton;

    int totalScoreNumber;

    public GameObject BuyPanel;

    public AudioSource AS;
    public AudioClip GuiPaint, GuiDef;

	public VehicleType vehicleType;

    public TapSellUse TSU;

    public GoogleAds GA;
    void OnEnable()
    {
        totalScoreNumber = PlayerPrefs.GetInt("Coins");

        for (int i = 1; i < ColorLock.Length; i++)
        {
            if (PlayerPrefs.GetInt("Bus" + PlayerPrefs.GetInt("BusID") + "Color" + i) == 3)
                ColorLock[i].SetActive(false);
            else
                ColorLock[i].SetActive(true);

        }
    }
    // Public function for changing color buttons
    public void SetColor (int id)
	{
		if (vehicleType == VehicleType.Car) {
			PlayerPrefs.SetInt ("CarColor" + PlayerPrefs.GetInt ("CarID").ToString (), id);
		}
		if (vehicleType == VehicleType.Bus) {
			PlayerPrefs.SetInt ("BusColor" + PlayerPrefs.GetInt ("BusID").ToString (), id);
		}

		if (vehicleType == VehicleType.Truck) {
			PlayerPrefs.SetInt ("TruckColor" + PlayerPrefs.GetInt ("TruckID").ToString (), id);
		}
 			GameObject.FindGameObjectWithTag ("Player").GetComponentInChildren<ColorLoader>().mat.color = Colors [id];

	}
    public void BuyColor(int id)
    {
                ColorId = id;
                TotalScore.text = totalScoreNumber.ToString();
                ColorPrice = (PlayerPrefs.GetInt("BusID") * 10) + (id + 1) * 10;
                ItemScore.text = ColorPrice.ToString();
        // if total score is bigget than color price
        if (totalScoreNumber >= ColorPrice)
        {
            TotalScore.color = Color.green;
            Descripton.text = "Do you want to buy this Color ?";
        }
        // if total score is smaller than color price
        else
        {
            TotalScore.color = Color.red;
            Descripton.text = "No Enough Score \n Do You Want Some ?";
        }

        BuyPanel.SetActive(true);
    }
    public void BuyOrWatchvideo()
    {
        // if total score is bigget than color price
        if (totalScoreNumber >= ColorPrice)
        {
            totalScoreNumber -= ColorPrice;
            PlayerPrefs.SetInt("Coins", totalScoreNumber);
            MainTotalScore.text = totalScoreNumber.ToString();
            ColorLock[ColorId].SetActive(false);
            PlayerPrefs.SetInt("Bus" + PlayerPrefs.GetInt("BusID") + "Color"+ColorId, 3);
            SetColor(ColorId);
            AS.PlayOneShot(GuiPaint);

        }
        // if total score is smaller than color price
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
