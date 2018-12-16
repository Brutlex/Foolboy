using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallController : MonoBehaviour
{
    public GameObject particleSystem;
    public bool activated;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("entered");
        if (collision.gameObject.tag == "Player")
        {
            activated = true;
            StartCoroutine(Spawner());
        }
    }

    public IEnumerator Spawner()
    {
        while (true)
        {
            if (activated)
            {
                //print("activated");
                particleSystem.SetActive(true);
                yield return new WaitForSeconds(4f);
                activated = false;
            }

            if (!activated)
            {
                //print("not activated");
                particleSystem.SetActive(false);
                yield return new WaitForSeconds(1f);
                activated = true;
            }
        }
    }
}
