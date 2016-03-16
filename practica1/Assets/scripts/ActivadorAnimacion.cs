using UnityEngine;
using System.Collections;

public class ActivadorAnimacion : MonoBehaviour {

    public GameObject objeto;//variables publicas que guardan un gameobject
    public GameObject [] bolos;
    public GameObject bola;
    Vector3 posicionInicialBola;
    Vector3[] posicionInicialBolos=new Vector3[10];

    Quaternion rotacionInicialBola;//variables para guardar posiciones de rotacion
    Quaternion[] rotacionInicialBolos=new Quaternion[10];

    Rigidbody rbBola;//variable para guardar fisicas de un gameobject
    Rigidbody[] rbBolos=new Rigidbody[10];


    public GameObject boton;
    public GameObject menufinal;
    public GameObject mensajeFinal;
    public GameObject puntuacionFinal;

    int contador = 0;//contador para controlar numero de veces que pasa el recogedor

	// Use this for initialization
	void Start () {

        //cuando el juego inicia guardo las posiciones de los bolos y la bola que tienen en el momento inicial
        posicionInicialBola = bola.transform.position;
        rotacionInicialBola = bola.transform.rotation;

        //con este bucle recorremos el array que contiene todos los gameobject de los bolos y a cada bolo le vamos asignando su posicion y sus coordenadas de rotacion
        for(int i = 0; i < bolos.Length; i++)
        {
            rotacionInicialBolos[i] = bolos[i].transform.rotation;
            posicionInicialBolos[i] = bolos[i].transform.position;


        }


    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        //si el triger del objeto que contiene este scrip entra en contacto con un colaider que tiene como tag bola
        if (other.tag == "Bola")
        {
            objeto.GetComponent<Animator>().SetTrigger("animacion");//obtiene el componente animator del objeto que esta colisionando y pone a true el parametro animacion

            for (int i = 0; i < bolos.Length; i++)
            {
                if (bolos[i].GetComponent<caidaBolos>().derribado == false)
                {
                    bolos[i].GetComponent<caidaBolos>().derribado = true;
                }

            }

        }
           



        //si el collaider que entra en contacto tiene como tag recogedor entonces entra dentro de este if y ejecuta su codigo
        else if (other.tag == "recogedor")
        {

            contador++;

            
            rbBola = bola.GetComponent<Rigidbody>();//obtengo las fisicas del objetobola
            rbBola.velocity = Vector3.zero;//pongo la velocidad de sus fisicas a cero
            rbBola.angularVelocity = Vector3.zero;//pongo la velocidad angular a cero para que cuando el objeto vuelva a la posicion inicial se quede quieto y no salga rodando
            bola.transform.position = posicionInicialBola;//igualo el transform de la bola a la posicion que tenia incial
            bola.transform.rotation = rotacionInicialBola;//igualo el transform de la bola en la rotacion que tenia incial


            //con este bucle recorremos el array de bolos y encada posicion le pasamos la posicion inicial que tenia cada bolo y paramos su fisicas de velocidad para que al ponerse en el sitio no se caigan
            for(int i = 0; i < bolos.Length; i++)
            {
                rbBolos[i] = bolos[i].GetComponent<Rigidbody>();
                rbBolos[i].velocity = Vector3.zero;
                rbBolos[i].angularVelocity = Vector3.zero;

                bolos[i].transform.position = posicionInicialBolos[i];
                bolos[i].transform.rotation = rotacionInicialBolos[i];
                bolos[i].SetActive(true);

                //reactivo bolos que desactivo el recogedor y pregunto si la variable bool publica de su scrip esta a verdadero que la ponga a falso para que cuente puntuacion en la siguiente tirada
                if(bolos[i].GetComponent<caidaBolos>().derribado == true)
                {
                    bolos[i].GetComponent<caidaBolos>().derribado = false;
                }


            }


            if (contador == 3)
            {
                //cuando el contador sea igual a 3 activara todos los gameobject que componene el menu final
                boton.SetActive(true);
                menufinal.SetActive(true);
                mensajeFinal.SetActive(true);

                //para cambiar el marcador puntuacion de posicion
                Vector3 nuevaPosicion = new Vector3(599-169, 337-18, 0);
                
                puntuacionFinal.transform.position = nuevaPosicion;
                

            }


        }


    }






}
