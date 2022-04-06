using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  private float direction, distace, speed, fullHp, currentHp;

  // Start is called before the first frame update
  void Start()
  {
    speed = 4f;
    fullHp = 20f;
    direction = -1f;
    distace = 0f;
    currentHp = fullHp;
  }

  // Update is called once per frame
  void Update()
  {
    Xmoviment();
  }

  void Xmoviment()
  {
    Vector3 moviment = new Vector3(direction, 0f, 0f);
    transform.position += moviment * Time.deltaTime * speed;
    distace = distace + 1f;
    transform.right = new Vector3(-direction, 0f, 0f);
    if (distace >= 200)
    {
      distace = 0f;
      if (direction == -1f)
      {
        direction = 1f;
      }
      else
      {
        direction = -1f;
      }

    }
  }

  public void takeDamage(float damage)
  {
    currentHp -= damage;
    if (currentHp <= 0)
    {
      Die();
    }
  }

  void Die()
  {
    Destroy(gameObject);
  }

}
