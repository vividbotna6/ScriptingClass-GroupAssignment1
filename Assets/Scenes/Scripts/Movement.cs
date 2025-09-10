using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //movespeed, changeable in editor
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement floats
        float Z = Input.GetAxis("Horizontal");
        float X = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(-X, 0, Z);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}
