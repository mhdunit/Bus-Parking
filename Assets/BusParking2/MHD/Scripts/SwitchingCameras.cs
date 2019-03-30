using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingCameras : MonoBehaviour
{
    public Animator SwitchCamera;
    public AudioClip CameraMove, CameraMoveBack;
    public AudioSource AS;
    // Start is called before the first frame update


    public void SetColorCamera()
    {
        SwitchCamera.SetTrigger("Color Camera");
        AS.PlayOneShot(CameraMove);
    }

    public void SetUpgradeCamera()
    {
        SwitchCamera.SetTrigger("Upgrade Camera");
        AS.PlayOneShot(CameraMove);
        AS.Play();
    }
    public void SetSettingCamera()
    {
        SwitchCamera.SetTrigger("Setting Camera");
        AS.PlayOneShot(CameraMove);
        AS.Play();
    }
    public void SetDefultCamera()
    {
        SwitchCamera.SetTrigger("Default Camera");
        AS.PlayOneShot(CameraMoveBack);

    }

}
