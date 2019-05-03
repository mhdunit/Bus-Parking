using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    public Text English, Farsi;

    void Start()
    {
        if (PlayerPrefs.GetString("Language") == "English")
        {
            English.color = Color.green;
            Farsi.color = Color.white;
        }
        else if (PlayerPrefs.GetString("Language") == "Farsi")
        {
            English.color = Color.white;
            Farsi.color = Color.green;
        }
    }
    public void EnglishSelected()
    {
        English.color = Color.green;
        Farsi.color = Color.white;
        PlayerPrefs.SetString("Language","English");
    }
    public void FarsiSelected()
    {
        English.color = Color.white;
        Farsi.color = Color.green;
        PlayerPrefs.SetString("Language", "Farsi");
    }
}
