using UnityEngine;

public class Dard : MonoBehaviour
{
    public float increasedDrag = 3f;  
    public float normalDrag = 0.5f;  

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.drag = increasedDrag; 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.drag = normalDrag;  
        }
    }
}
