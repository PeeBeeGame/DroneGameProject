using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Boy" || col.gameObject.tag == "Drone")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}