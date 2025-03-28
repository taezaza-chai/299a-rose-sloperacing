using UnityEngine;

public class Goal : MonoBehaviour
{
    public Timer gameManager;  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {
            Debug.Log("Player reached the goal!");
            gameManager.StopTimer();  
        }
    }
}
