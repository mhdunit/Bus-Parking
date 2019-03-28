﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixNexPrevButton : MonoBehaviour
{
    public CarSelect CS;
    public GameObject Next, Prev;
    public int EnableDisableButtonTime;
    public Image BusTitleImage;
    public Sprite[] BusTitle;
    
    // Start is called before the first frame update
    void Start()
    {
        BusNextPrevCheck();
    }
    void BusNextPrevCheck()
    {
        BusTitleImage.sprite = BusTitle[PlayerPrefs.GetInt("BusID")];
        if (CS.cars.Length - 1 == PlayerPrefs.GetInt("BusID"))
            Next.SetActive(false);
        else
            Next.SetActive(true);

        if (PlayerPrefs.GetInt("BusID") == 0)
            Prev.SetActive(false);
        else
            Prev.SetActive(true);
    }
    public void SetTrueFalse()
    {
        BusNextPrevCheck();
        StartCoroutine(SetTrueFalseAfter1Minute());  
    }
    IEnumerator SetTrueFalseAfter1Minute()
    {

        Next.GetComponent<Button>().enabled = false;
        Prev.GetComponent<Button>().enabled = false;
        yield return new WaitForSeconds(EnableDisableButtonTime);
        Next.GetComponent<Button>().enabled = true;
        Prev.GetComponent<Button>().enabled = true;

    }
 
}
