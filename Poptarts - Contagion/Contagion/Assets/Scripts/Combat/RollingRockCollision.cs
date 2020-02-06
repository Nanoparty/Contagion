using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingRockCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // void OnParticleCollision(GameObject other){
    //     Debug.Log("Particle Hit");
    //     if(other.tag == "Enemy"){
    //         Debug.Log("Particle Hit ENEMY");
    //         float dmg = GM.mgr_spells.calculateDamage("EEE");
    //         other.GetComponent<MonsterAI>().health -= dmg;
    //     }
    // }

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Enemy"){
            float dmg = GM.mgr_spells.calculateDamage("EE");
            col.gameObject.GetComponent<MonsterAI>().health -= dmg;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
