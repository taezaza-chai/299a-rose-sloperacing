using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1500f; 
    public float turnSpeed = 50f; 

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Vertical"); 
        float turnInput = Input.GetAxis("Horizontal"); 

      
        Vector3 moveForce = transform.forward * moveInput * speed * Time.deltaTime;
        rb.AddForce(moveForce, ForceMode.Acceleration);

       
        if (moveInput != 0) 
        {
            Quaternion turnRotation = Quaternion.Euler(0, turnInput * turnSpeed * Time.deltaTime, 0);
            rb.MoveRotation(rb.rotation * turnRotation);
        }
    }

    
}
