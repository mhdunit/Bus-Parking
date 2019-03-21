using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GarageCameraCinemachine : MonoBehaviour
{
    CinemachineFreeLook GarageFreeLookCamera;
    public int RotationSpeed;
    public int WaitingTimeRotate;
    bool isAxisXNag;

    // Start is called before the first frame update
    void Start()
    {
        GarageFreeLookCamera = GetComponent<CinemachineFreeLook>();
        isAxisXNag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GarageFreeLookCamera.m_XAxis.m_InputAxisValue != 0)
        {
            if (GarageFreeLookCamera.m_XAxis.m_InputAxisValue < 0)
                isAxisXNag = true;
            else
                isAxisXNag = false;

        }
        else if (GarageFreeLookCamera.m_XAxis.m_InputAxisValue == 0 && GarageFreeLookCamera.m_YAxis.m_InputAxisValue == 0)
        {
            if (GarageFreeLookCamera.m_YAxis.Value > 0.44 && GarageFreeLookCamera.m_YAxis.Value < 0.56)
            {
                if (isAxisXNag)
                {
                    GarageFreeLookCamera.m_XAxis.Value += -RotationSpeed * Time.deltaTime;
                }
                else
                {
                    GarageFreeLookCamera.m_XAxis.Value += RotationSpeed * Time.deltaTime;
                }
            }
           

        }

    }
}
