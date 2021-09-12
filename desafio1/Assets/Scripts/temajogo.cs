using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class temajogo : MonoBehaviour
{
    public Button btn_play;
    public Text theme_name_txt;

    public GameObject level_info;
    public Text info_level_txt;
    public GameObject Estrela1;
    public GameObject Estrela2;
    public GameObject Estrela3;

    public string[] nomeTema;
    public int numeroQuestoes; 


    private int idTema;
    // Start is called before the first frame update
    void Start()
    {
        idTema = 0;
        info_level_txt.text = nomeTema[idTema];
        info_level_txt.text = "Você acertou x de x questões";
        level_info.SetActive(false);
        Estrela1.SetActive(false);
        Estrela2.SetActive(false);
        Estrela3.SetActive(false);

    }
    public void selecioneTema (int i)
    {
        theme_name_txt.text = nomeTema[i];
        level_info.SetActive(true);
        
        int notaFinal = 0; //editar depois
        int acertos = 0;  // editar depois
        
        info_level_txt.text = "Você acertou"+acertos.ToString()+numeroQuestoes.ToString()+" questões!";
        btn_play.interactable = true;
        idTema = i; 
    }
    public void jogar()
    {
        Application.LoadLevel("T"+idTema.ToString());
    }



    // Update is called once per frame
    void Update()
    {


    }
   
    
}
