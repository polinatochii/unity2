using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    [SerializeField] private float health = 100;
     [SerializeField]private float maxHealth = 100;
    public Animator anim;

    private void Start()
    {
        anim= GetComponent<Animator>();
    }

    public bool IsDead=false;
    public void TakeDamage(float damage)

    {
        health=health - damage;
        if (health < 0 )
        {
          health = 0;
        }
        if (health > maxHealth )
        {
          health = maxHealth;
        }
        if(health == 0)
        { 
            IsDead=true;
            anim.SetTrigger("IsDead");
        }
    }
}

