using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyItem : MonoBehaviour
{
    // Start is called before the first frame update
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
            walk.energy = 7;
            Destroy(gameObject);
        }
    }
}
