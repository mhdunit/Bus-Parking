using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{
    public string SceneName;

    void Start()
    {
        SceneManager.LoadSceneAsync(SceneName);
    }
    // Start is called before the first frame update

}
