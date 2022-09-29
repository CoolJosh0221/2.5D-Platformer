using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartScript : MonoBehaviour
{
    [SerializeField] private GameObject[] ObjectArray;
    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveTo(ObjectArray[0], iTween.Hash("y", 0, "time", 1, "easetype", iTween.EaseType.easeOutBounce));
        iTween.MoveTo(ObjectArray[1], iTween.Hash("x", 10, "easetype",iTween.EaseType.easeOutBounce, "delay", 0.5f));
        iTween.MoveTo(ObjectArray[2], iTween.Hash("x", -10, "easetype",iTween.EaseType.easeOutBounce, "delay", 1, "oncomplete", "after_join", "oncompletetarget",gameObject));
        iTween.MoveTo(ObjectArray[3], iTween.Hash("x", 0, "time", 1, "delay", 1.5, "easetype", iTween.EaseType.easeOutBounce
        ));
        iTween.MoveTo(ObjectArray[4], iTween.Hash("x", 5, "time", 20, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.linear));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void after_join()
    {
        iTween.PunchRotation(ObjectArray[1], iTween.Hash("z", 2, "time", 0.5f, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.linear));
        iTween.PunchRotation(ObjectArray[2], iTween.Hash("z", 2, "time", 0.5f, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.linear));
    }
    
}
