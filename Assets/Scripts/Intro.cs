using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour { 

public GameObject picture001;
    public GameObject picture002;
    public GameObject picture003; //= GameObject.Find("003");
    public GameObject picture004; //= GameObject.Find("004");
    public GameObject picture005; //= GameObject.Find("005");
    public GameObject picture006; //= GameObject.Find("006");
    public GameObject picture007; ///= GameObject.Find("007");
    public GameObject picture008; //= GameObject.Find("008");
    public GameObject picture009; //= GameObject.Find("009");
    public GameObject picture010; //= GameObject.Find("010");
    public GameObject picture011; //= GameObject.Find("011");
    public GameObject picture012; //= GameObject.Find("012");
public GameObject picture013; //= GameObject.Find("013");
    public GameObject picture014; //= GameObject.Find("014");
    public GameObject picture015; //= GameObject.Find("015");
    public GameObject picture016; ///= GameObject.Find("016");
public GameObject picture017; //= GameObject.Find("017");
    public GameObject picture018; //= GameObject.Find("019");
    public GameObject picture019; //= GameObject.Find("020");
    public GameObject picture020; //= GameObject.Find("021");
    public GameObject picture021; //= GameObject.Find("022");
public GameObject picture022 //= GameObject.Find("023");
public GameObject picture023 //= GameObject.Find("024");
public GameObject picture024 //= GameObject.Find("025");
public GameObject picture025 //= GameObject.Find("026");
public GameObject picture026 //= GameObject.Find("027");
public GameObject picture027 //= GameObject.Find("028");
public GameObject picture028 //= GameObject.Find("029");
public GameObject picture029 //= GameObject.Find("030");

    public GameObject[] pics = new GameObject[30];

    
 

    private void Start()
    {


        for (int i = 0; i < 30; i++)
        {
            if (i < 10)
            {
                string name = "picture00" + (i + 1).ToString();
            }
            else
            {
                string name = "picture0" + (i + 1).ToString();
            }
            GameObject.name.SetActive(false);
        }
    }

    private void Update()
    {
        
    }
}
