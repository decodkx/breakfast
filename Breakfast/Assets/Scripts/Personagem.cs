using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Personagem : MonoBehaviour
{
    // Start is called before the first frame update
    private float stepsNumber;
    private int lives;
    private Transform position;
    
    public float getStepsNumber()
    {
        return stepsNumber;
    }


    public int getLives()
    {
        return lives;
    }

    public void setStepsNumber(float stepsNumber)
    {
        this.stepsNumber =+ stepsNumber;
    }
    
    
    public void setLives(int lives)
    {
        this.lives = lives;
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
