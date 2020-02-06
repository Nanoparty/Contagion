using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    bool canHit = true;
    int inc = 0;
    int delay = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!canHit) {
            inc++;
            if (inc >= delay) {
                canHit = true;
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && canHit) {
            other.GetComponent<PlayerHealth>().addHealth(-20);
            canHit = false;
            inc = 0;
        }
    }
}
