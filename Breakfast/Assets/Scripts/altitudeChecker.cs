using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altitudeChecker : MonoBehaviour
{
    public CD m;
    float altitude;
    walk walkScript;
    int timer = 5;
    
    void Start()
    {
        m = GameObject.FindGameObjectWithTag("GM").GetComponent<CD>();
        walkScript = GameObject.Find("Player").GetComponent<walk>(); 
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "N1")
        {
            altitude = 1.42f;
            m.Place = 1;
            Do();
        }
        else if (col.tag == "N2")
        {
            altitude = 1.68f;
            m.Place = 2;
            Do();
        }
    }
    void Update()
    {
        if (timer < 1000)
        {
            timer--;
            if (timer < 0)
            {
                altitude = 1.04f;
                m.Place = 0;
                Do();
            }
        }
    }

    private void Do()
    {
        walkScript.Move(altitude);
                
        
        Destroy(gameObject);
    }
}
