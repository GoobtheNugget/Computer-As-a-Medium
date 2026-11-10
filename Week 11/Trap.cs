using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Start()
    {

    }

    public GameObject objectToAppear;

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Makes the hidden object appear
            objectToAppear.SetActive(true);

            playerHealth.health -= 8;
        }
    }
}