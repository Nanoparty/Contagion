using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropletCollide : MonoBehaviour
{
    public GameObject water;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
           ;
            if (this.tag == "droplet") {
                Destroy(this.gameObject);
                water.transform.position += new Vector3(0, .3f, 0);
            }


        }

    }
}
