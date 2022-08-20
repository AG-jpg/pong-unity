using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Raqueta2IA : MonoBehaviour
{
    public float velocidadMovimiento;
    public GameObject pelota;

    private void FixedUpdate()
    {
        if(Mathf.Abs(this.transform.position.y - pelota.transform.position.y) > 50)
        {
            //Mover Raqueta
            if(transform.position.y < pelota.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * velocidadMovimiento;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1) * velocidadMovimiento;
            }
        }
        else
        {
            //No Mover Raqueta
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }
}
