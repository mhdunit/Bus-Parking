using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageChanger : MonoBehaviour
{
    public Text[] LanguageText;
    public string[] EN, FA;
    // Start is called before the first frame update

    void OnEnable()
    {
        Language.onLanguageChange += onLanguagechange;
    }
    void OnDisable()
    {
        Language.onLanguageChange -= onLanguagechange;
    }

    void Start()
    {
        if (PlayerPrefs.GetString("Language") == "English")
        {
            for (int i = 0; i < LanguageText.Length; i++)
            {
                LanguageText[i].text = EN[i];
            }
        }
        else if (PlayerPrefs.GetString("Language") == "Farsi")
        {
            for (int i = 0; i < LanguageText.Length; i++)
            {
                LanguageText[i].text = FA[i];
            }
        }
    }
    void onLanguagechange()
    {
        if (PlayerPrefs.GetString("Language") == "English")
        {
            for (int i = 0; i < LanguageText.Length; i++)
            {
                LanguageText[i].text = EN[i];
            }
        }
        else if (PlayerPrefs.GetString("Language") == "Farsi")
        {
            for (int i = 0; i < LanguageText.Length; i++)
            {
                LanguageText[i].text = FA[i];
            }
        }
    }
}
