using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor : MonoBehaviour
{
    public static bool north= false;     // bools, quando verdadeiros, mostram objetos na direção e impedem movimento
    public static bool south= false;
    public static bool east = false;
    public static bool west = false;

    int ny, sy, wy, ey;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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


