using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("HIIIIIIIIIIIIIIIIIIIIII");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(1, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-1, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, 1));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0, -1));
        }
    }
}
