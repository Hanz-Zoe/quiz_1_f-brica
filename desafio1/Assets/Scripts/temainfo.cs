using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temainfo : MonoBehaviour
{
    public int idTema;

    public GameObject Estrela1;
    public GameObject Estrela2;
    public GameObject Estrela3;
    private int notaFinal; 
    // Start is called before the first frame update
    void Start()
    {
        Estrela1.SetActive(false);
        Estrela2.SetActive(false);
        Estrela3.SetActive(false);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
