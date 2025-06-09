using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour

{
    public float damage = 40;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        playerhealth health = collision.gameObject.GetComponent<playerhealth>();

        if (health == null)
        {
            return;
        }

        health.TakeDamage(damage);

    }
}
