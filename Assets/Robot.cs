using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public GameObject LaserPrefab;
    private float lastTimeShot = 0;
    private Animator _animator;
    private HUDManager _hud;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        _hud = FindObjectOfType<HUDManager>();
        _animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        Vector3 xz =  transform.rotation.eulerAngles;
        xz.x = .0f;
        xz.z = .0f;
        transform.rotation = Quaternion.Euler(xz);
        if (Time.time - lastTimeShot > 3 && _animator.GetCurrentAnimatorStateInfo(0).IsTag("Idle"))
        {
            lastTimeShot = Time.time;
            GameObject newObject = Instantiate(LaserPrefab, transform.position + (transform.forward * 0.4f) + new Vector3(0, 1.5f, 0), Quaternion.identity);
            newObject.GetComponent<Projectile>().target = player;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        _hud.score += 10;
        _animator.SetTrigger("Dead");

    }

}
