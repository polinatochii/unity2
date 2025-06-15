using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerhealth health= collision.GetComponent<playerhealth>();

            if(health != null && !health.IsDead)
            {
                health.TakeDamage(9999);
            }
        }
    }
}
