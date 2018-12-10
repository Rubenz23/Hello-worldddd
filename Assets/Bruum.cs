using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bruum : MonoBehaviour {

    int cuenta = 0;
    float velocidad = 0.4f;
    public KeyCode tecla = KeyCode.F1;
    public Text marcador;
    
    
	// Update is called once per frame
	void Update () {
        
       if (cuenta>75) { }
       else {
            if (Input.GetKeyDown(tecla))
            {
                this.transform.Translate(new Vector3(velocidad, 0, 0));

                cuenta++;

                marcador.text = "" + cuenta;

            }
           
        }
       
    }
}

