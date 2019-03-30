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
    public Color[] Colors;

    public GameObject[] ColorLock;

    int ColorPrice;

    public Text TotalScore, ItemScore,MainTotalScore;

    int totalScoreNumber;

    public GameObject BuyPanel,Descripton1,Descripton2;

	public VehicleType vehicleType;

    void Start()
    {
        totalScoreNumber = PlayerPrefs.GetInt("Coins");
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
                TotalScore.text = totalScoreNumber.ToString();
                ColorPrice = (PlayerPrefs.GetInt("BusID") * 10) + (id + 1) * 10;
                ItemScore.text = ColorPrice.ToString();
        // if total score is bigget than color price
        if (totalScoreNumber >= ColorPrice)
        {
            TotalScore.color = Color.green;
            Descripton1.SetActive(true);
            Descripton2.SetActive(false);
        }
        // if total score is smaller than color price
        else
        {
            TotalScore.color = Color.red;
            Descripton1.SetActive(false);
            Descripton2.SetActive(true);
        }

        BuyPanel.SetActive(true);
    }
    public void BuyOrWatchvideo()
    {
        // if total score is bigget than color price
        if (Descripton1.activeSelf)
        {
            totalScoreNumber -= ColorPrice;
            PlayerPrefs.SetInt("Coins", totalScoreNumber);
            MainTotalScore.text = totalScoreNumber.ToString();
           

        }
        // if total score is smaller than color price
        else
        {
            // Watch Video
            print("Watch Video");
        }
    }
    }
