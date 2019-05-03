//--------------------------------------------------------------
//
//                    Car Parking Kit
//          Writed by AliyerEdon in summer 2016
//           Contact me : aliyeredon@gmail.com
//
//--------------------------------------------------------------

// This script used for success menu buttons

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Success : MonoBehaviour
{
    [Header("Success Menu Manager")]

    //// Loading text for "Loading..."
    //public Text LoadingTXT;
    public GameObject LoadingMenu;

    // Parking Manager handler
    [HideInInspector] public ParkingManager manager;

    public string garageName;

    public VehicleType vehicleType;

    public Text totalScoreSuccess, totalScorefailed;
    public GoogleAds GA;
    public TapSellUse TSU;


    // Activate parking place helper
    public void ActiveHelper()
    {
        manager.Helper.SetActive(!manager.Helper.activeSelf);
    }


    public IEnumerator Start()
    {

        // Delay and find manager
        yield return new WaitForSeconds(.3f);
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<ParkingManager>();
        if (PlayerPrefs.GetString("Language") == "English")
        {
            totalScoreSuccess.text = "Awarded Coins : " + PlayerPrefs.GetInt("Coins").ToString();

            totalScorefailed.text = "Total Scores is : " + PlayerPrefs.GetInt("Coins").ToString();

        }else if (PlayerPrefs.GetString("Language") == "Farsi")
        {
            totalScoreSuccess.text = "  :  سکه جایزه".faConvert() + PlayerPrefs.GetInt("Coins").ToString();

            totalScorefailed.text = "  :  امتیاز کلی شما".faConvert() + PlayerPrefs.GetInt("Coins").ToString();
        }


    }

    // SuccessMenu continue button
    public void Continue()
    {


        if (vehicleType == VehicleType.Bus)
        {
            if (PlayerPrefs.GetInt("BusLevelID") != 35)
            {
                LoadingMenu.SetActive(true);
                PlayerPrefs.SetInt("BusLevelID", PlayerPrefs.GetInt("BusLevelID") + 1);
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
            }
            else
            {
                GetComponent<CertificationManager>().CertificationPanel.SetActive(true);
                GetComponent<CertificationManager>().CertStamp.SetActive(true);
            }

        }
        //if (vehicleType == VehicleType.Truck)
        //    PlayerPrefs.SetInt("TruckLevelID", PlayerPrefs.GetInt("TruckLevelID") + 1);
        //if (vehicleType == VehicleType.Car)
        //    PlayerPrefs.SetInt("CarLevelID", PlayerPrefs.GetInt("CarLevelID") + 1);


    }


    // SuccessMenu retry button
    public void Retry()
    {
        LoadingMenu.SetActive(true);
        SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().name   );
    }


    //SuccessMenu exit button    
    public void Exit()
    {
        LoadingMenu.SetActive(true);
        SceneManager.LoadSceneAsync (garageName);
    }


    public void showRewardedVideoBasedOnAdsChecker()
    {
        if (GA.isActiveAndEnabled)
            GA.ShowRewardedVideo();
        else
            TSU.ShowTapSellVideo();
    }
   public void CloseCertification()
    {
        if (PlayerPrefs.GetInt("BusLevelID") == 0)
        {
            GetComponent<CertificationManager>().CertificationPanel.SetActive(false);
        }
        else
        {
            GetComponent<CertificationManager>().CertificationPanel.SetActive(false);
            LoadingMenu.SetActive(true);
            SceneManager.LoadSceneAsync(garageName);
        }
    }
}
