using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altitudeChecker : MonoBehaviour
{
    float altitude;
    public GameObject player;
    walk walkScript;
    bool lockV = false;
    
    void Start()
    {
        player = GameObject.Find("Player");
        walkScript = player.GetComponent<walk>();
        altitude = 1.04f;
    }

    private void OnTriggerEnter(Collider col)
    {
        //if(!lockV)
        //{
        if (col.tag == "N0")
        {
            altitude = 1.04f;
            Do();
            Debug.Log(col.tag);
            lockV = true;
        }

        else if (col.tag == "N2")
            {
                altitude = 1.68f;
                Do();
                Debug.Log(col.tag);
                lockV = true;
            }
            else if (col.tag == "N1")
            {
                altitude = 1.42f;
                Do();
                Debug.Log(col.tag);
                lockV = true;
            }
            if (col.tag == "DN1")
            {
                altitude = 1.42f;
                Do();
                Debug.Log(col.tag);
                lockV = true;
            }


            Do();
        //}
    }


    private void Do()
    {
        walkScript.Move(altitude);
        Destroy(gameObject);        
    }
}
