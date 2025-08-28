using UnityEngine;

public class LixeiraFlappySpawner : MonoBehaviour
{
    public GameObject lixeiraPrefab;      // Prefab da lixeira
    public float intervaloSpawn = 2f;     // Tempo entre spawn de lixeiras
    public float posXSpawn = 10f;         // Posição X onde as lixeiras surgem
    public float alturaMin = -2f;         // Altura mínima aleatória
    public float alturaMax = 3f;          // Altura máxima aleatória
    public float velocidade = 5f;         // Velocidade que a lixeira se move para a esquerda

    private void Start()
    {
        InvokeRepeating("SpawnLixeira", 1f, intervaloSpawn);
    }

    void SpawnLixeira()
    {
        // Posição aleatória no eixo Y
        float posY = Random.Range(alturaMin, alturaMax);
        Vector3 spawnPos = new Vector3(posXSpawn, posY, 0);

        // Instancia a lixeira
        GameObject lixeira = Instantiate(lixeiraPrefab, spawnPos, Quaternion.identity);

        // Adiciona BoxCollider se não houver
        if (lixeira.GetComponent<BoxCollider>() == null)
        {
            BoxCollider collider = lixeira.AddComponent<BoxCollider>();
            collider.isTrigger = false;
        }

        // Adiciona Rigidbody se não houver
        if (lixeira.GetComponent<Rigidbody>() == null)
        {
            Rigidbody rb = lixeira.AddComponent<Rigidbody>();
            rb.isKinematic = true; // Mantém a lixeira fixa para colisão
        }

        // Adiciona movimento para a esquerda
        lixeira.AddComponent<LixeiraMover>().velocidade = velocidade;
    }
}
