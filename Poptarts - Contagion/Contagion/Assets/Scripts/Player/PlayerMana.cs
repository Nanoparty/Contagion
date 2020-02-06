using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMana : MonoBehaviour {
    public int startMana = 100; 
    public int currMaxMana;
    public int currMana;   
    public Slider manaSlider;
    int inc;

    public Text manaText;

    float second = 1f;
    float currTime = 0.0f;

    void Awake() {
        currMana = startMana;
        currMaxMana = startMana;
        setManaSlider(currMaxMana);
    }
    public void setMax(int f) {
        currMaxMana += f;
    }
    void Update() {
        inc++;
        if (inc > 100 && currMana < currMaxMana) {
            inc = 0;
            currMana++;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMana>().setManaSlider(currMana);
        }
        if (currTime > second) {

            currTime = 0;
        } else {
            currTime += Time.deltaTime;
        }
    }

    public void addMana(int amt) {
        //Debug.Log(currMana);
        //Debug.Log(amt);

        currMana += amt;
        if (currMana > 100) {
            currMana = 100;
        }

        setManaSlider(currMana);
    }

    public void setManaSlider(int m) {
        currMana = m;
        manaSlider.value = m;
        manaText.text = currMana + "/" + currMaxMana;
    }

    public int getMana() {
        return currMana;
    }
}