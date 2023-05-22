using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.controllers;



namespace UnityProject2.movers
{
    public class jumpMover
    {
        Rigidbody rb;
        public jumpMover(PlayerController pC)
        {
            rb = pC.GetComponent<Rigidbody>();
        }

        public void addJumpForce(float jumpforce)
        {
            if (rb.velocity.y != 0) return;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * Time.deltaTime * jumpforce);
        }

    }



}
