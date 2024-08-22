using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public float valorRotar = 10f;

    public void AumentarRotacion()
    {
        transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + valorRotar, gameObject.transform.eulerAngles.z);
    }

    public void DisminuirRotacion()
    {
        transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y - valorRotar, gameObject.transform.eulerAngles.z);
    }
}
