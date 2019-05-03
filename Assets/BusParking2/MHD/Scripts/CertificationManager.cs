using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CertificationManager : MonoBehaviour
{
    public GameObject CertificationPanel, CertStamp;
    public Sprite CerStampEN, CerStampFA;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("BusLevelID") == 0)
            CertificationPanel.SetActive(true);

        if (PlayerPrefs.GetString("Language") == "English")
            CertStamp.GetComponent<Image>().sprite = CerStampEN;
        else
            CertStamp.GetComponent<Image>().sprite = CerStampFA;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
