using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {
    public float animSpeed = 1f;                
    
    public float forwardSpeed = 7.0f;
    public float backwardSpeed = 2.0f;
    public float rotateSpeed = 2.0f;

    private CapsuleCollider col;
    private Rigidbody rb;
    private Vector3 velocity;

    private float orgColHight;
    private Vector3 orgVectColCenter;
    private Animator anim;                          
    private AnimatorStateInfo currentBaseState; 

    private GameObject cameraObject;

    static int idleState = Animator.StringToHash("Base Layer.Idle");
    static int locoState = Animator.StringToHash("Base Layer.Locomotion");
    static int restState = Animator.StringToHash("Base Layer.Rest");

    private Vector3 offset;
    private GameObject target = null;
    private Vector3 orgPos;

    void Start() {
        anim = GetComponent<Animator>();
        col = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();

        cameraObject = GameObject.FindWithTag("MainCamera");
        orgColHight = col.height;
        orgVectColCenter = col.center;
    }

    void FixedUpdate() {
        float h = Input.GetAxis("Horizontal");   
        float v = Input.GetAxis("Vertical");        
        anim.SetFloat("Speed", v);                       
        anim.SetFloat("Direction", h);                    
        anim.speed = animSpeed;
        
        /* Here can put the logic for attacking.
         */

        if (Input.GetMouseButtonDown(0)) {
            // Attack
            // anim.setBool("Attack", true)???
        }
        currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
        rb.useGravity = true;

        velocity = new Vector3(0, 0, v);        
        velocity = transform.TransformDirection(velocity);
       

        if (v > 0.1) {
            velocity *= forwardSpeed;       
        } else if (v < -0.1) {
            velocity *= backwardSpeed; 
        }

        transform.localPosition += velocity * Time.fixedDeltaTime;
        transform.Rotate(0, h * rotateSpeed, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "platform")
        {
            target = other.gameObject;
            orgPos = transform.position;
           

        }
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "platform")
        {
            //target = other.gameObject;
            offset = new Vector3(target.transform.position.x - transform.position.x, 0, target.transform.position.z - transform.position.z);
            //offset = target.transform.position - transform.position;
            //transform.position = other.transform.position;

        }

    }
    void onTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "platform")
        {
            target = null;

        }
        
    }
    void LateUpdate()
    {
        //if (target != null)
        //{
        //    transform.localPosition += offset;
        //}
    }
}
