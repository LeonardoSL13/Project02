using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public static float speed, jump, xInput, yInput;
  public static bool isGrounded, isFalling;
  private Transform groundCheck;
  public LayerMask groundLayer;

  public static Rigidbody2D rb;

  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    groundCheck = GameObject.FindWithTag("groundCheck").transform;
    speed = 10f;
    jump = 6f;

  }
  // Update is called once per frame
  void Update()
  {
  }
  private void FixedUpdate()
  {
    xInput = Input.GetAxis("Horizontal");
    yInput = Input.GetAxis("Vertical");
    isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    isFalling = !isGrounded && rb.velocity[1] < 0f;

  }

}
