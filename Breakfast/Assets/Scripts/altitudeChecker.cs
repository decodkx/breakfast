using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altitudeChecker : MonoBehaviour
{
    float altitude;
    public GameObject player;
    walk walkScript;
    
    void Start()
    {
        player = GameObject.Find("Player");
        walkScript = player.GetComponent<walk>();
        altitude = 1.04f;
    }

    private void OnTriggerEnter(Collider col)
    {   
        if(col.tag == "N1")
        {
            Debug.Log("N1");
            altitude = 1.42f;
        }
        else if (col.tag == "N2")
        {
            Debug.Log("N2");
            altitude = 1.68f;
        }
        else if (col.tag == "N0")
        {
            altitude = 1.04f;
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
