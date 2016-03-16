using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class puntuacion : MonoBehaviour {

    Text punt;//variable de tipo text donde guardamos el texto

    int puntos = 0;//contador de puntos inicializado a cero



    // Use this for initialization
    void Start()
    {

        punt = GetComponent<Text>();//obtengo el componente text ya que es lo que quiero modificar durante el juego

        punt.text = "PUNTUACIÓN:" + puntos;//modifico el componente tex pongo un string y le añado la variable PUNTOS
    }

    // Update is called once per frame




    public void contadorPuntos()
    {

        puntos++;//incremento el numero de puntos

        punt.text = "PUNTUACIÓN:" + puntos;//vuelvo a modificar el componente texto para que me incremente la variable

    }

}
