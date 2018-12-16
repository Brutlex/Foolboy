using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void LoadByIndex(int sceneindex)
    {
        SceneManager.LoadScene(sceneindex);
        print("loaded");
    }

    public void LoadByname(string scenename)
    {
        SceneManager.LoadScene(scenename);
        print("loaded");
    }

}