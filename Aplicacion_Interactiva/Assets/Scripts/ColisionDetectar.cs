using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDetectar : MonoBehaviour
{
    public Animator objeto01Animator;
    public Animator objeto02Animator;
    public Animator objeto03Animator;

    private bool isColliding = false; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ObjetoColision"))
        {
            Debug.Log("Tocando un objeto");

            
            objeto01Animator.SetBool("isFlying", true);
            objeto02Animator.SetBool("isFlying", true);
            objeto03Animator.SetBool("isFlying", true);

            isColliding = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ObjetoColision"))
        {
            Debug.Log("Saliendo del objeto de colision");


            objeto01Animator.SetBool("isFlying", false);
            objeto02Animator.SetBool("isFlying", false);
            objeto03Animator.SetBool("isFlying", false);

            isColliding = false; 
        }
    }
}