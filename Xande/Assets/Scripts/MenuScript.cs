using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private string NomeDoLevelDeJogo;
    [SerializeField] private GameObject PainelMenuInicial;
    public void Jogar()
    {
        SceneManager.LoadScene(NomeDoLevelDeJogo);
    }
    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }




}
