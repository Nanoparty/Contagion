using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SpellDB;

public class CombatManager : MonoBehaviour
{
    SpellDB.Spell Spell;
    // Start is called before the first frame update
    void Start()
    {
        GM.mgr_combats = this;
    }


    // Update is called once per frame
    void Update() {
    }

    public void detectCombo(string combination){
        //Debug.Log(GM.db_spells.getSpellDB());

        
        // if the combination is in the spells database
        if(GM.db_spells.getSpellDB().ContainsKey(combination)){
            // perform visual effects and collisions
            GM.mgr_spells.resetCombination();
            Spell = GM.db_spells.getSpellDB()[combination];
            //Debug.Log(Spell.spellName);
            Invoke(Spell.spellName, 0f);
        }
    }

    public GameObject fireBall;
    public GameObject fireWall;
    public GameObject waterBubble;
    public GameObject shooting_root;
    public GameObject hiddenBubble;

    public GameObject rollingRock;
    public float speed = 100f;

    public AudioSource waterBubbleSound;
    public AudioSource rockSound;
    void castFireBall(){
        GameObject fireBallInstance;
        //fireBallInstance = Instantiate(fireBall, new Vector3(shooting_root.transform.position.x, shooting_root.transform.position.y, shooting_root.transform.position.z + 20), shooting_root.transform.rotation) as GameObject;
        fireBallInstance = Instantiate(fireBall, shooting_root.transform.position, shooting_root.transform.rotation) as GameObject;

        //Rigidbody fireBallInstRigidbody = fireBallInstance.GetComponent<Rigidbody>();
        //fireBallInstRigidbody.AddForce(shooting_root.transform.forward * speed); 
        // set the shooter variable in the bullet script:
        //fireBallInstance.GetComponent<Bullet>().shooter = transform;
    }

    void castFireWall(){
        GameObject fireWallInstance;
        //fireBallInstance = Instantiate(fireBall, new Vector3(shooting_root.transform.position.x, shooting_root.transform.position.y, shooting_root.transform.position.z + 20), shooting_root.transform.rotation) as GameObject;
        fireWallInstance = Instantiate(fireWall, new Vector3(shooting_root.transform.position.x,shooting_root.transform.position.y-1, shooting_root.transform.position.z + 5), shooting_root.transform.rotation) as GameObject;

        //Rigidbody fireBallInstRigidbody = fireBallInstance.GetComponent<Rigidbody>();
        //fireBallInstRigidbody.AddForce(shooting_root.transform.forward * speed); 
        // set the shooter variable in the bullet script:
        //fireBallInstance.GetComponent<Bullet>().shooter = transform;
    }

    void castWaterBubble(){
        //Debug.Log("play");
        waterBubbleSound.Play();
                //Debug.Log("end");

        GameObject waterBubbleInstance;
        //fireBallInstance = Instantiate(fireBall, new Vector3(shooting_root.transform.position.x, shooting_root.transform.position.y, shooting_root.transform.position.z + 20), shooting_root.transform.rotation) as GameObject;
        waterBubbleInstance = Instantiate(waterBubble, new Vector3(shooting_root.transform.position.x,shooting_root.transform.position.y-(1/2), shooting_root.transform.position.z), shooting_root.transform.rotation) as GameObject;

        Vector3 t = new Vector3(transform.position.x, (float)(transform.position.y + .5), transform.position.z);
        GameObject bullet = Instantiate(hiddenBubble, t, Quaternion.identity) as GameObject;

        //var heading = transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;
        //var distance = heading.magnitude;
        //var direction = heading / distance;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 300);
        //Debug.Log("hidden");
        //Rigidbody fireBallInstRigidbody = fireBallInstance.GetComponent<Rigidbody>();
        //fireBallInstRigidbody.AddForce(shooting_root.transform.forward * speed); 
        // set the shooter variable in the bullet script:
        //fireBallInstance.GetComponent<Bullet>().shooter = transform;
    }

    void castRollingRock(){
        GameObject rollingRockInstance;
        rockSound.Play();
        //fireBallInstance = Instantiate(fireBall, new Vector3(shooting_root.transform.position.x, shooting_root.transform.position.y, shooting_root.transform.position.z + 20), shooting_root.transform.rotation) as GameObject;
        rollingRockInstance = Instantiate(rollingRock, new Vector3(shooting_root.transform.position.x,shooting_root.transform.position.y, shooting_root.transform.position.z), shooting_root.transform.rotation) as GameObject;
        
        rollingRockInstance.GetComponent<Rigidbody>().AddForce(shooting_root.transform.forward * 1000f);
        Destroy(rollingRockInstance, 3.5f);
        //Rigidbody fireBallInstRigidbody = fireBallInstance.GetComponent<Rigidbody>();
        //fireBallInstRigidbody.AddForce(shooting_root.transform.forward * speed); 
        // set the shooter variable in the bullet script:
        //fireBallInstance.GetComponent<Bullet>().shooter = transform;
    }


}
