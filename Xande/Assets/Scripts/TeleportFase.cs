using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportFase : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Verifica se o objeto que colidiu tem a tag "Player"
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // Obt�m o �ndice da cena atual
            SceneManager.LoadScene(currentSceneIndex + 1); // Carrega a pr�xima cena
        }
    }
}
