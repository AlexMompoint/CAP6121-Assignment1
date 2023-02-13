using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberSoundScript : MonoBehaviour
{
    public AudioClip lightsaberOn;
    private AudioSource audioSource;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
