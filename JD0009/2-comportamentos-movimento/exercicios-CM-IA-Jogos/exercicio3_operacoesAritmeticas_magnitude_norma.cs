using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio3_operacoesAritmeticas_magnitude_norma : MonoBehaviour
{
    public Vector2 v1 = new Vector2(0, 0);
    public Vector2 v2 = new Vector2(1, 1);
    public Vector2 v3 = new Vector2(2, 2);

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.LogFormat("A Longitude de {0} é {1}", v3, Magnitude(v3));
            Debug.LogFormat("O vetor {0} normalizado é {1}", v3, Normalizar(v3));
            Debug.LogFormat("O vetor {0} normalizado com 'normalized' é {1}", v3, v3.normalized);
        }
   
    }

    float Magnitude(Vector2 v)
    {
        return Mathf.Sqrt(v.x * v.x + v.y * v.y);
    }

    Vector2 Normalizar(Vector2 v)
    {
        return v / Magnitude(v);
    }

}
