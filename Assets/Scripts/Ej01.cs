using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realiza un programa donde se cree una variable entera num1, que inicialmente valdra 0.//
//Luego incrementa su valor en 2 y mostrarlo por pantalla.//
//Despues mostra el resultado de multiplicarlo por si mismo//
public class Ej01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1;
        num1 = 0;
        num1 = num1 + 2;
        Debug.Log(num1);
        num1 = num1 * num1;
        Debug.Log(num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
