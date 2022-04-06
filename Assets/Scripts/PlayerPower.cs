using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerPower : MonoBehaviour
{

  // Start is called before the first frame update
  void Start()
  {

  }
  // Update is called once per frame
  void Update()
  {

  }
  private void FixedUpdate()
  {
    SuperJump();
    SlowFall();
  }

  private void SuperJump()
  {
    if (Player.isGrounded && (Player.yInput < 0))
    {
      Player.jump = 18f;
    }
    else
    {
      Player.jump = 10f;
    }
  }

  private void SlowFall()
  {
    if (Input.GetButton("Jump") && Player.isFalling)
    {
      Player.rb.gravityScale = 0.2f;
      Player.speed = 4f;
    }
    else
    {
      Player.rb.gravityScale = 3f;
      Player.speed = 10f;
    }
  }
}
