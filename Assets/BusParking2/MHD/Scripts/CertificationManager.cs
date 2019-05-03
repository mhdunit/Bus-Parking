using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CertificationManager : MonoBehaviour
{
    public GameObject CertificationPanel, CertStamp;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("BusLevelID") == 0)
            CertificationPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
