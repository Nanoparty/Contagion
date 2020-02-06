using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCollisionHandler : MonoBehaviour
{
    PlayerHealth pHealth;
    PlayerMana pMana;

    // Start is called before the first frame update
    void Start()
    {
        pHealth = GM.mgr_spells.player.GetComponent<PlayerHealth>();
        pMana = GM.mgr_spells.player.GetComponent<PlayerMana>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter (Collision col){

    }
}
