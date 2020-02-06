using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public int increment;
    public int delay = 50;
    bool canAttack = true;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!canAttack) {
            increment++;
            if (increment > delay)
                canAttack = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log("Pressed secondary button.");

            if (canAttack)
            {
                Vector3 t = new Vector3(transform.position.x, (float)(transform.position.y+.5) , transform.position.z);
                GameObject bullet = Instantiate(projectile, t, Quaternion.identity) as GameObject;
                
                //var heading = transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;
                //var distance = heading.magnitude;
                //var direction = heading / distance;
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 300);
                canAttack = false;
                increment = 0;
            }
        }
    }
}
