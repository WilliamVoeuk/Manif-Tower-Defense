using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI roundText;
    // Start is called before the first frame update
    void OnEnable()
    {
        roundText.text = PlayerStats.roundsSurvived.ToString(); 
    }
    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        Time.timeScale = 1;

    }

    public void Menu()
    {
        Debug.Log("Menu Principal");
    }

}
