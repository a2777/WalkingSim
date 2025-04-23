using UnityEngine;

public class FlowerDialogueTrigger : MonoBehaviour
{
    public static bool dialogueComplete1 = false;
    public static bool dialogueComplete2 = false;

    private void Start()
    {
        //Debug.Log("Talk to flowers to activate teleport");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Flower1")
        {
            dialogueComplete1 = true;
            Debug.Log("Talked to flower1");
            //Debug.Log("Activated teleport");
        }

        if (collision.gameObject.tag == "Flower2")
        {
            dialogueComplete2 = true;
            Debug.Log("Talked to flower2");
            //Debug.Log("Talk to flower1 to activate");
        }

        /*else
        {
            //Debug.Log("Talk to flowers to activate teleport");
        }*/
    }


}
