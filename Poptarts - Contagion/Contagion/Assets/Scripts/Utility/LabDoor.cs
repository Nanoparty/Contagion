using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabDoor : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Town");
    }
}
