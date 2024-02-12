using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ContinuosMovementPhysics : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionRef;
    public float jumpForce = 100;
    public float speed = 1;
    public InputActionProperty moveInputSource;
    public GameObject player;
    public Transform directionSource;
    private Vector2 moveAxis;
    public Rigidbody rb;
    
    public bool isGrounded;
    public CapsuleCollider bodyColl;
    public LayerMask groundLayer;

    // Update is called once per frame
    void Start()
    { 
        rb = GetComponent<Rigidbody>();
        //jumpActionRef.action.performed += OnJump;
    }
    
    void Update()
    {
        moveAxis = moveInputSource.action.ReadValue<Vector2>(); 
        
        bool jumpInput = jumpActionRef.action.WasPressedThisFrame();
        if(jumpInput && isGrounded){
            rb.velocity = Vector3.up * jumpForce;
        }

    }
    
    void FixedUpdate()
    {
        isGrounded = CheckIfGrounded();
        Quaternion yaw = Quaternion.Euler(0, directionSource.eulerAngles.y, 0);
        Vector3 direction = yaw * new Vector3(moveAxis.x, 0, moveAxis.y);

        rb.MovePosition(rb.position + direction * Time.fixedDeltaTime * speed);
     
    }

    public bool CheckIfGrounded()
    {
        Vector3 start = bodyColl.transform.TransformPoint(bodyColl.center);
        float rayLength = bodyColl.height / 2 - bodyColl.radius + 0.05f;

        bool hasHit = Physics.SphereCast(start, bodyColl.radius, Vector3.down, out RaycastHit hitinfo, rayLength, groundLayer);
        return hasHit;
    }
}

    