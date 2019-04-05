//--------------------------------------------------------------
//
//                    Car Parking Kit
//          Writed by AliyerEdon in summer 2016
//           Contact me : aliyeredon@gmail.com
//
//--------------------------------------------------------------

// This script used for level Pause menu system   

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMen : MonoBehaviour
{
	[Header("Pause Menu Manager")]


	public GameObject PauseMenu,LoadingMenu;
	public Text  AllScore;

	public string garageName;

	public void Pause ()
	{
		PauseMenu.SetActive (true);
		AllScore.text = "Total Score is :   "+PlayerPrefs.GetInt ("Coins").ToString ();
		Time.timeScale = 0f;
	}

	public void Resume ()
	{
		PauseMenu.SetActive (false);
		Time.timeScale = 1f;
	}



	public void Retry ()
	{
        LoadingMenu.SetActive(true);
		PauseMenu.SetActive (false);
		Time.timeScale = 1f;
		SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);


	}

	public void Exit ()
	{
		Time.timeScale = 1f;
        LoadingMenu.SetActive(true);
		SceneManager.LoadSceneAsync(garageName);
    }


	public void SetFalse(GameObject target)
	{


		target.SetActive (false);
	}

	public void SetTrue(GameObject target)
	{

		target.SetActive (true);
	}

}
