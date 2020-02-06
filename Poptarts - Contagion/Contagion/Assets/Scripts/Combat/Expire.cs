using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expire : MonoBehaviour
{
    int lifespan = 200;
    int increment = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        increment++;
        if (increment > lifespan)
            Destroy(this.gameObject);
    }

    
    
}
