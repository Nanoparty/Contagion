using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked3D : MonoBehaviour
{
    public DialogueTrigger dt;
    
    // Start is called before the first frame update
    void Update()
    {
    }

    void OnMouseDown() {
        dt.TriggerDialogue();
        //Debug.Log("Triggered");
    }
}
