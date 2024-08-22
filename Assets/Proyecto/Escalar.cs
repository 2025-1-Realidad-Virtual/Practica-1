using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalar : MonoBehaviour
{
    public float valorEscalar = 0.5f;
    public Vector3 maxEscala = new Vector3(3f, 3f, 3f);

    public void AumentarEscala()
    {
        if (gameObject.transform.localScale.x + valorEscalar < maxEscala.x)
        {
            gameObject.transform.localScale += new Vector3(valorEscalar, valorEscalar, valorEscalar);
        }
    }

    public void DisminuirEscala()
    {
        if(gameObject.transform.localScale.x - valorEscalar > 0f)
        {
            gameObject.transform.localScale -= new Vector3(valorEscalar, valorEscalar, valorEscalar);
        }
    }
}
