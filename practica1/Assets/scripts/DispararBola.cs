using UnityEngine;
using System.Collections;

public class DispararBola : MonoBehaviour {


    Rigidbody rb;//variable tipo riggibody
    Transform tr;//variable tipo transform
    Vector3 moviLateral;//variable de tipo vector 3

    float horizontal;//variable tipo float

    public float fuerza;//variable publica tipo float para modificar la fuerza a la que sale disparada
    public int velocidad;//variable publica para modificar la velocidad que usaremos para el movimiento lateral del objeto

   
    public GameObject lanzamientos;//variable que guarda el objeto que contiene el texto de lanzamientos

    // Use this for initialization
    void Start () {


        tr = transform; //al ejecutar el programa la variable tr le asignamos las coordenadas del objeto que contiene el script
        rb = GetComponent<Rigidbody>();//asignamos a la variable rb el rigibody que contiene el objeto


        

    }

    // Update is called once per frame
    void Update () {


        float horizontal = Input.GetAxis("Horizontal");//asignamos las teclas izquierda y derecha con getaxis y las guardamos en la variable float horizontal
        Vector3 moviLateral = new Vector3(horizontal, 0, 0);//asignamos el movimiento horizontal en la coordenada x ya que queremos que el objeto se mueve en ese eje y lo guardamos en la variable vector3

        transform.Translate( moviLateral * velocidad * Time.deltaTime);//multiplicamos el movilateral x la variable velocidad y xtimedelta time para generar el movimiento horizontal de la bola


        

    }



    //funcion que detecta si el boton del raton a clicado el objeto de este script
    public void OnMouseDown()
    {

        rb.AddForce(tr.forward * fuerza, ForceMode.Impulse);//esta funcion aplica una fuerza de disparo a la pelota

        lanzamientos.GetComponent<lanzamientos>().contadorLanzamientos();//obtengo el componente scrip del objeto lanzamientos y llamo a su funcion contador lanzamientos


    }










}
