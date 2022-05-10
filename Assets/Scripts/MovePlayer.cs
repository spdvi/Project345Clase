using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    float vInput, hInput;
    [SerializeField] float moveSpeed = 100f;
    Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        //playerRb = this.gameObject.GetComponent<Rigidbody>();
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");  // A D esquerra dreta
        vInput = Input.GetAxis("Vertical");  // W S davant darrere

        //playerRb.MovePosition(Vector3.forward * vInput);
        //playerRb.MovePosition(transform.position
        //    + transform.forward * vInput * moveSpeed * Time.deltaTime);
        //playerRb.MovePosition(transform.position + transform.right * hInput * moveSpeed * Time.deltaTime);
        playerRb.MovePosition(transform.position
            + (transform.forward * vInput + transform.right * hInput) * moveSpeed * Time.deltaTime);


    }
}
