
using System.Collections;
using UnityEngine;
using TMPro;

/*public class DialogManager : MonoBehaviour
{

    [System.Serializable]
    public class DialogueSegment
    {
        public string SubjectText;
        [TextArea]
        public string DialogeToPrint;
            public bool Skippable;
        [Range(1f, 25f)]
        public float LettersPerSecond;
    }
    [SerializeField] private DialogueSegment[] DialogueSegments;
    [Space]
    [SerializeField] private TMP_Text SubjectText;
    [SerializeField] private TMP_Text BodyText;

    private int DialogueIndex;
    private bool PlayingDialogue;
    private bool Skip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator PlayingDialogue(DialogueSegment segment)
    {
        PlayingDialogue = true;
        SubjectText.SetText(segment.SubjectText);
        float delay = 1f / segment.LettersPerSecond;
        for(int i= 0; i <segment.DialogeToPrint.Length, i++)
        {
            if (Skip)
            {
                BodyText.SetText(segment.DialogeToPrint);
                Skip = false;
                break;
            }
            string chunckToAdd = string.Empty;
            chunckToAdd += segment.DialogueToPrint[i];
            if(segment.DialogeToPrint[i] == " " && i< segment.DialogeToPrint.Length - 1)
            {
                chunckToAdd = segment.DialogeToPrint.Substring(i, 2);
                i++;
            }
            BodyText.text += chunckToAdd
        }
    }
}*/
