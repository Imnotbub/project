using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreenButtons : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    

}
