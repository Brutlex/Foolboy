﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallController : MonoBehaviour
{
    public GameObject particleSystem1;

    public float timeForParticles1Enabled;


    public float timeForParticles1Disabled;

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
                if (particleSystem1 != null)
                {
                    particleSystem1.SetActive(true);
                    yield return new WaitForSeconds(timeForParticles1Enabled);
                    activated = false;
                }
            }

            if (!activated)
            {
                //print("not activated");
                if (particleSystem1 != null)
                {
                    particleSystem1.SetActive(false);

                    yield return new WaitForSeconds(timeForParticles1Disabled);
                    activated = true;
                }
                
            }
        }
    }
}
