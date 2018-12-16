using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLever : MonoBehaviour
{
    public GameObject audio_switch;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audio_switch.SetActive(true);
            print("load scene");
            SceneManager.LoadScene(3);

        }
    }
}
