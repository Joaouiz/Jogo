using UnityEngine;

public enum TrashType
{
    Plastico,
    Metal,
    Papel,
    Organico
}

public class TrashIdentifier : MonoBehaviour
{
    [Header("Tipo de lixo/lixeira")]
    public TrashType type;
}
