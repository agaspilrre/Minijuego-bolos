using UnityEngine;
using System.Collections;

public class sRecogedor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    void OnCollisionEnter(Collision collision)
    {

        //desactivamos el objeto con el que el recogedor entra en colision

        collision.gameObject.SetActive(false);


        if(collision.gameObject.tag=="Bola")
        {
            collision.gameObject.SetActive(true);
        }


    }





}
