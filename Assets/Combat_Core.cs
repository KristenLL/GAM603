using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_Core : MonoBehaviour
{
    public Animator animator;

    public CharacterMovement characterMovement;
    public bool isAttacking;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");

            
        }
        if (characterMovement.isMoving = false && Input.GetKeyUp(KeyCode.Space) && Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Attack");
        }
        if (Input.GetKeyUp(KeyCode.Space) && Input.GetKeyDown(KeyCode.A))
        {

        }
        if (Input.GetKeyUp(KeyCode.Space) && Input.GetKeyDown(KeyCode.S))
        {

        }
        if (Input.GetKeyUp(KeyCode.Space) && Input.GetKeyDown(KeyCode.D))
        {

        }




    }
}
