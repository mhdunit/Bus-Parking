using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageChanger : MonoBehaviour
{
    public Text[] LanguageText;
    public string[] EN, FA;
    public Font English, Farsi;
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
                LanguageText[i].font = English;
                LanguageText[i].text = EN[i];
                LanguageText[i].fontStyle = FontStyle.Bold;
            }
        }
        else if (PlayerPrefs.GetString("Language") == "Farsi")
        {
            for (int i = 0; i < LanguageText.Length; i++)
            {
                LanguageText[i].font = Farsi;
                LanguageText[i].text = FA[i].faConvert();
                LanguageText[i].fontStyle = FontStyle.Normal;
            }
        }
    }
    void onLanguagechange()
    {
        if (PlayerPrefs.GetString("Language") == "English")
        {
            for (int i = 0; i < LanguageText.Length; i++)
            {
                LanguageText[i].font = English;
                LanguageText[i].text = EN[i];
                LanguageText[i].fontStyle = FontStyle.Bold;
            }
        }
        else if (PlayerPrefs.GetString("Language") == "Farsi")
        {
            for (int i = 0; i < LanguageText.Length; i++)
            {
                LanguageText[i].font = Farsi;
                LanguageText[i].text = FA[i].faConvert();
                LanguageText[i].fontStyle = FontStyle.Normal;
            }
        }
    }
}
