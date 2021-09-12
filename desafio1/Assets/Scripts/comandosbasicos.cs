using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandosbasicos : MonoBehaviour
{


    public void carregaCena(string nomeCena)
    // Start is called before the first frame update
    
    {
        Application.LoadLevel(nomeCena);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
