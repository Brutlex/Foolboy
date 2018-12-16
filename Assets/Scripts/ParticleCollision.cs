using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticleCollision : MonoBehaviour
{
    public ParticleSystem pSystem;
    public ParticleCollisionEvent[] CollisionEvents = new ParticleCollisionEvent[10];

    private void Start()
    {
        pSystem = GetComponent<ParticleSystem>();
    }

    public void OnParticleCollision(GameObject other)
    {

        //print("entered collision method");
        int collCount = pSystem.GetSafeCollisionEventSize();

        if(collCount < 0)
        {
            CollisionEvents = new ParticleCollisionEvent[collCount];
            //print("detected "+collCount+". collision");
        }

        int eventCount = pSystem.GetCollisionEvents(other, CollisionEvents);

        for(int i = 0; i < eventCount; i++)
        {
            if(other.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
