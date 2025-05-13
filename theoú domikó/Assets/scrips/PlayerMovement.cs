using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
   private Animator animator;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;

        //if (moveX < 0) transform.localScale = new Vector3(1f, 1f, 1f);
        //else if (moveX > 0.0f) transform.localScale = new Vector3(1f, 1f, 1f);


        //ANIMACION
        if (moveX != 0 || moveY !=0) { 
        animator.SetFloat("X", moveX);
        animator.SetFloat ("Y", moveY);
        animator.SetBool ("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    
    }

    private void FixedUpdate() //fisicas 
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime); 

    }

}
