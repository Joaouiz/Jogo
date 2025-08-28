using UnityEngine;

public class TrashCollision : MonoBehaviour
{
    private TrashIdentifier myTrash;

    void Start()
    {
        myTrash = GetComponent<TrashIdentifier>();
        if (myTrash == null)
            Debug.LogWarning("Esse objeto não tem TrashIdentifier!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TrashIdentifier otherTrash = collision.GetComponent<TrashIdentifier>();

        if (otherTrash != null)
        {
            if (myTrash.type == otherTrash.type)
            {
                Debug.Log("✅ Acertou! " + myTrash.type + " no lugar certo.");
                ScoreManager.Instance.AddPoint(1); // +1 ponto
            }
            else
            {
                Debug.Log("❌ Errou! " + myTrash.type + " não combina com " + otherTrash.type);
                ScoreManager.Instance.AddPoint(-1); // -1 ponto (mas nunca fica < 0)
            }
        }
    }
}
