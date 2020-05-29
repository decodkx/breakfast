using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Personagem
{
    private int lives;
    private int steps;

    private float stepsNumber;    
    private Transform position;
    
    public float getStepsNumber()
    {
        return stepsNumber;
    }


    public int Lives
    {
        get
        {
            return lives;
        }
        set
        {
            lives = value;
        }
    }

    public int Altitude { get; set; }
 
    public int Steps
    {
        get
        {
            return steps;
        }
        set
        {
            steps = value;
            Debug.Log(steps);
        }
    }

    public void setStepsNumber(float stepsNumber)
    {
        this.stepsNumber =+ stepsNumber;
    }

    public Transform getPosition()
    {
        return position;
    }

    public void setPosition(Transform position)
    {
        this.position = position;
    }


}
