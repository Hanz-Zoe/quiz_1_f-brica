using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffset : MonoBehaviour
{
    private Material materialAtual;
    public float velocidade;  
    private float  Offset; 
    // Start is called before the first frame update
    void Start()
    {
        materialAtual = GetComponent<Renderer>().material;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Offset += 0.01f;

        materialAtual.SetTextureOffset("_MainTex", new Vector2(Offset * velocidade, 0));
        
    }
}
