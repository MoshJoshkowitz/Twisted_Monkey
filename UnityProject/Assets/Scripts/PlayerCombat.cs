using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform AttackPoint;
    public float AttackRange;
    public float attackDamage;
    public LayerMask EnemyLayers;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
    }

    void Attack()
    {
        // --Play an attack animation--

        // Detect enemies in range
        Collider2D[] HitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, EnemyLayers);

        // Apply damage

        foreach(Collider2D enemy in HitEnemies)
        {
            Debug.Log("Hitted:" + enemy.name);
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        // If there is no AttackPoint stop the code to prevent errors
        if(AttackPoint == null)
        {
            return;
        }

        // Draws a gizmo to visualy see the attack point
        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
}
