using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostWwiseEvent : MonoBehaviour
{
    
	public AK.Wwise.Event MyEvent;

    void start()
    {
        
    MyEvent.Post(gameObject);
        
    }
}
