using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CD : MonoBehaviour
{
    public int Altitude { get; set; }
    public int Steps { get; set;}
    int place = 0;
    public int oldPlace = 0;
    public int energyfee = 0;
    public int Place //0 = ground, 1 = half step, 2 = upper level
    {
        get
        {
            return place;
        }
        set
        {
            place = value;
            if(Place - oldPlace == 1)
            {
                energyfee = 1;
            }
            else energyfee = 0;

            oldPlace = place;            
        }
    }
}
