using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{

    public Player player;
    public TMP_Text contadorPontos; // Referência para o contador de pontos

    // Update is called once per frame
    void Update()
    {

        if (player.score >= 1)
        {
            SceneManager.LoadScene("Fase2");
        }
    }
}
