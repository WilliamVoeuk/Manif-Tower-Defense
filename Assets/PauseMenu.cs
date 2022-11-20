using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
/*    void OnEnable()
    {
        Time.timeScale = 0;
    }*/
    public void OnPause()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }

    public void OnResume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
