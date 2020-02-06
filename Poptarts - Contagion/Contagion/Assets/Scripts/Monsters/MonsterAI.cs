using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MonsterAI : MonoBehaviour
{
    NavMeshAgent nav;
    public GameObject player;
    bool canAttack = true;
    public int delay = 100;
    public GameObject projectile;
    int increment;
    public float health = 100;
    public float maxhealth = 100;
    public GameObject healthBarUI;
    public Slider slider;
    public bool isBoss = false;
    int range = 3;

    // Start is called before the first frame update

    void Start()
    {
       
        nav = GetComponent<NavMeshAgent>();
        //Canvas c = this.GetComponent<Canvas>();
        //slider = c.GetComponent<Slider>();
        slider.value = CalculateHealth();
    }

    float CalculateHealth() {
        return health / maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBoss) {
            range = 10;
        }
        slider.value = CalculateHealth();
        if (health <= 0) {
            Destroy(this.gameObject);
            GameObject.FindGameObjectWithTag("Water").GetComponent<waterFull>().subEnemy();
            if (isBoss)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Ending", UnityEngine.SceneManagement.LoadSceneMode.Single);
            }

        }
        if (!canAttack) {
            increment++;
            if (increment >= delay)
                canAttack = true;
        }
        Vector3 dest = GameObject.FindGameObjectWithTag("Player").transform.localPosition;
        var dist = Vector3.Distance(this.transform.position, dest);
        if (dist < 10f) {
            //Vector3 dest = player.transform.position;
            //dest.y = this.transform.position.y;
            nav.SetDestination(dest);
            //Debug.Log("player" + dest);
        }

        if (!nav.pathPending)
        {
            if (nav.remainingDistance < 1.5)
            {
                nav.isStopped = true;
            }
            else {
                nav.isStopped = false;
            }
        }

        if (canAttack && Vector3.Distance(this.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < range)
        {
            GameObject bullet = Instantiate(projectile, new Vector3(this.transform.position.x, this.transform.position.y+.3f, this.transform.position.z), Quaternion.identity) as GameObject;
            var heading = transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;
            var distance = heading.magnitude;
            var direction = heading / distance;
            bullet.GetComponent<Rigidbody>().AddForce(direction * -300);
            canAttack = false;
            increment = 0;
            //Debug.Log("ATTAKIG");
        }

    }
    private void FixedUpdate()
    {
        //Debug.Log(player.transform.position);
    }

    public void addHealth(float i) {
        health += i;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerProjectile") {
            Destroy(other.gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerProjectile")
        {
            Destroy(collision.gameObject);
        }
    }
}
