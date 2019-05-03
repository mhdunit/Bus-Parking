using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TermonalSelectManager : MonoBehaviour
{
    public Transform Waypoint;
    public GameObject NextBtn,AvalableMessage;
    int TerminalIndexNumber;

    public void SetWaypointToTerminalLocation(GameObject TerminalLocationMap)
    {
        Waypoint.position = TerminalLocationMap.GetComponent<Transform>().position;
        if (gameObject.transform.GetChild(0).GetChild(TerminalIndexNumber).GetChild(1).gameObject.activeSelf)
        {
            NextBtn.SetActive(false);
            AvalableMessage.SetActive(true);
        }
            
        else
        {
            NextBtn.SetActive(true);
            AvalableMessage.SetActive(false);
        }
            

    }
    public void TerminalNumber(int Number)
    {
        TerminalIndexNumber = Number;
    }

}
