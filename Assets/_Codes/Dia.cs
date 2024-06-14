using System.Collections;
using TMPro;
using UnityEngine;

public class Dia : MonoBehaviour
{
    public static Dia instance;

    //Dialogue system
    [Header("Dialouge system")]
    public GameObject DialogueBox;
    public TextMeshProUGUI SpeakerName;
    public TextMeshProUGUI DialogueTextBox;

    public void Awake()
    {
        
        instance = this;
        DialogueBox = GameObject.Find("TextBox");
        SpeakerName = GameObject.Find("Name").GetComponent<TextMeshProUGUI>();
        DialogueTextBox = GameObject.Find("Speech").GetComponent<TextMeshProUGUI>();

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void say(string speech, string speaker = "")
    {
        speaking = StartCoroutine(Speaking(speech, speaker));
    }
    public void StopSpeaking()
    {
        if (isSpeaking)
        {
            StopCoroutine(speaking);
        }
        speaking = null;
    }
    public bool isSpeaking { get { return speaking != null; } }
    public bool isWaitingForUserInput = false;
    Coroutine speaking = null;
    IEnumerator Speaking(string targetspeech, string speaker = "")
    {
        DialogueBox.SetActive(true);
        DialogueTextBox.text = "";
        SpeakerName.text = WhoSpeaking(speaker);
        isWaitingForUserInput = false;
        while (DialogueTextBox.text != targetspeech)
        {
            DialogueTextBox.text += targetspeech[DialogueTextBox.text.Length];
            yield return new WaitForEndOfFrame();
        }
        isWaitingForUserInput = true;
    }
    string WhoSpeaking(string s)
    {
        string retval = SpeakerName.text;
        if (s != SpeakerName.text && s != "")
        {
            retval = (s.ToLower().Contains("Narrator")) ? "" : s;
        }
        return retval;
    }
}