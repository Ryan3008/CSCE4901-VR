using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SprayScript : MonoBehaviour
{
    public bool active, spraying, onCoolDown;
    float activeTimer, coolDown, deltatimeCooldown, deltatspraytime;
    public ParticleSystem spray;

    // Start is called before the first frame update
    void Start()
    {
        active = false; spraying = false; 
        activeTimer = 0.5f;
        coolDown = activeTimer + 0.5f;
        deltatimeCooldown = activeTimer;
        onCoolDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        //do the things
        if (deltatimeCooldown <= 0.0f) {
            onCoolDown = false;
            deltatimeCooldown -= Time.deltaTime;
        }

        if (deltatspraytime > 0.0f) {
            spraying = false;
            deltatspraytime -= Time.deltaTime;

            spray.Stop();
        }

    }

    void activate() {
        if (!onCoolDown) {
            deltatimeCooldown = coolDown;
            onCoolDown = true;

            deltatspraytime = activeTimer;
            spraying = true;

            spray.Play();
            
        }
    }

}
