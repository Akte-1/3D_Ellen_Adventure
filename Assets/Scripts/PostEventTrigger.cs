using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostEventTrigger : MonoBehaviour
{
    public AK.Wwise.Event m_wwiseEvent = null; 

    public void TriggerWwiseEvent()
    {
        m_wwiseEvent.Post(gameObject);
    }


}
