using UnityEngine;

public class Tap2 : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 3f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = -Mathf.PingPong(Time.time * moveSpeed, moveDistance);
        transform.position = startPos + new Vector3(movement, 0, 0);
    }
}