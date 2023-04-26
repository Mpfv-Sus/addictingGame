using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float speed;
    public BoxCollider collider;

    [SerializeField] Vector3 movement;

    [SerializeField] bool jumping = false;
    [SerializeField] bool crouching = false;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask ground;
    public bool onGround = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        movement.x = movement.x + speed * Time.fixedDeltaTime;

        rb.velocity = movement;

        if(!onGround)
        {
           
                movement.y -= 0.125f;
            
          
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            crouching = true;
            collider.size = new Vector3(1, 0.5f, 1);
            collider.center = new Vector3(0, -0.25f, 0);
        }
        else
        {
            crouching = false;
            collider.size = new Vector3(1, 1, 1);
            collider.center = Vector3.zero;
        }
        onGround = Physics.CheckSphere(groundCheck.position, groundDistance, ground);

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            movement.y = 7.5f;
        }

        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, 3, Camera.main.transform.position.z);
    }
}
