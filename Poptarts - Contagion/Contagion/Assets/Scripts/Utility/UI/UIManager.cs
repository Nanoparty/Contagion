using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {
    public static ElementManager mgr_element;

    void Start() {
        GM.mgr_UI = this;
    }
}