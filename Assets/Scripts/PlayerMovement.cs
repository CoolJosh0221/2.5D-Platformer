using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    public static Vector3 respawnPoint;
    [SerializeField] private Transform groundCheckerTransform = null;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private GameObject fallDetector;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game has started");
        rigidbodyComponent = GetComponent<Rigidbody>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        fallDetector.transform.position = new Vector3(transform.position.x, fallDetector.transform.position.y, transform.position.z);
    }
    // Fixed Update is called every physic update
    private void FixedUpdate()
    {
        rigidbodyComponent.velocity = new Vector3(horizontalInput * 3, rigidbodyComponent.velocity.y, 0);
        if (Physics.OverlapSphere(groundCheckerTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }
        if (jumpKeyWasPressed)
        {
            rigidbodyComponent.AddForce(Vector3.up * 7, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
        }

    }

    private void OnCollisionEnter(Collider collision)
    {
        if (collision.gameObject.layer == 7)
        {
            transform.position = respawnPoint;
        }

    }
}
