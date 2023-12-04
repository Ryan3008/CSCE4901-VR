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
    public bool called;
    public Texture2D texture;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = startPoint.transform.position;
        bonefound = false;
        called = false;

        theData.SetText(Bone.Description);
        theName.SetText(Bone.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sandData.fossils)
            bonefound = true;

        if (bonefound == true && called == false) {
            this.transform.position = endpoint.transform.position;
            texture = Resources.Load<Texture2D>("BonePic");
            thePictureRenderer.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f); ;
            called = true;
        }
    }
}
