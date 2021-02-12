using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyElement : MonoBehaviour
{
    public messages message;

    public void TriggerStory()
    {
        FindObjectOfType<messageManager>().StartMessages(message);
    }
}
