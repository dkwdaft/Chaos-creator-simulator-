using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum state { Fixed, Destroyed }


public class intractableObject : MonoBehaviour
{ 
    public state objectState;
    public SpriteRenderer spriteRenderer;

    public int PointValue = 5;

    LevalManager levalManager;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        levalManager = FindObjectOfType<LevalManager>();
        levalManager.AllObjets.Add(this);
    }

    public virtual void Fix()
    {
        objectState = state.Fixed;
        Debug.Log(objectState);
        levalManager.brokenObjets.Remove(this);
        levalManager.UpdateScore();
    }

    public virtual void Destroy()
    {
        objectState = state.Destroyed;
        Debug.Log(objectState);
        levalManager.brokenObjets.Add(this);
        levalManager.UpdateScore();
    }
}
