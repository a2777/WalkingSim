using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
