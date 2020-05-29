using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyItem : MonoBehaviour
{
    private Personagem personagem = new Personagem();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0.5f,0);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            personagem.Steps += 700;
            Destroy(gameObject);
        }
    }
}
