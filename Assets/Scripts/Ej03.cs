using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//3. crear una variable pública que permita ingresar texto.permitir que al ejecutar el programa//
//se muestre en la consola un mensaje de saludo que incluya el texto de la variable.por//
//ejemplo, si en la variable se ingresa el texto “ana”, el mensaje en consola debe decir “hola//
//Ana”.//
public class Ej03 : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
