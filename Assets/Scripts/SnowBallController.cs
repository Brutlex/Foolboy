using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallController : MonoBehaviour
{
    public GameObject particleSystem1;
    public GameObject particleSystem2;
    public GameObject particleSystem3;
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
                if(particleSystem1 != null && particleSystem2 != null  &&  particleSystem3 != null )
                {
                    particleSystem1.SetActive(true);
                    //yield return new WaitForSeconds(2f);
                    particleSystem2.SetActive(true);
                    //yield return new WaitForSeconds(2f);
                    particleSystem3.SetActive(true);
                    yield return new WaitForSeconds(2f);

                    activated = false;
                }

                /*if ()
                {
                    ;
                    activated = false;
                }

                if ()
                {
                    
                    activated = false;
                }*/
                
                //activated = false;
            }

            if (!activated)
            {
                
                //particleSystem1.SetActive(false);
                //yield return new WaitForSeconds(2f);

                if (particleSystem1 != null && particleSystem2 != null  &&  particleSystem3 != null )
                {
                    particleSystem1.SetActive(false);
                    //yield return new WaitForSeconds(2f);
                    particleSystem2.SetActive(false);
                    //yield return new WaitForSeconds(2f);
                    particleSystem3.SetActive(false);
                    yield return new WaitForSeconds(2f);

                    activated = true;
                }

                /*if ()
                {
                    
                    activated = true;
                }

                if ()
                {
                    particleSystem3.SetActive(false);
                    yield return new WaitForSeconds(2f);
                    activated = true;
                }*/
                //activated = true;
            }
        }
    }
}
