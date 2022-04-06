using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  public Transform Sprite;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame 
  void Update()
  {
    Xmoviment();
    Jump();
    PlayerRotation();
  }

  void Xmoviment()
  {
    Vector3 moviment = new Vector3(Player.xInput, 0f, 0f);
    transform.position += moviment * Time.deltaTime * Player.speed;
  }
  void Jump()
  {
    if (Input.GetButtonDown("Jump"))
    {
      if (Player.isGrounded)
      {
        Player.rb.AddForce(transform.up * Player.jump, ForceMode2D.Impulse);
      }
    }
  }
  void PlayerRotation()
  {
    if (Player.xInput != 0)
      Sprite.right = new Vector3(Player.xInput, 0f, 0f);
  }

}
