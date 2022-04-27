using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class Exit : MonoBehaviour
    {
        [SerializeField] string _nextLevelName;

        public Exit(string nextLevelName)
        {
            _nextLevelName = nextLevelName;
        }

        void OnTriggerEnter(Component other)
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("Level complete");

                StoneMovement playerMovement = other.GetComponent<StoneMovement>();

                if (playerMovement != null)
                {
                    playerMovement.DisablePlayerInput();
                }

                StartCoroutine("LoadLevel");
            }
        }

        IEnumerator LoadLevel()
        {
            yield return new WaitForSeconds(1);

            SceneManager.LoadScene(_nextLevelName);
        }
    }
}