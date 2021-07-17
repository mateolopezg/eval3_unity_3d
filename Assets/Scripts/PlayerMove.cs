using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rigidbody;
    public GameObject Malo;

    public float tiempoMalo;
    private float nuevoMalo;

    public GameObject inBala;
    public GameObject bala;
    public float velocidad;

    void Update()
    {
        MovimientoPlayer();
        CreacionEsferas();
    }


    public void MovimientoPlayer()
    {
        if (Input.GetKey("d"))
        {
            rigidbody.velocity = transform.right * 12;
        }

        if (Input.GetKey("a"))
        {
            rigidbody.velocity = -transform.right * 12;
        }

        if (Input.GetKey("s"))
        {
            GameObject temp = Instantiate(bala,inBala.transform.position,inBala.transform.rotation);
            Rigidbody tempRigi = temp.GetComponent<Rigidbody>();
            tempRigi.AddForce(transform.up * velocidad);

            Destroy(temp, 5.0f);
        }
    }

    public void CreacionEsferas()
    {
        if (nuevoMalo <= 0)
        {
            nuevoMalo = tiempoMalo;
            int positionMalo = Random.Range(-5, 7);
            GameObject temp = Instantiate(Malo, new Vector3(positionMalo,10,0), Quaternion.identity);
            Destroy(temp, 5);
        }
        nuevoMalo -= Time.deltaTime;
    }
}
