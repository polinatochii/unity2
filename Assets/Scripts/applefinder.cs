using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applefinder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        Inventory playerInventoy = null;
        playerInventoy = collision.gameObject.GetComponent<Inventory>();

        Destroy(gameObject);
    }
}
