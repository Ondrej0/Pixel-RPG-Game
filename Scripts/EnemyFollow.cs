using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;

    public Transform target;

    public float minimumDistance;

    public float maxDistance;

    public Animator animator;

    
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > minimumDistance && Vector2.Distance(transform.position, target.position) < maxDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            animator.SetBool("isAttacking", false);
        }
        else if (Vector2.Distance(transform.position, target.position) <= maxDistance)
        {
            animator.SetBool("isAttacking", true);
        }
    }
}
