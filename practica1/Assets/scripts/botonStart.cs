using UnityEngine;
using System.Collections;

public class botonStart : MonoBehaviour {


    public GameObject boton;


   public void OnMouseDown()
    {
        Application.LoadLevelAdditive("Bolos");//cuando clicamos con el raton encima del boton carga la escena del juego de bolos
        boton.SetActive(false);

    }





}
