using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneData : MonoBehaviour
{
    public string BoneName, dinnoName, pictureFile, Description;//currently these are all preset in the engine, will need to pull from a file later

    void Start()
    {
        // Generate random positions for x, y, and z within range
        float randomX = transform.position.x + Random.Range(-1f, 1f);
        float randomY = transform.position.y + Random.Range(-1f, 1f);
        float randomZ = transform.position.z + Random.Range(-0.5f, 0.5f);

        // Set the object's position to the random values
        transform.position = new Vector3(randomX, randomY, randomZ);
    }
}
