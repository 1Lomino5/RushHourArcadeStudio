using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] string _nextLevelName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetString("LevelSaved", _nextLevelName);

            Debug.Log(_nextLevelName);

            gameObject.SetActive(false);
            GameIsPaused = false;
        }
    }
}
