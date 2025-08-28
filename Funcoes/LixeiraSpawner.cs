using UnityEngine;

public class LixeiraSpawner : MonoBehaviour
{
    public GameObject[] lixeiras; // arraste os 4 prefabs aqui no Inspector
    public float spawnRate = 2f; // tempo entre spawns
    public float spawnX = 10f;   // posição X fora da tela
    public float minY = -2f;     // altura mínima
    public float maxY = 2f;      // altura máxima

    void Start()
    {
        InvokeRepeating("SpawnLixeira", 1f, spawnRate); // chama SpawnLixeira a cada spawnRate segundos
    }

    void SpawnLixeira()
    {
        // escolhe aleatoriamente um prefab
        int index = Random.Range(0, lixeiras.Length);
        GameObject lixeiraEscolhida = lixeiras[index];

        // escolhe altura aleatória
        float y = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, y, 0f);

        // instancia a lixeira
        Instantiate(lixeiraEscolhida, spawnPos, Quaternion.identity);
    }
}
