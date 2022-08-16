using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntajes : MonoBehaviour
{
    [SerializeField] int[] arrayDepuntajes = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es " + ObtenerMayorPuntaje());
        Debug.Log("El indice del nivel con el menor puntaje es " + ObtenerNivelDeMenorPuntaje());
        Debug.Log("El promedio de los puntajes es " + ObtenerPuntajePromedio());
    }

    // Update is called once per frame
    void Update()
    {


    }

    int ObtenerMayorPuntaje()
    {
        int nroMayor = 0;
        //obtener nro mayor y asignalo a la variable
        foreach (int num in arrayDepuntajes)
        {
            if (num > nroMayor)
            {
                nroMayor = num;
            }
        }
        return 1;
    }

    int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivel = 0;
        int menorPuntaje = arrayDepuntajes[0];
        //obtener indice del nivel con menor puntaje}
        for (int i = 1; i < arrayDepuntajes.Length; i++)
        {
            if (arrayDepuntajes[i] < menorPuntaje)
            {
                indiceNivel = i;
                menorPuntaje = arrayDepuntajes[i];
            }
        }

        return indiceNivel;
    }

    float ObtenerPuntajePromedio()
    {
        int total = 0;
        for (int i = 0; i < arrayDepuntajes.Length; i++)
        {
            total += arrayDepuntajes[i] / arrayDepuntajes.Length;
            return total;
        }
        return total;
    }
}

