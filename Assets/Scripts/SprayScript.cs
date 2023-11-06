using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayScript : MonoBehaviour
{
    public bool active, spraying;
    float activeTimer;

    // Start is called before the first frame update
    void Start()
    {
        active = false; spraying = false; 
        activeTimer = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        sprayCoolDown();
    }

    private void sprayCoolDown() {
    
    }
}
