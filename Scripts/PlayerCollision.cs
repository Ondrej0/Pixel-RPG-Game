using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    private float health = 100;

    private bool isUnderAttack;

    public Slider healthBar;

//Checks if life is at 0
    void FixedUpdate()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if(isUnderAttack)
        {
            health = health - 15 * Time.deltaTime;
        }
        
        healthBar.value = health;
         
        Debug.Log(health);
    }

//Collision with a ghost that takes away life
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if(collision.gameObject.CompareTag("Ghost"))
    {
       isUnderAttack = true;
    }
   }
   private void OnTriggerExit2D(Collider2D collision)
   {
    if(collision.gameObject.CompareTag("Ghost"))
    {
       isUnderAttack = false;
    }
   }
}
