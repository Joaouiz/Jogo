using UnityEngine;

public class LixeiraMover : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;

        // Opcional: destrói lixeira quando sair da tela para economizar memória
        if(transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
