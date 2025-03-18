using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollect : MonoBehaviour
{
    public GameObject porta; // Arrasta a porta aqui no Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            porta.SetActive(true); // Ativa a porta
            Destroy(gameObject); // Destroi a fruta
        }
    }
}
