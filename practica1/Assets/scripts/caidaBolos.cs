using UnityEngine;
using System.Collections;

public class caidaBolos : MonoBehaviour {

    public bool derribado;

    public GameObject marcador;
    //public GameObject euler;

    

    //Quaternion posicionRotacion;

    // Use this for initialization
    void Start()
    {
        derribado = false;
        //posicionRotacion = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

       

          if (!derribado &&
           ((transform.rotation.eulerAngles.x > transform.rotation.x + 45 && transform.rotation.eulerAngles.x < transform.rotation.x - 315) ||
           (transform.rotation.eulerAngles.z > 45 && transform.rotation.eulerAngles.z < 315)))
            {
                 derribado = true;
                  marcador.GetComponent<puntuacion>().contadorPuntos();


             }




    
    /*
        if (collision.gameObject.tag == "recogedor")
        {

            derribado = false;
        }




        else if(collision.gameObject.tag=="Bola")
        {

            if(!derribado && posicionRotacion != transform.rotation)
            {
                derribado = false;
                marcador.GetComponent<puntuacion>().contadorPuntos();


            }



        }

    */

    }
}
