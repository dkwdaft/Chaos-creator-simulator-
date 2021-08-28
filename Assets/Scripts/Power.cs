using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Power : intractableObject
{
   public Sprite fxed;

    public Sprite broken;
   
    public List<Computer> comparers;
    public List<Dore> dores;

    public override void Fix()
    {
        base.Fix();
        spriteRenderer.sprite = fxed;
        if (comparers.Count > 0)
        {
            foreach (var item in comparers)
            {
                item.PowerOn();

            }
        }
            if (dores.Count > 0)
            {
                foreach (var item in dores)
                {
                    item.SetOpen(true);

                }
            }




    }
    public override void Destroy()
    {
        base.Destroy();
        spriteRenderer.sprite = broken;
        if (comparers.Count > 0)
        {
            foreach (var item in comparers)
            {
                item.PowerOF();

            }
        }
        if (dores.Count > 0)
        {
            foreach (var item in dores)
            {
                item.SetOpen(false);

            }
        }
    }


}
