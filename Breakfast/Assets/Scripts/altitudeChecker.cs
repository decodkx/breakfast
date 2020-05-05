using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altitudeChecker : MonoBehaviour
{
    Vector3 altitude;
    public GameObject player;
    walk walkScript;
    
    void Start()
    {
        player = GameObject.Find("Player");
        walkScript = player.GetComponent<walk>();
        altitude = new Vector3(0, 1.04f, 0f);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "N1")
        {
            Debug.Log("N1");
            altitude = new Vector3(0, 1.42f, 0.18f);
        }
        else if (col.tag == "N2")
        {
            altitude = new Vector3(0, 1.68f, 0.18f);
            Debug.Log("N2");
        }
        else if (col.tag == "N0")
        {
            altitude = new Vector3(0, 1.04f, -0.18f);
            Debug.Log("N0");
        }

        Do();
    }


    private void Do()
    {
        walkScript.Move(altitude);
        Destroy(gameObject);
    }
}
