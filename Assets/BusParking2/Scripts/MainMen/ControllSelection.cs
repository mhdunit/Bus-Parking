using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllSelection : MonoBehaviour {

    public GameObject[] GameobjectControlType;
    public Sprite[] ControlTypeOn, ControlTypeOff;

    void OnEnable()
    {
        switch (PlayerPrefs.GetInt("Controll"))
        {
            case 0:
                GameobjectControlType[0].GetComponent<Image>().sprite = ControlTypeOn[0];
                GameobjectControlType[1].GetComponent<Image>().sprite = ControlTypeOff[1];
                GameobjectControlType[2].GetComponent<Image>().sprite = ControlTypeOff[2];
                break;
            case 1:
                GameobjectControlType[0].GetComponent<Image>().sprite = ControlTypeOff[0];
                GameobjectControlType[1].GetComponent<Image>().sprite = ControlTypeOn[1];
                GameobjectControlType[2].GetComponent<Image>().sprite = ControlTypeOff[2];
                break;
            case 2:
                GameobjectControlType[0].GetComponent<Image>().sprite = ControlTypeOff[0];
                GameobjectControlType[1].GetComponent<Image>().sprite = ControlTypeOff[1];
                GameobjectControlType[2].GetComponent<Image>().sprite = ControlTypeOn[2];
                break;
        }
    }

    public void SelectControl (int id) 
	{
		PlayerPrefs.SetInt ("Controll", id);
        GameobjectControlType[id].GetComponent<Image>().sprite = ControlTypeOn[id];
        switch (id)
        {
            case 0:
                GameobjectControlType[1].GetComponent<Image>().sprite = ControlTypeOff[1];
                GameobjectControlType[2].GetComponent<Image>().sprite = ControlTypeOff[2];
                break;
            case 1:
                GameobjectControlType[0].GetComponent<Image>().sprite = ControlTypeOff[0];
                GameobjectControlType[2].GetComponent<Image>().sprite = ControlTypeOff[2];
                break;
            case 2:
                GameobjectControlType[0].GetComponent<Image>().sprite = ControlTypeOff[0];
                GameobjectControlType[1].GetComponent<Image>().sprite = ControlTypeOff[1];
                break;
        }
            
       
	}



}
