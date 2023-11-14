using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DataBoardScript : MonoBehaviour
{
    public GameObject startPoint, endpoint;
    public bool bonefound;
    public SandScript sandData;
    public BoneData Bone;
    public TextMeshPro theData, theName;
    public SpriteRenderer thePictureRenderer;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = startPoint.transform.position;
        bonefound = false;

        theData.SetText(Bone.Description);
        theName.SetText(Bone.name);
        //thePictureRenderer.sprite =; later
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sandData.fossils)
            bonefound = true;

        if (bonefound) {
            this.transform.position = endpoint.transform.position;
        }
    }
}
