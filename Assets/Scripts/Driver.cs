using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;

    [SerializeField] float slowSpeed = 4f;
    [SerializeField] float boosterSpeed = 9f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmaunt = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmaunt = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

         transform.Rotate(0, 0, -steerAmaunt);
         transform.Translate(0, moveAmaunt, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("SpeedBooster"))
        {
            moveSpeed = boosterSpeed;
        }
    }

}
