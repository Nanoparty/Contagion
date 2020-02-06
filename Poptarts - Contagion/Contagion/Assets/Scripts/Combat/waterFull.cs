using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterFull : MonoBehaviour
{
    private float level;
    public GameObject[] enemies;
    bool full = false;
    public float numE = 4;
    bool compl = false;
    public GameObject[] reward;
    // Start is called before the first frame update
    void Start()
    {
        level = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if((this.transform.position.y >= (level + (0.3f * 8)-.1f)) && !full) {
            //move to level 3
            //Debug.Log("full");
            full = true;
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].SetActive(true);
            }
        }
        if(numE == 0 && !compl) {
            //Debug.Log("no enemies");
            compl = true;
        }
        //Debug.Log(enemies.Length);
    }
    public void subEnemy() {
        if (full) {
            numE--;
            //Debug.Log("ENEMY HAD BEEN KILLED");
            for (int i = 0; i < reward.Length; i++)
            {
                reward[i].SetActive(true);
            }
        }

    }
}
