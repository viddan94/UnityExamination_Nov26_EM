using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationRun : MonoBehaviour

{
    public InputActionAsset stevensPlayerAction;
    public Animator stevensAnimator;
    public LimitedPlatformerMovement limitedPlatformerMovement;
    public Rigidbody2D playerRb;

    void Update()
    {
        if (stevensPlayerAction.FindAction("Move").IsPressed())
        {
            stevensAnimator.SetBool("running", true);
        }
        else
            stevensAnimator.SetBool("running", false);

        if (stevensPlayerAction.FindAction("Jump").IsPressed())
        {
            stevensAnimator.SetBool("jumping", true);
        }
        else
            stevensAnimator.SetBool("jumping", false);

        if (playerRb.linearVelocity.y < -0.1f)
        {
            stevensAnimator.SetBool("falling", true);
        }
        else
        {
            stevensAnimator.SetBool("falling", false);
        }
        
            
        
    }

}