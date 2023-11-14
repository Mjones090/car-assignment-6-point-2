using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //private float speed = 20.0f;
    [SerializeField] private float horsePower = 0;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;



    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Move vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       //playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput * horsePower)
        //rotate car
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
