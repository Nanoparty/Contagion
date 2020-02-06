using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBubbleCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnParticleCollision(GameObject other){
        if(other.tag == "Enemy"){
            //Debug.Log("Particle Hit ENEMY");
            float dmg = GM.mgr_spells.calculateDamage("WW");
            other.GetComponent<MonsterAI>().health -= dmg;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
