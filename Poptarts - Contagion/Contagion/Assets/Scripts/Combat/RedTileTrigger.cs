using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTileTrigger : MonoBehaviour
{
    static int count = 0;
    public GameObject[] rewards;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WoodenBox")
        {
            Transform cube = transform.parent;
            cube.GetComponent<Renderer>().material.color = Color.green;

            count++;
            if (count == 4)
            {
                for (int i = 0; i < rewards.Length; i++)
                {
                    rewards[i].SetActive(true);
                }

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "WoodenBox")
        {
            Transform cube = transform.parent;
            cube.GetComponent<Renderer>().material.color = Color.red;
            count--;
        }
    }
}
