using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchPuzzle : MonoBehaviour
{
    public GameObject ChestA;
    public GameObject ChestB;
    public GameObject PrizeA;
    public GameObject PrizeB;
    public GameObject Sign;
    static int count;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("FireballCollider"))
        {
            //Debug.Log(gameObject.name);
            if (gameObject.name == "TorchD"&& GameObject.Find("TorchB").transform.GetChild(0).gameObject.activeSelf == false && GameObject.Find("TorchA").transform.GetChild(0).gameObject.activeSelf == false && GameObject.Find("TorchC").transform.GetChild(0).gameObject.activeSelf == false)
            {
                count = 0;
                //Debug.Log("Success!");
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
            }

            if (gameObject.name == "TorchA" && GameObject.Find("TorchD").transform.GetChild(0).gameObject.activeSelf == true)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                count = 0;
            }
            else
            {
                count++;
                if (count >= 4)
                {
                    GameObject.Find("TorchA").transform.GetChild(0).gameObject.SetActive(false);
                    GameObject.Find("TorchD").transform.GetChild(0).gameObject.SetActive(false);
                    count = 0;
                }
                //Debug.Log(count);
                //count++;
            }
            if (gameObject.name == "TorchB" && GameObject.Find("TorchA").transform.GetChild(0).gameObject.active == true && GameObject.Find("TorchD").transform.GetChild(0).gameObject.active == true)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                count = 0;
            }
            //}
            //else
            //{
            //    Debug.Log(count);
            //    count++;
            //}
            else
            {
                count++;
                //gameObject.transform.GetChild(0).gameObject.SetActive(false);
                if (count >= 4)
                {
                    GameObject.Find("TorchA").transform.GetChild(0).gameObject.SetActive(false);
                    GameObject.Find("TorchD").transform.GetChild(0).gameObject.SetActive(false);
                    count = 0;
                }
            }

            if (gameObject.name == "TorchC" && GameObject.Find("TorchB").transform.GetChild(0).gameObject.activeSelf == true && GameObject.Find("TorchA").transform.GetChild(0).gameObject.activeSelf == true && GameObject.Find("TorchD").transform.GetChild(0).gameObject.activeSelf == true)
            {
                ChestA.SetActive(true);
                ChestB.SetActive(true);
                PrizeA.SetActive(true);
                PrizeB.SetActive(true);

                Sign.SetActive(true);
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                count = 0;
                if (GameObject.Find("TorchC").transform.GetChild(0).gameObject.activeSelf == true && GameObject.Find("TorchB").transform.GetChild(0).gameObject.activeSelf == true && GameObject.Find("TorchA").transform.GetChild(0).gameObject.activeSelf == true && GameObject.Find("TorchD").transform.GetChild(0).gameObject.activeSelf == true)
                {
                    ChestA.SetActive(true);
                    ChestB.SetActive(true);
                    Sign.SetActive(true);
                }
            }
            //else
            //{
            //    Debug.Log(count);
            //    count++;
            //}
            else
            {
                count++;
                //gameObject.transform.GetChild(0).gameObject.SetActive(false);
                if (count >= 4)
                {
                    GameObject.Find("TorchA").transform.GetChild(0).gameObject.SetActive(false);
                    GameObject.Find("TorchD").transform.GetChild(0).gameObject.SetActive(false);
                    GameObject.Find("TorchB").transform.GetChild(0).gameObject.SetActive(false);
                    count = 0;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (count > 9)
        //{
        //    Debug.Log("Send in the Goblins");
        //    count = 0;
        //}
    }
}
