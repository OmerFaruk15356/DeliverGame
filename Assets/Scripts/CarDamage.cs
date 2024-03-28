using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDamage : MonoBehaviour
{
    [SerializeField] int carHealth = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        carHealth -= 1;

        if(carHealth == 0)
        {
            Destroy(gameObject);
        }
    }

}
