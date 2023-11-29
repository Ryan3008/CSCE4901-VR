using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SandScript : MonoBehaviour
{
    //Vector Stuff
    public GameObject LowestPoint;
    public GameObject table, sandHandle;
    private Vector3 resetpoint;

    //Percentage Varibles and
    public float moistness, sweptAway; //vaible between 1 and 0
    private float sweptOffset;

    public bool rock, fossils; //these bools will flag if the particular thing

    void Start()
    {
        //Set up veribles
        resetpoint = transform.localPosition;
        sweptOffset = resetpoint.z - LowestPoint.transform.localPosition.z;
        rock = false;
        fossils = false;
        moistness = 0;
        sweptAway = 0;
        Debug.Log("SandBox Loaded");
    }

    private void Update()
    {
        //Check bounds for percenteges
        if (sweptAway > 100.0)
            sweptAway = 100.0f;
        else if (sweptAway < 0.0)
            sweptAway = 0.0f;

        if (moistness > 100.0)
            moistness = 100.0f;
        else if (moistness < 0.0)
            moistness = 0.0f;

        //Update the percentage gone
        transform.localPosition = new Vector3(0.0f, 0.0f, (sweptOffset * (-sweptAway / 100)));

        //Update Values
        if (moistness > 0.0f) { moistness += -0.01f * Time.deltaTime; } //things dry over time

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Something exited the zone");

        if (other.CompareTag("Bone"))
        {
            Debug.Log("Object with tag Bone has exited the trigger zone.");
            fossils = true;
        }
        else if (other.CompareTag("Rock"))
        {
            Debug.Log("Object with tag Rock has exited the trigger zone.");
            rock = true;
        }
        else if (other.CompareTag("Water")) {
            SprayScript spraydata = other.GetComponent<SprayScript>();
            if (spraydata != null)
                if (spraydata.spraying) { moistness += 10; }
        }
        else
        {
            Debug.Log("Other object exited the trigger zone.");
        }

    }
}
