//--------------------------------------------------------------
//
//                    Car Parking Kit
//          Writed by AliyerEdon in summer 2016
//           Contact me : aliyeredon@gmail.com
//
//--------------------------------------------------------------

// This script used for game settings menu

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Settings : MonoBehaviour
{

	// Use this for initialization
	public Toggle AmbientSound, SunShaft,ColorEffects;

	// States info text
	public Text resolutionState,qualityState;

    public GameObject Camera;


	void Start ()
	{

		// Read starting setting values
		if (PlayerPrefs.GetInt ("AmbientSound") == 3)
			AmbientSound.isOn = true;
		else
			AmbientSound.isOn = false;
		
		if (PlayerPrefs.GetInt ("SunShaft") == 3)
			SunShaft.isOn = true;
		else
			SunShaft.isOn = false;


		if (PlayerPrefs.GetInt ("ColorEffects") == 3)
        {
            ColorEffects.isOn = true;
        }		
		else
        {
            ColorEffects.isOn = false;
        }
			


        if (PlayerPrefs.GetInt("Quality") == 0)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Fastest";
           else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خیلی سریع".faConvert();

            qualityState.color = Color.red;
        }
		if (PlayerPrefs.GetInt ("Quality") == 3)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Good";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خوب".faConvert();
            qualityState.color = new Color(0, 192, 255, 152);
        }
			
		if (PlayerPrefs.GetInt ("Quality") == 5)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Fantastic";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خارق العاده".faConvert();
            qualityState.color = Color.green;
        }
			

		if (PlayerPrefs.GetInt ("Resolution") == 0) {
			PlayerPrefs.SetInt ("Resolution", 720);
			resolutionState.text = "720";
            resolutionState.color = new Color(0, 192, 255, 152);

        } else {
			if (PlayerPrefs.GetInt ("Resolution") == 506)
            {
                resolutionState.text = "506";
                resolutionState.color = Color.red;
            }
            if (PlayerPrefs.GetInt ("Resolution") == 720)
            {
                resolutionState.text = "720";
                resolutionState.color = new Color(0, 192, 255, 152);
            }
				
			if (PlayerPrefs.GetInt ("Resolution") == 1080)
            {
                resolutionState.text = "1080";
                resolutionState.color = Color.green;
            }
				
		}
	}

	
	// Public function for ambient sound toggle
	public void Set_AmbientSound ()
	{
		StartCoroutine (AmbiantSound_Save ());
	}

	public void Set_SunShaft ()
	{
		StartCoroutine (SunShaft_Save ());
	}


	public void Set_ColorEffects ()
	{
		StartCoroutine (ColorEffects_Save ());
	}
	public void SetQualityLevel (int id)
	{
		PlayerPrefs.SetInt ("Quality", id);
		QualitySettings.SetQualityLevel (id, false);

		if (id == 0)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Fastest";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خیلی سریع".faConvert();
            qualityState.color = Color.red;
        }
			
        if (id == 3)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Good";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خوب".faConvert();
            qualityState.color = new Color(0, 192, 255, 152);
        }
			
		if (id == 5)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Fantastic";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خارق العاده".faConvert();
            qualityState.color = Color.green;
        }
			
	}


	public void SetResolution (int id)
	{
		PlayerPrefs.SetInt ("Resolution", id);

		if (id == 506)
        {
            resolutionState.text = "506";
            resolutionState.color = Color.red;
        }
			
		if (id == 720)
        {
            resolutionState.text = "720P";
            resolutionState.color = new Color(0, 192, 255, 152);
        }
			
		if (id == 1080)
        {
            resolutionState.text = "1080P";
            resolutionState.color = Color.green;
        }
			
	}
	IEnumerator AmbiantSound_Save ()
	{
		yield return new WaitForSeconds (.3f);
		if (AmbientSound.isOn)
        {
            PlayerPrefs.SetInt("AmbientSound", 3);  //3 = true;
            
        }

        else
        {
            PlayerPrefs.SetInt("AmbientSound", 0);//0 = false;
            
        }
			
	}
	IEnumerator ColorEffects_Save ()
	{
		yield return new WaitForSeconds (.3f);
		if (ColorEffects.isOn)
        {
            PlayerPrefs.SetInt("ColorEffects", 3);  //3 = true;
            Camera.GetComponent<MobileColorGrading>().enabled = true;
        }			
        else
        {
            PlayerPrefs.SetInt("ColorEffects", 0);//0 = false;
            Camera.GetComponent<MobileColorGrading>().enabled = false;
        }
		
    }
    public void SetQualityText()
    {
        if (PlayerPrefs.GetInt("Quality") == 0)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Fastest";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خیلی سریع".faConvert();

            qualityState.color = Color.red;
        }
        if (PlayerPrefs.GetInt("Quality") == 3)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Good";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خوب".faConvert();
            qualityState.color = new Color(0, 192, 255, 152);
        }

        if (PlayerPrefs.GetInt("Quality") == 5)
        {
            if (PlayerPrefs.GetString("Language") == "English")
                qualityState.text = "Fantastic";
            else if (PlayerPrefs.GetString("Language") == "Farsi")
                qualityState.text = "خارق العاده".faConvert();
            qualityState.color = Color.green;
        }
    }

    IEnumerator SunShaft_Save ()
	{
		yield return new WaitForSeconds (.3f);
		if (SunShaft.isOn)
			PlayerPrefs.SetInt ("SunShaft", 3);  //3 = true;
		else
			PlayerPrefs.SetInt ("SunShaft", 0);//0 = false;
	}





}
