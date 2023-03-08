using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandScript : MonoBehaviour
{
    public Rigidbody2D rb;
//Links camera
    public Camera camera;

   
//Gets mouse position
    Vector2 mousePos;

   
    
   
    void Update()
    {
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        
        

    }

    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
