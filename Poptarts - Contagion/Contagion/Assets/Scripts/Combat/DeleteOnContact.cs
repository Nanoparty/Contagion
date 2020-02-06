using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnContact : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            if(this.tag != "PlayerProjectile" && this.tag != "Bubble")
                Destroy(this.gameObject);
            if (this.tag == "Health")
                other.GetComponent<PlayerHealth>().addHealth(100);
            if (this.tag == "Mana")
                other.GetComponent<PlayerMana>().addMana(100);
            if (this.tag == "EnemyProjectile")
                other.GetComponent<PlayerHealth>().addHealth(-5);

        }
        if (other.tag == "Enemy") {

            if (this.tag != "EnemyProjectile")
                Destroy(this.gameObject);
            if (this.tag == "PlayerProjectile")
                other.GetComponent<MonsterAI>().addHealth(-10);
        }

        if (other.tag == "fireObj")
        {

            if (this.tag == "Bubble")
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }


    }
}
