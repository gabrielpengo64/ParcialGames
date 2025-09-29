using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void Credits()
    {
        SceneManager.LoadScene("Credits");

    }
    
     public void StartGame()
    {
        SceneManager.LoadScene("SlaloomRace");

    }
}
