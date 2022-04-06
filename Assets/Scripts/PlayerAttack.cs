using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

  private Transform attackCheck;
  public float attackRange, damage;
  public LayerMask enemiesLayer;
  // Start is called before the first frame update
  void Start()
  {
    attackRange = 0.8f;
    attackCheck = GameObject.FindWithTag("attackCheck").transform;
    damage = 20;
  }


  // Update is called once per frame
  void Update()
  {
    if (Input.GetButton("Fire1"))
    {


      PlayerAnimator.attack();

      Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackCheck.position, attackRange, enemiesLayer);
      foreach (Collider2D enemy in hitEnemies)
      {
        enemy.GetComponent<Enemy>().takeDamage(damage);
        Debug.Log("hit enemy " + enemy.name);
      }

    }
  }

  void OnDrawGizmosSelected()
  {
    if (attackCheck == null)
      return;

    Gizmos.DrawWireSphere(attackCheck.position, attackRange);
  }

}
