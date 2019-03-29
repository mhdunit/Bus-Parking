using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingCameras : MonoBehaviour
{
    public Animator SwitchCamera;
    public AudioClip CameraMove, CameraMoveBack;
    public AudioSource AS;
    // Start is called before the first frame update


    public void SetDefaultCameraToColorCamera()
    {
        SwitchCamera.SetBool("Color Camera", true);
        AS.PlayOneShot(CameraMove);
    }
    public void SetColorCameraToDefaultCamera()
    {
        SwitchCamera.SetBool("Color Camera", false);
        AS.PlayOneShot(CameraMoveBack);

    }
    public void SetDefaultCameraToUpgradeCamera()
    {
        SwitchCamera.SetBool("Upgrade Camera", true);
        AS.PlayOneShot(CameraMove);
        AS.Play();
    }
    public void SetUpgradeCameraToDefaultCamera()
    {
        SwitchCamera.SetBool("Upgrade Camera", false);
        AS.PlayOneShot(CameraMoveBack);
    }
}
