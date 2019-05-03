using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceLanguage : MonoBehaviour
{


    public enum Language
    {
        English,
        Farsi
    }

    public Language DefaultLanguage;


    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Language"))
        {
            if (DefaultLanguage == Language.English)
            {
                PlayerPrefs.SetString("Language", "English");
            }
            else if (DefaultLanguage == Language.Farsi)
            {
                PlayerPrefs.SetString("Language", "Farsi");
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
