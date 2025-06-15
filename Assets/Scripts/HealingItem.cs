using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
   
    public float healAmount = 30f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerhealth  health =collision.GetComponent<playerhealth>();
            if (health!= null)
            {
                health.Heal(healAmount);
                Destroy(gameObject);
            }
        }
    }
}
