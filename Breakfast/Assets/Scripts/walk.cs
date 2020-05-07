﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class walk : MonoBehaviour
{
    int v, h;                       //horizontal and vertical movements
    int timer = 1000;
    public int timerDuration = 30;  // duration of wait between movements
    bool walkCooldown = false;

    public static int energy =70;                    // quantity of spaces a player can move
    public Text energyIndicator;
    Vector3 steps;                                //movement direction
    Vector3 fixer = new Vector3(1, 0, 0);         //temp:: need to find error and delete crutch
    int dash = 1;                                //movement multiplier
    bool dashOn = false;

    GameObject spriteR;
    public GameObject ySensor;
    void Start()
    {
        spriteR = GameObject.Find("Sprite");
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            dashOn = !dashOn;
        }

        switch(dashOn)
        {
            case true:
                dash = 2;
                break;
            case false:
                dash = 1;
                break;
        }    


       if(!walkCooldown)
        {
            if (Input.GetKeyDown(KeyCode.W) && !sensor.north)
            {
                steps = new Vector3(0, 0, 1 * dash);
                YCheck(steps);
            }
            if (Input.GetKeyDown(KeyCode.S) && !sensor.south)
            {
                steps = new Vector3(0, 0, -1 * dash);
                YCheck(steps);
            }
            if (Input.GetKeyDown(KeyCode.A) && !sensor.west)
            {
                steps = new Vector3(-1 * dash, 0, 0);
                YCheck(steps);
            }
            if (Input.GetKeyDown(KeyCode.D) && !sensor.east)
            {
                steps = new Vector3(1 * dash, 0, 0);
                YCheck(steps);
            }
        }
    }


    private void YCheck(Vector3 future)
    {
        Instantiate<GameObject>(ySensor, transform.position + future + fixer, Quaternion.identity);

    }
    public void Move(float alt)
    {
        dash = 1;
        dashOn = false;
        if (energy > 0)
        {
            walkCooldown = true;
            timer = timerDuration;
            energy--;
            transform.position = new Vector3(transform.position.x, alt, transform.position.z);
            //spriteR.transform.position += new Vector3(0, 0, alt.z);
            transform.position += steps; // + last;
            steps = Vector3.zero;
        }
    }
}
