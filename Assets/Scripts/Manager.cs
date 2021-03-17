using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    [SerializeField] GameObject[] gameOverComponents;
    [SerializeField] GameObject[] startGameComponents;
    [SerializeField] GameObject scoreObject;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; // возобновления игри после паузы
        DisableUIComponents(gameOverComponents);
        EnableUIComponents(startGameComponents);
        scoreObject.SetActive(false);

    }

    public void EnableScore()
    {
        scoreObject.SetActive(true);
    }

    public void DisableStartUI()
    {
        DisableUIComponents(startGameComponents);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        EnableUIComponents(gameOverComponents);
        DisableUIComponents(startGameComponents);
    }
    private void DisableUIComponents(GameObject[] objectsToDisable)
    {
        foreach (GameObject obj in objectsToDisable)
        {
            obj.SetActive(false);
        }
    }

    private void EnableUIComponents(GameObject[] objectsToEnable)
    {
        foreach (GameObject obj in objectsToEnable)
        {
            obj.SetActive(true);
        }
    }
}
