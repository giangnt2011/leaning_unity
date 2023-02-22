using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalMovement;
    [SerializeField] private float verticalMovement;
    [SerializeField] private Rigidbody rb;
    // A field editable from inside Unity with a default value of 5
    [SerializeField] private float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        // This will detect forward and backward movement
        horizontalMovement = Input.GetAxisRaw("Horizontal");

        // This will detect sideways movement
        verticalMovement = Input.GetAxisRaw("Vertical");

        // Calculate the direction to move the player
        Vector3 movementDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;

        // Move the player
        rb.AddForce(movementDirection * speed,  ForceMode.Force);
    }
}
