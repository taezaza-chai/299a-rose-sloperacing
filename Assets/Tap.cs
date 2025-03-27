using UnityEngine;

public class Tap : MonoBehaviour
{
    public float moveSpeed = 5f;  
    public float moveDistance = 10f;  
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * moveSpeed, moveDistance);
        transform.position = startPos + new Vector3(movement, 0, 0);  
    }
}