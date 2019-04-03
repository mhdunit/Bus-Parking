﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("ColorEffects") == 3)
            GetComponent<MobileColorGrading>().enabled = true;
        else
            GetComponent<MobileColorGrading>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
