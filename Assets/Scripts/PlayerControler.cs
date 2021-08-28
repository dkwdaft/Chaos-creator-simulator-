using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Animations;



public class PlayerControler : MonoBehaviour
{
    public 
    Vector2 move;
    Rigidbody2D RB2D;
    public float Speed = 5;
    Animator animator;
    public bool Chaotick;
    public Transform interackPiont;
    LevalManager levalManager;
    private void OnEnable()
    { 
        animator = GetComponentInChildren<Animator>();
        RB2D = GetComponent<Rigidbody2D>();
        
        
        levalManager = FindObjectOfType<LevalManager>();

        animator.SetInteger("Player", levalManager.joinPlayer());
        animator.SetTrigger("Swich");

    }
    // Update is called once per frames
    void Update()
    {
        
    }
    public bool idel;
    public void onMove(InputAction.CallbackContext callback)
    {
        move = callback.ReadValue<Vector2>();

   
        RB2D.velocity = move * Speed;

        idel = (Vector2.zero == move);
        animator.SetFloat("Speed", move.y + (move.x*2 ));
        animator.SetBool("Idel", idel);
    }
    public void onAct(InputAction.CallbackContext callback)
    {
        
        var w = Physics2D.OverlapCircleAll(interackPiont.position, 1f);
        List <intractableObject> i = new List<intractableObject>();
        foreach (var item in w)
        {


            intractableObject q;
          if (item.gameObject.TryGetComponent<intractableObject>(out q))
            {
                Debug.Log(i);
                i.Add(q);

                q.Destroy();
            }


        }
        foreach (var item in i)
        {
            
                item.Destroy();




              


            
        }

    }
}
