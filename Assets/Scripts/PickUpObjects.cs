using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{

    //public float throwForce = 600.0f;

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;
    public bool carrying;
    public float range;
    

    // Use this for initialization
    void Start()
    {
        item.GetComponent<Rigidbody2D>().simulated = true;
        carrying = false;
    }
    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(item.transform.position, guide.position);
        if (carrying == false)
        {
            if (Input.GetKeyDown(KeyCode.E) && dist <= range)
            {
                pickup();
                carrying = true;
            }
        }
        else if (carrying == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                drop();
                carrying = false;
            }
        }
    }
    void pickup()
    {
        item.GetComponent<Rigidbody2D>().simulated = false;
        item.GetComponent<Rigidbody2D>().isKinematic = true;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
    }
    void drop()
    {
        item.GetComponent<Rigidbody2D>().simulated = true;
        item.GetComponent<Rigidbody2D>().isKinematic = false;
        item.transform.parent = null;
        item.transform.position = guide.transform.position;
    }

}