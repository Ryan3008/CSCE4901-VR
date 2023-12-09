using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Generate random positions for x, y, and z within range
        float randomX = transform.position.x + Random.Range(-1f, 1f);
        float randomY = transform.position.y + Random.Range(-1f, 1f);
        float randomZ = transform.position.z + Random.Range(-0.5f, 0.5f);

        // Set the object's position to the random values
        transform.position = new Vector3(randomX, randomY, randomZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
