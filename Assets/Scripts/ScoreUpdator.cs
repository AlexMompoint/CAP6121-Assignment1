using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdator : MonoBehaviour
{
    HUDManager hud;
    // Start is called before the first frame update
    void Start()
    {
        hud = FindObjectOfType<HUDManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
            hud.score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
