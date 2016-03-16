using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lanzamientos : MonoBehaviour {

    

    Text texto;//variable de tipo text donde guardamos el texto

    int numLanzamientos=0;//contador de numero de lanzamientos inicializado a cero



	// Use this for initialization
	void Start () {

        texto = GetComponent<Text>();//obtengo el componente text ya que es lo que quiero modificar durante el juego

        texto.text = "LANZAMIENTOS:" + numLanzamientos;//modifico el componente tex pongo un string y le añado la variable lanzamientos
    }
	
	// Update is called once per frame
	



    public void contadorLanzamientos()
    {

        numLanzamientos++;//incremento el numero de lanzamientos

        texto.text = "LANZAMIENTOS:" + numLanzamientos;//vuelvo a modificar el componente texto para que me incremente la variable

    }



}
