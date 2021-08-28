using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookshelf : intractableObject
{
    

    public Sprite fixedSprite;

    public Sprite destroyedSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = fixedSprite;

    }

    
    public override void Fix()
    {
        base.Fix();
        spriteRenderer.sprite = fixedSprite;
    }

    public override void Destroy()
    {
        base.Destroy();
        spriteRenderer.sprite = destroyedSprite;
    }
}
