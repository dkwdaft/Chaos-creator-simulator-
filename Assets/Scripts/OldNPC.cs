using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OldNPC : MonoBehaviour
{
    Animator animator;
    NavMeshAgent navMeshAgent;
    LevalManager levalManager;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        animator = GetComponentInChildren<Animator>();
        animator.SetInteger("Player", 0);
        animator.SetTrigger("Swich");
        levalManager = FindObjectOfType<LevalManager>();
    }
    bool idel;
    intractableObject Dest;
    public void setDestanashon()
    {
        
        

      

    } 

    // Update is called once per frame
    void Update()
    {



        idel = (Vector3.zero == navMeshAgent.desiredVelocity);
        animator.SetFloat("Speed", navMeshAgent.desiredVelocity.y + (navMeshAgent.desiredVelocity.x * 2));
        animator.SetBool("Idel", idel);
        

        if (Dest == null)
        {

            Dest = levalManager.FinedBroken();

            if (Dest != null)
            {
                navMeshAgent.SetDestination(Dest.transform.position);
            }

        }
            else if (idel)
        {
            var w = Physics2D.OverlapCircleAll(Dest.transform.position, 3f);
            List<intractableObject> i = new List<intractableObject>();
            foreach (var item in w)
            {


                intractableObject q;
                if (item.gameObject.TryGetComponent<intractableObject>(out q))
                {
                    q.Fix();


                }


            }
            Dest = null;
            //reqest new desternashon




        }


    }
}
