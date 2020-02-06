using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
    //private Animator anim;

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    anim.SetTrigger("Active");
        //}
    }

    private void OnMouseDown()
    {
        //int count = 0;
        //anim.SetTrigger("Active");

        //while (count < 10000000000000)
        //{
        //    count++;
        //}
        SceneManager.LoadScene("Lab");
    }
}
