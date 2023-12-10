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
        thePictureRenderer.sprite = Resources.Load<Sprite>(Bone.pictureFile);//this will grab a sprite from the resouces folder called 'whatever pictureFile is'.png. Make sure to make it a sprite and not default.

    }

    // Update is called once per frame
    void Update()
    {
        if (sandData.fossils)
            bonefound = true;

        if (bonefound == true && called == false) {
            this.transform.position = endpoint.transform.position;
            //texture = Resources.Load<Texture2D>("BonePic");   These lines were for loading a screenshot of the in game bone that was dug up, unused. Also has a line in sand script
            //thePictureRenderer.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f); //same as above
            called = true;
        }
    }
}
