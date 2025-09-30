using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] Sprite spriteQuieto;
    [SerializeField] Sprite spriteCaminando;

    private float moverHorizontal;
    private Rigidbody2D miRigidbody2D;
    private SpriteRenderer miSprite;
    private float tiempoCambio = 0f;
    private bool mostrarSprite1 = true;

    private void OnEnable()
    {
        miRigidbody2D = GetComponent<Rigidbody2D>();
        miSprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        moverHorizontal = Input.GetAxis("Horizontal");

        // Rotar sprite
        if (moverHorizontal < 0) miSprite.flipX = true;
        else if (moverHorizontal > 0) miSprite.flipX = false;

        // Animación de caminata
        bool estaCaminando = Mathf.Abs(moverHorizontal) > 0.1f;

        if (estaCaminando)
        {
            tiempoCambio += Time.deltaTime;
            if (tiempoCambio > 0.2f) // Cambia cada 0.2 segundos
            {
                mostrarSprite1 = !mostrarSprite1;
                miSprite.sprite = mostrarSprite1 ? spriteQuieto : spriteCaminando;
                tiempoCambio = 0f;
            }
        }
        else
        {
            miSprite.sprite = spriteQuieto;
            tiempoCambio = 0f;
        }
    }

  private void FixedUpdate()
{
    float velocidadActual = GameManager.Instance.GetVelocidadJugador();
    miRigidbody2D.linearVelocity = new Vector2(moverHorizontal * velocidadActual, miRigidbody2D.linearVelocity.y);
}
}