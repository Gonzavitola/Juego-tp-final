using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireboymovement : MonoBehaviour
{

    public float movementSpeed;
    public float jumpForce;
    public int maxJumps;

    int hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            hasJump = maxJumps;
        }
    }
}
