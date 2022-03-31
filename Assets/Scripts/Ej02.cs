using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    //Realiza un programa que, siendo num1 y num2 variables enteras con valores 4 y 5 respectivamente, realice la operacion//
    //correspondiente y muestre el resultado en pantalla: a. Suma  b. Producto//
    int num1 = 4;
    int num2 = 5;
 
    // Start is called before the first frame update
    void Start()
    {
        int suma = num1 + num2;
        Debug.Log("La suma entre 4 y 5 es " + suma);
        int producto = num1 * num2;
        Debug.Log("El producto entre 4 y 5 es " + producto);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
