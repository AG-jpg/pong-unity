using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlColision : MonoBehaviour
{
    public MoverPelota moverPelota;
    public ControlPuntaje controlPuntaje;

    void ReboteRaqueta(Collision2D c)
    {
        Vector3 posicionPelota = this.transform.position;
        Vector3 posicionRaqueta = c.gameObject.transform.position;
        float alturaRaqueta = c.collider.bounds.size.y;

        float x;
        if(c.gameObject.name == "Raqueta1")
        {
            x = 1;
        }else
        {
            {
                x = -1;
            }
        }

        float y = (posicionPelota.y - posicionRaqueta.y) / alturaRaqueta;

        this.moverPelota.AumentarContadorGolpes();
        this.moverPelota.MovimientoPelota(new Vector2(x, y));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Raqueta1" || collision.gameObject.name == "Raqueta2" )
        {
            this.ReboteRaqueta(collision);
        }else if(collision.gameObject.name == "Pared Izquierda")
        {
            this.controlPuntaje.GolJugador2();
        }
        else if(collision.gameObject.name == "Pared Derecha")
        {
            this.controlPuntaje.GolJugador1();
        }
    }
}
