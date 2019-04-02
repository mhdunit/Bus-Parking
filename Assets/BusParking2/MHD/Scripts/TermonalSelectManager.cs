using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TermonalSelectManager : MonoBehaviour
{
    public Transform Waypoint;
    public GameObject NextBtn;
    int TerminalIndexNumber;

    public void SetWaypointToTerminalLocation(GameObject TerminalLocationMap)
    {
        Waypoint.position = TerminalLocationMap.GetComponent<Transform>().position;
        if (gameObject.transform.GetChild(0).GetChild(TerminalIndexNumber).GetChild(1).gameObject.activeSelf)
            NextBtn.SetActive(false);
        else
            NextBtn.SetActive(true);

    }
    public void TerminalNumber(int Number)
    {
        TerminalIndexNumber = Number;
    }

}
