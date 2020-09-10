using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class PlayerMovement : MonoBehaviour
{
    float Speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spritePlayer;
    public bool IsOnGround = false;
    
    

    private void Update()
    {
        jump();
        Vector3 Movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        transform.position += Movement * Time.deltaTime * Speed;


        if (Movement.x == 1)
        {
            spritePlayer.flipX = false;
            animator.SetBool("IsMoving", true);
        }
        else if (Movement.x == -1)
        {
            spritePlayer.flipX = true;
            animator.SetBool("IsMoving", true);
        }
        else
        {

            animator.SetBool("IsMoving", false);
        }


       
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 7f), ForceMode2D.Impulse);
            IsOnGround = false;
        }
        
    }


 
}
