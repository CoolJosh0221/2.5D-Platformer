using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartScript : MonoBehaviour
{
    [SerializeField] private GameObject[] ObjectArray;
    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveTo(ObjectArray[0], iTween.Hash("x", 0, "time", 1, "delay", 1, "easetype", iTween.EaseType.easeOutBounce
        ,"oncomplete", "Test", "oncompletetarget",gameObject));
        iTween.MoveTo(ObjectArray[1], iTween.Hash("y", 0, "time", 1, "easetype", iTween.EaseType.easeOutBounce));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Test()
    {
        Debug.Log("Test");
    }
    
}
