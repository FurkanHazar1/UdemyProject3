using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.movers;

namespace UnityProject2.controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private float tick;
        [SerializeField] private HorizontalMover horizontalMover;
        [SerializeField] private float jumpForce;
        [SerializeField] private bool isJumpForce=false;
        [SerializeField] private jumpMover jump_mover;
        private void Awake()
        {
            horizontalMover = new HorizontalMover(this);
            jump_mover = new jumpMover(this);    
        }
        private void FixedUpdate()
        {
            horizontalMover.fixedTick(tick, moveSpeed);
            if (isJumpForce) {
                jump_mover.addJumpForce(jumpForce);
            }
            isJumpForce = false;
            
        }
    }

}
