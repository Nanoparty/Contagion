using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabDoor2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Dungeon");
    }
}
