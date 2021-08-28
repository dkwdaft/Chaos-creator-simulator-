using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dore : MonoBehaviour
{

    bool isopen;
    public Sprite Open;
    public Sprite Closed;
    SpriteRenderer renderer;
    BoxCollider2D boxCollider2;
    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        boxCollider2 = GetComponent<BoxCollider2D>();
    }

    public void SetOpen(bool open)
    {
        isopen = open;

        if (isopen)
        {
            renderer.sprite = Open;
            boxCollider2.isTrigger = true;
        }else
        {
            renderer.sprite = Closed;
            boxCollider2.isTrigger = false;
        }


    }
}
