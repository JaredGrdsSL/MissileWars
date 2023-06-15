using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject objectPrefab; // the object to instantiate
    public float spawnInterval = 5f; // the time interval in seconds
    public Transform spawnParent; // the parent transform of the spawned objects

    private GameObject spawnedObject; // a non-static variable to store a reference to the spawned object

    private void Start()
    {
        InvokeRepeating("Spawn", spawnInterval, spawnInterval); // invoke the Spawn method repeatedly with the specified time interval
    }

    private void Spawn()
    {
        if(spawnedObject == null) // check if the non-static variable is null
        {
            spawnedObject = Instantiate(objectPrefab, transform.position, transform.rotation, spawnParent); // create a new object at the spawner's position and rotation and assign it to the non-static variable
        }
    }
}
