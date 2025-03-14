using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int life = 3;
    public int lifeMax;
    public Transform foot;
    public int speed = 5, jumpStrength = 5;
    public Rigidbody2D body;
    public Animator animator;
    public int direction = 1;
    public int score;
    private bool isDead;
    private float horizontal;
    private bool groundCheck;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        Time.timeScale = 1;
        lifeMax = life;
        spriteRenderer = GetComponent<SpriteRenderer>(); // Pega o SpriteRenderer do player
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); // Pegando o input do jogador

        // Define a direção baseado no movimento
        if (horizontal < 0)
        {
            direction = -1; // Esquerda
            spriteRenderer.flipX = true; // Vira o sprite pra esquerda
        }
        else if (horizontal > 0)
        {
            direction = 1;  // Direita
            spriteRenderer.flipX = false; // Vira o sprite pra direita
        }

        // Aplica o movimento
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);

        // Atualiza a animação de movimento
        animator.SetBool("Speed", Mathf.Abs(horizontal) > 0);

        // Verifica se está no chão
        groundCheck = Physics2D.OverlapCircle(foot.position, 0.05f);

        // Pulo
        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            body.AddForce(new Vector2(0, jumpStrength * 100));
        }
    }
}
