using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirEnlaces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrirEnlace(string sitioWebURL)
    {
        Application.OpenURL(sitioWebURL);
    }
}
