using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public  class Computer : intractableObject
{
    

    public Sprite on;
    public Sprite off;
    public Sprite bootingUp;
    public Sprite antiVirus;
    public Sprite infected;

    bool HasPower = true;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = on;
    }

     void Update()
    {
    }


    public override void Fix()
    {
        if (HasPower == false) { return; }
        base.Fix();
        spriteRenderer.sprite = on;
    }

    public override void Destroy()
    {
        if (HasPower == false) { return; }


        
        spriteRenderer.sprite = antiVirus;
        Invoke("infect", 5.0f);
        

    }
    public void infect()
    {
        spriteRenderer.sprite = infected;
        base.Destroy();
    }

    public void PowerOn()
    {
        HasPower = true;
        if (objectState == state.Destroyed)
        {
            spriteRenderer.sprite = infected;
        }
        else
        {
            spriteRenderer.sprite = on;

        }




    }
    public void PowerOF()
    {

        spriteRenderer.sprite = off;
        HasPower = false;
        



    }


}
