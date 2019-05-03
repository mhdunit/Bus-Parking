using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceLanguage : MonoBehaviour
{

    public enum language
    {
        English,
        Farsi
    }

    public language DefaultLanguage;

    // Start is called before the first frame update
    void Awake()
    {
        if (!PlayerPrefs.HasKey("Language"))
        {
            if (DefaultLanguage == language.English)
            {
                PlayerPrefs.SetString("Language", "English");
            }
            else if (DefaultLanguage == language.Farsi)
            {
                PlayerPrefs.SetString("Language", "Farsi");
            }
        }
       
    }
    
    // Update is called once per frame
}
