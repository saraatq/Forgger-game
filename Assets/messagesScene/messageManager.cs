using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageManager : MonoBehaviour
{
    public Text  messageText;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
        
    }
    public void StartMessages(messages message)
    {
        sentences.Clear();
        foreach (string sentence in message.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence (string sentence)
    {

        messageText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            messageText.text += letter;
            yield return null;
        }
    }


}
