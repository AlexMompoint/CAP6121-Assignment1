using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLasersTraining : MonoBehaviour
{
    public Transform player;
    public GameObject LaserPrefab;
    private float lastTimeSpawned = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTimeSpawned > 3)
        {
            lastTimeSpawned = Time.time;
            GameObject newObject = Instantiate(LaserPrefab,new Vector3(Random.Range(-10,10),Random.Range(1,3),Random.Range(-10,10)), Quaternion.identity);
            newObject.GetComponent<Projectile>().target = player;
        }
    }
}
