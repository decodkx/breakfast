using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class walk : MonoBehaviour
{
    int v, h;                       //horizontal and vertical movements
    int timer = 1000;
    public int timerDuration = 30;  // duration of wait between movements
    bool walkCooldown = false;

    public static int energy =7;                    // quantity of spaces a player can move
    public Text energyIndicator;
    void Start()
    {
        
    }

    void Update()
    {
        energyIndicator.text = energy.ToString();
        
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
        if(energy > 0)
        {
            walkCooldown = true;
            timer = timerDuration;
            energy--;
            Vector3 steps = new Vector3(h, 0, v);
            transform.position += steps;
            h = 0;
            v = 0;
        }
    }
}
