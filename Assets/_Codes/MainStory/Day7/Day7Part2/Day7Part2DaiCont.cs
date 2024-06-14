using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Day7Part2DaiCont : MonoBehaviour
{
    public static Day7Part2DaiCont instance;

    //Dialogue system
    [Header("Dialouge system")]
    public VisualElement DialogueBox;
    public Label SpeakerName;
    public Label DialogueTextBox;

    public void Awake()
    {
        instance = this;
        

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void say(string speech)
    {
        speaking = StartCoroutine(Speaking(speech));
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
    IEnumerator Speaking(string targetspeech)
    {
        DialogueTextBox.text = "";
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
