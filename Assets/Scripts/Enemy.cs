//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Security.Cryptography;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    HUDManager hud;
    // Start is called before the first frame update
    void Start()
    {
        hud = FindObjectOfType<HUDManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Blade")
        {
            //print($"{gameObject.name} hit {other.name}");
            //Debug.Log($"{transform.parent.GetComponent<Rigidbody>().velocity}");
            transform.parent.GetComponent<Rigidbody>().velocity = -transform.parent.GetComponent<Rigidbody>().velocity;
            hud.score++;
        } else if(other.name != "LightSaber")
        {
            Destroy(transform.parent.gameObject);
            Destroy(gameObject);

        }
        //Debug.Log($"{other.name}");
    }
}
