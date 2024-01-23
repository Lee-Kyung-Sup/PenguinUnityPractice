using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : CharacterAnimation
{
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Animation;
    }
    
    public void Animation(Vector2 direction)
    {
        animator.SetBool("isWalking", direction.magnitude > 0);
    }
}
