using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonDoor : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (SceneManager.GetActiveScene().name.Equals("Dungeon"))
        {
            SceneManager.LoadScene("Town");
        }
        else
        {
            SceneManager.LoadScene("Dungeon");
        }
    }
}
