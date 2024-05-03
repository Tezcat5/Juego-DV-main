using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded;

    public Animator anim;

    MovementYUVI playerScript;

    void Awake()
    {
        anim = GetComponentInParent<Animator>();
        playerScript =GetComponentInParent<MovementYUVI>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        
        
        isGrounded = true;
        anim.SetBool("Saltando", false);
    }

    void OnTriggerExit2D(Collider2D collider)

    {
        isGrounded = false;
    }

}
