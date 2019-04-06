using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTotalScoreFix : MonoBehaviour
{
    public Text totalMenuFix;

     void OnEnable()
    {
        if (gameObject.activeSelf)
        {
            totalMenuFix.text = PlayerPrefs.GetInt("Coins").ToString();
        }
    }

}
