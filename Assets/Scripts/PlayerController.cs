using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float turnSpeed = 5;
    public float speed = 5;
    public float jumpHeight = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * jumpHeight);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * turnSpeed);
        
    }
}
