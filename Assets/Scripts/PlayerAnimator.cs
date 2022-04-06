using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

  public static Animator animator;

  // Start is called before the first frame update
  void Start()
  {
    animator = GameObject.FindGameObjectWithTag("PlayerSprite").GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    animator.SetBool("isGrounded", Player.isGrounded);
    animator.SetBool("isFalling", Player.isFalling);
    if (Player.xInput != 0)
    {
      animator.SetInteger("xInput", 1);
    }
    else
    {
      animator.SetInteger("xInput", 0);
    }
    if (Player.yInput < 0)
    {
      animator.SetInteger("yInput", 1);
    }
    else
    {
      animator.SetInteger("yInput", 0);
    }
  }
  private void LateUpdate()
  {

  }
  public static void attack()
  {
    animator.SetTrigger("attack");
  }
}
