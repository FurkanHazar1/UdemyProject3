using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.controllers;




namespace UnityProject2.movers
{
    public class HorizontalMover
    {
        PlayerController playerController;
        public HorizontalMover(PlayerController _playerController)
        {
            playerController = _playerController;
        }

        public void fixedTick(float tickRate,float moveSpeed)
        {
            playerController.transform.Translate(Vector3.right * tickRate * moveSpeed * Time.deltaTime);
        }
    }
}

