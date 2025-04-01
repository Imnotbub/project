using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDeathScreen : MonoBehaviour
{
   public GameObject Player;
   public GameObject DeathScreen;

   public GameObject ActiveUI;

    // Update is called once per frame
    void Update()
    {
        if (Player.activeSelf == false)
        {
            ActiveUI.SetActive(false);
            DeathScreen.SetActive(true);
        }
    }
}
