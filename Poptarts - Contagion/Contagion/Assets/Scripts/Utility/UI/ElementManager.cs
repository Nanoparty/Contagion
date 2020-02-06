using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementManager : MonoBehaviour
{
    public Image eFire;
    public Image eWater;
    public Image eEarth;

    float time;
    public float displayTime = 0.2f;

    bool displayIcon;

    void Start() {
        GM.mgr_element = this;
    }

     void Update() {
        if (displayIcon) {
            time += Time.deltaTime;
            if (time >= displayTime) {
                IconsOff();

                displayIcon = false;
                time = 0;
            }
        }
    }
    public void DisplayElement(Elements e) {
        if (displayIcon) IconsOff();

        switch (e) {
            case Elements.Fire:
                eFire.gameObject.SetActive(true);
                break;
            case Elements.Water:
                eWater.gameObject.SetActive(true);
                break;
            case Elements.Earth:
                eEarth.gameObject.SetActive(true);
                break;
        }

        displayIcon = true;     
    }

    public int getElementCost(Elements e) {
        return Globals.baseElementCost;
    }

    void IconsOff() {
        eFire.gameObject.SetActive(false);
        eWater.gameObject.SetActive(false);
        eEarth.gameObject.SetActive(false);
    }
}
