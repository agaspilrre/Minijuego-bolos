using UnityEngine;
using System.Collections;

public class botonMenu : MonoBehaviour {

    public void OnMouseDown()
    {
        Application.LoadLevel("MenuInicio");//cuando clicamos con el raton encima del boton carga la escena del juego de bolos

    }

}
