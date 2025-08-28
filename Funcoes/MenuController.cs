using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Jogar()
    {
        // Carrega a cena do jogo
        SceneManager.LoadScene("Jogo");
    }
}
