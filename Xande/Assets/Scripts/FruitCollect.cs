using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitCollect : MonoBehaviour
{
    public GameObject porta; // Arrasta a porta no Inspector
    public string nomeDaCena; // Define o nome da cena no Inspector

    private bool portaAtivada = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!portaAtivada) // Se for a fruta
            {
                porta.SetActive(true); // Ativa a porta
                portaAtivada = true; // Marca que a porta foi ativada
                Destroy(gameObject); // Destroi a fruta
            }
            else if (collision.gameObject.CompareTag("Porta")) // Se for a porta
            {
                SceneManager.LoadScene(nomeDaCena); // Troca de cena
            }
        }
    }
}

