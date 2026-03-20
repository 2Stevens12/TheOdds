using UnityEngine;

public class CubeInteract : MonoBehaviour
{
    public ProgressBar progressBar;
    public float increaseAmount = 10f;
    private bool playerIsNear = false;


    void Update()
    {
        if (playerIsNear && Input.GetKeyDown(KeyCode.E))
        {
            progressBar.SetValue(progressBar.currentValue + increaseAmount);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsNear = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsNear = false;
        }
    }
}