using System.Collections;
using TMPro;
using UnityEngine;

public class Dialouge : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    public string[] dialogues =
    {
        "Hey, Player!",
        "Our village is under attack!!",
        "Be careful!"
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ShowDialogue());
        }
    }

    IEnumerator ShowDialogue()
    {
        for (int i = 0; i < dialogues.Length; i++)
        {
            dialogueText.text = dialogues[i];
            //dialogueText.text = dialogues[0];
            //dialogueText.text = "Hello, Player!";

            //second time
            //dialogueText.text = dialogues[1];
            //dialogueText.text = "Welcome to my village!";


            //third time
            //dialogueText.text = dialogues[2];
            //DialogueText.text = "Be careful! There are enemies ahead!";

            yield return new WaitForSeconds(3f);
        }

        dialogueText.text = "";
    }
}
