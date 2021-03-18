using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Chain.IsFired = false;

        if (other.CompareTag("Ball"))
        {
            other.GetComponent<Ball>().Split();
        }
    }
}
