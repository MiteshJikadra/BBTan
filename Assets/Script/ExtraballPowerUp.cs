﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraballPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            BallManager1.BM1.extraBallPowerup++;
            Destroy(this.gameObject);
        }
    }
}
