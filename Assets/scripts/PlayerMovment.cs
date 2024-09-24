using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("----------Movement----------")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Transform orientation;
    [SerializeField] private bool useArrowKeys = true;

    private Vector3 moveDirection;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = 4;
    }

    private void Update()
    {
        PlayerInput();
        SpeedControl();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void PlayerInput()
    {
        moveDirection = Vector3.zero;

        if (useArrowKeys) // Arrow keys for Player 1
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveDirection += orientation.forward;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                moveDirection -= orientation.forward;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveDirection -= orientation.right;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                moveDirection += orientation.right;
            }
        }
        else // WASD keys for Player 2
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveDirection += orientation.forward;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveDirection -= orientation.forward;
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveDirection -= orientation.right;
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveDirection += orientation.right;
            }
        }

        moveDirection.Normalize();
    }

    private void MovePlayer()
    {
        if (moveDirection == Vector3.zero)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
        else
        {
            Vector3 targetVelocity = moveDirection * moveSpeed;
            rb.velocity = new Vector3(targetVelocity.x, rb.velocity.y, targetVelocity.z);
        }
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}
