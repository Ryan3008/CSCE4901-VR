using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushTriggerScript : MonoBehaviour
{
    public GameObject TableSand;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("BrushTriggerScript Loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Brush")) {
             SandScript theSandData = TableSand.GetComponent<SandScript>();
            if (theSandData != null) 
                if (!theSandData.fossils && !theSandData.rock)
                    theSandData.sweptAway += 1.0f + theSandData.moistness;
        }
    }
}
