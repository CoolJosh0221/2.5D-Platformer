using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveTo(gameObject, iTween.Hash("x", 0, "time", 3, "delay", 3, "easetype", iTween.EaseType.easeOutBounce));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
