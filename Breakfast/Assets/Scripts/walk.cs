using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    int v, h;
    int timer = 1000;
    public int timerDuration = 30;
    bool walkCooldown = false;
    void Start()
    {
        
    }

    void Update()
    {
         
        
        if(timer < 1000)
        {
            timer--;
            if(timer < 0)
            {
                walkCooldown = false;
                timer = 1000;
            }
        }


       if(!walkCooldown)
        {
            if (Input.GetKeyDown(KeyCode.W) && !sensor.north)
            {
                v = 1;
                Move();
            }
            if (Input.GetKeyDown(KeyCode.S) && !sensor.south)
            {
                v = -1;
                Move();
            }
            if (Input.GetKeyDown(KeyCode.A) && !sensor.west)
            {
                h = -1;
                Move();
            }
            if (Input.GetKeyDown(KeyCode.D) && !sensor.east)
            {
                h = 1;
                Move();
            }
        }
    }

    private void Move()
    {
        walkCooldown = true;
        timer = timerDuration;
        Vector3 steps = new Vector3(h, 0, v); 
        transform.position += steps;
        h = 0;
        v = 0;
    }
}
