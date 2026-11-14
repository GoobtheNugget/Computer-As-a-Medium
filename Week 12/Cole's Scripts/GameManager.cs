using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject player;
    public GameObject gameOverUI;

    public GameObject tryHaderUI;

    private bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameEnd();
    }

    void GameEnd()
    {
        if (playerHealth.health <= 0 && isGameOver == false)
        {
            isGameOver = true;
            StartCoroutine(BeforeEnd());
        }
    }

    IEnumerator BeforeEnd()
    {
        playerHealth.healthText.text = "Health: 0";
        player.SetActive(false);
        tryHaderUI.SetActive(true);
        yield return new WaitForSeconds(3f);
        tryHaderUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
}
