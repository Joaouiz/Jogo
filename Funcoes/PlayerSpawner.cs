using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [Header("Prefabs dos jogadores")]
    public GameObject[] playerPrefabs; // Arraste aqui seus prefabs no inspetor
    
    [Header("Posição de Spawn")]
    public Transform spawnPoint; // Onde o jogador vai nascer

    private void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        if (playerPrefabs.Length == 0)
        {
            Debug.LogWarning("Nenhum prefab de jogador adicionado!");
            return;
        }

        // Escolhe um prefab aleatório
        int randomIndex = Random.Range(0, playerPrefabs.Length);

        // Instancia o jogador
        Instantiate(playerPrefabs[randomIndex], spawnPoint.position, Quaternion.identity);
    }
}
