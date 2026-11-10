# Week 11
## I did tasks 1-2, while Nicolas did task 3
## Below are the edited/newly created scripts

### Trap Script
```csharp
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
```

### HealthPack Script
```csharp
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object touching the health pack is the Player
        if (other.CompareTag("Player"))
        {
            // Get the PlayerHealth component directly from the player that touched it
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                // If playerhealth = 100, do nothing
                if (playerHealth.health >= 100)
                {
                    return;
                }

                // If its anything else +10
                playerHealth.health += 10;

                // Ensure health doesn't accidentally exceed 100
                if (playerHealth.health > 100)
                {
                    playerHealth.health = 100;
                }

                // Destroy the health pack item itself
                Destroy(gameObject);
            }
        }
    }
}
```

### Player Mana Script

```csharp
using TMPro;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Mana Title in the game and amount
    void Update()
    {
        manaText.text = "Mana: " + mana;
    }
}
```