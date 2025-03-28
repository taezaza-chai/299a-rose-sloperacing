using UnityEngine;

public class Goal : MonoBehaviour
{
    public Timer gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.StopTimer();
            Debug.Log("Finish Line Reached!");
        }
    }
}

