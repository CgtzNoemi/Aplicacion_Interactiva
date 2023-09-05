using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDetectar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Tocando algo");
    }
}
