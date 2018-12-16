using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallControllerMultiple : MonoBehaviour
{
    public GameObject particleSystem1;
    public GameObject particleSystem2;
    public GameObject particleSystem3;

    public float timeForParticles1Enabled;
    public float timeForParticles2Enabled;
    public float timeForParticles3Enabled;

    public float timeForParticles1Disabled;
    public float timeForParticles2Disabled;
    public float timeForParticles3Disabled;

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
                if (particleSystem1 != null || particleSystem2 !=null || particleSystem3 != null)
                {
                    particleSystem1.SetActive(true);
                    particleSystem2.SetActive(true);
                    particleSystem3.SetActive(true);

                    yield return new WaitForSeconds(timeForParticles1Enabled);
                    activated = false;
                }
                

            }

            if (!activated)
            {
                //print("not activated");
                if (particleSystem1 != null || particleSystem2 != null || particleSystem3 != null)
                {
                    particleSystem1.SetActive(false);
                    particleSystem2.SetActive(false);
                    particleSystem3.SetActive(false);
                    yield return new WaitForSeconds(timeForParticles1Disabled);
                    activated = true;
                }
                
            }
        }
    }
}
