using UnityEngine;
using UnityEngine.SceneManagement;

public class DreamSceneManager : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && FlowerDialogueTrigger.dialogueComplete1 == true)
        {
            SceneManager.LoadScene(sceneName);
        }

        else
        {
            Debug.Log("Talk to flower");
        }

       
        //Debug.Log("Loading new Scene");
        //SceneManager.LoadScene(sceneName);
    }


}
