using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerhealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    private float currentHealth;

    public Animator anim;
    public Slider healthBar;

    public bool IsDead = false;
    

    private void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;

        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = currentHealth;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth < 0)
            currentHealth = 0;

        if (healthBar != null)
            healthBar.value = currentHealth;

        if (currentHealth <= 0 && !IsDead)
        {
            Die();
        }
    }
    public void Heal(float amount)
{
    if (IsDead) return;  

    currentHealth += amount;

    if (currentHealth > maxHealth)
        currentHealth = maxHealth;

    if (healthBar != null)
        healthBar.value = currentHealth;
}

    private void Die()
    {
        IsDead = true;
        anim.SetTrigger("IsDead");

        StartCoroutine(RestartLevel());
    }
    private IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    }
