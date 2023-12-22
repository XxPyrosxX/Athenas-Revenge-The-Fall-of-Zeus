using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CameraController : MonoBehaviour
{

    public PlayableDirector timeline;

    void Update()
    {
        if(timeline.time >= timeline.duration)
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
