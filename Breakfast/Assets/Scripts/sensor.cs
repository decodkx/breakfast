using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor : MonoBehaviour
{
    public static bool north= false;     // bools, when true, show if there are objects in the direction and block action if so
    public static bool south= false;
    public static bool east = false;
    public static bool west = false;

    bool dashOn;
    int ny, sy, wy, ey;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            dashOn = !dashOn;
            DashType();
        }
    }

    private void DashType()
    {
        Debug.Log("once?");
        switch (dashOn)
        {
            case true:
                transform.position = transform.position*2;
                break;
            case false:
                transform.position = transform.position/2;
                break;
        }
    }

    private void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Wall")
            switch (this.name)
            {
                case "Top":
                    north = true;
                    break;
                case "Bottom":
                    south = true;
                    break;
                case "Left":
                    west = true;
                    break;
                case "Right":
                    east = true;
                    break;
            }

    }

    private void OnTriggerExit (Collider col)
    {
        if (col.tag == "Wall")
        {
            switch (this.name)
            {
                case "Top":
                    north = false;
                    break;
                case "Bottom":
                    south = false;
                    break;
                case "Left":
                    west = false;
                    break;
                case "Right":
                    east = false;
                    break;
            }
        }
            
    }
}


