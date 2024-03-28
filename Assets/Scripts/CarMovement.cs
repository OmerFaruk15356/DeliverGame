using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] float slowSpeed;
    [SerializeField] float boostSpeed;
    [SerializeField] float normalSpeed;
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);

        if (moveAmount != 0)
        {
            float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -steerAmount);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Road")
        {
            moveSpeed = normalSpeed;
        }

        else if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }

        else if (other.tag == "Ground")
        {
            moveSpeed = slowSpeed;
        }
    }

}
