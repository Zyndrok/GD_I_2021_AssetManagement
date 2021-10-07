using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCube : MonoBehaviour
{
    private Rigidbody rb;
    private int hitCounter;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(new Vector3(0f, 10f, 0f), ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Environment"))
        {
            hitCounter += 1;
            Debug.Log(hitCounter);
        }
    }
    private void FixedUpdate()
    {
        this.transform.Translate(0.1f, 0f, 0f);
    }
}
