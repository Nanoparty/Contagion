using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class PauseScript : MonoBehaviour
{

    CanvasGroup cg;

    private void Awake() {
        cg = GetComponent<CanvasGroup>();
    }


    // Update is called once per frame
    void Update() {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            togglePause();
        }
    }

    public void togglePause() { 
        if (cg.interactable) {
            cg.interactable = false;
            cg.blocksRaycasts = false;
            cg.alpha = 0f;
            Time.timeScale = 1f;
        } else {
            cg.interactable = true;
            cg.blocksRaycasts = true;
            cg.alpha = 1f;
            Time.timeScale = 0;
        }
    }
}
