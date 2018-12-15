using UnityEngine;
using System.Collections;

public class SpawnBalls : MonoBehaviour
{

    public GameObject ball;
    public Vector3 location;



    // public Vector3 position;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    public IEnumerator Spawner()
    {
        bool flag = true;
        while (flag)
        {

            for (int i = 0; i < 3; i++)
            {
                Instantiate(ball, new Vector3(+2.0F, -3, 0), Quaternion.identity);
            }
            yield return new WaitForSeconds(3f);
        }
    }


}