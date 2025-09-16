using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movement : MonoBehaviour
{
    public float speed = 5f;
    public float sprintSpeed = 10f;
    private float moveSpeed;
    public Rigidbody rb;
    public float rotateSpeed;
    private bool isMoving;
    public Animator animator;
    private string currentAnimation;
    public Transform model;
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float yrot = Input.GetAxis("Mouse X");
        float movementz = Input.GetAxis("Vertical");
        float movementx = Input.GetAxis("Horizontal");
        transform.rotation *= Quaternion.Euler(0, yrot*rotateSpeed*Time.deltaTime, 0);
        Vector3 move = new Vector3(movementx, 0, movementz);
        move = transform.rotation * move;
        model.rotation = Quaternion.LookRotation(move.normalized, Vector3.up);
        rb.velocity = move * moveSpeed * Time.fixedDeltaTime;
        bool isSprinting = Input.GetKey(KeyCode.LeftShift);
        isMoving = rb.velocity.magnitude > .2;
        if (isMoving && currentAnimation!="Walk")
        {
            animator.CrossFade("Walk", 0);
            currentAnimation = "Walk";
        }
        if (!isMoving && currentAnimation != "Idle")
        {
            animator.CrossFade("Idle", 0);
            currentAnimation = "Idle";
        }

        if (isSprinting)
        {
            moveSpeed = sprintSpeed;
        }
        else
        {
            moveSpeed = speed;
        }
    }
}
