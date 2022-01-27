using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }


    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        // PLAY HURT ANIMATION HERE

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy Died");
        // PLAY DEATH ANIMATION HERE

        StartCoroutine(Death());
    }

    private IEnumerator Death()
    {
        // Delays the death to let animation play
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
