using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HammerScript : MonoBehaviour
{
    public GameObject RockDump;
    public SandScript SandData;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            collision.gameObject.transform.position = RockDump.transform.position;
            SandData.rock = false;
        }
    }
}
