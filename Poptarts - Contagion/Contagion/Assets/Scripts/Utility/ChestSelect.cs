using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestSelect : MonoBehaviour
{

    private void OnMouseDown()
    {
        if(this.name == "PrizeA") {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().setMax(50);
            Globals.PLAYER_START_HP = Globals.PLAYER_START_HP+50;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().setHealthSlider(Globals.PLAYER_START_HP);
            GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(15f, .8f, 11.0f);
        }
        if(this.name == "PrizeB") {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMana>().setMax(50);
            Globals.PLAYER_START_MP = Globals.PLAYER_START_MP+50;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMana>().setManaSlider(Globals.PLAYER_START_MP);
            GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(15f, .8f, 11.0f);
        }
        if (this.name == "PrizeC")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().setMax(50);
            Globals.PLAYER_START_HP = Globals.PLAYER_START_HP + 50;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().setHealthSlider(Globals.PLAYER_START_HP);
            GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(-7.6f, .8f, 33f);
        }
        if (this.name == "PrizeD")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMana>().setMax(50);
            Globals.PLAYER_START_MP = Globals.PLAYER_START_MP + 50;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMana>().setManaSlider(Globals.PLAYER_START_MP);
            GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(-7.6f, .8f, 33f);
        }
        if (this.name == "PrizeE")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().setMax(50);
            Globals.PLAYER_START_HP = Globals.PLAYER_START_HP + 50;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().setHealthSlider(Globals.PLAYER_START_HP);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Dungeon Boss", UnityEngine.SceneManagement.LoadSceneMode.Single);
        }
        if (this.name == "PrizeF")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMana>().setMax(50);
            Globals.PLAYER_START_MP = Globals.PLAYER_START_MP + 50;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMana>().setManaSlider(Globals.PLAYER_START_MP);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Dungeon Boss", UnityEngine.SceneManagement.LoadSceneMode.Single);
        }

    }
}
