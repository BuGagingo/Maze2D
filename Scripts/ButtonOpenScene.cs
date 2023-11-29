using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonOpenScene : MonoBehaviour
{
    public bool SelectName;
    
    public string nameScene;

    public int sceneId;

    public void OpenScene()
    {
        if (SelectName)
            SceneManager.LoadScene(nameScene);
        else
            SceneManager.LoadScene(sceneId);
    }
}