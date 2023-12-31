using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressure_Plate : MonoBehaviour
{
    [HideInInspector]
    public bool activated, triggered;

    Animator anim;

    public AudioSource audioTrigger;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered && !activated)
        {
            activated = true;
            audioTrigger.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Grabbable" || col.gameObject.tag == "Boy")
        {
            if (!triggered)
            {
                triggered = true;
                anim.SetTrigger("Trigger");

                foreach (var c in GetComponentsInChildren<Collider2D>())
                {
                    c.enabled = false;
                }
            }
            
        }

    }
}
