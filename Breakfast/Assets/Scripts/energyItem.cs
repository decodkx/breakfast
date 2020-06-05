using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyItem : MonoBehaviour
{
    public CD m;
    void Start()
    {
        m = GameObject.FindGameObjectWithTag("GM").GetComponent<CD>();
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
            m.Steps += 5;
            Destroy(gameObject);
        }
    }
}
