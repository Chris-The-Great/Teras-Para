using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totural : MonoBehaviour
{
    [Header("Dai")]
    public Dia dialogue;
    public int index = 0;
    public GameObject TextBox;
    public GameObject TextBoxDisplay;
    public bool RanAlready;
    public string speaker;
    public GameObject Person3;

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.say(speech, speaker);

    }
    private void Start()
    {
        NextLine();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0)) 
        {
            NextLine();
        }
        if(index == 23)
        {
            Destroy(GameObject.Find("Canvas"));
            Destroy(this.gameObject);
        }
    }
    public void NextLine()
    {
        if (!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
        {
            if (index >= S.Length)
            {
                return;
            }
            Say(S[index]);
            index++;
        }
    }
    public string[] S = new string[]
    {
        "Well it's about time we get this started isn't it? : ???",
        "Who am I?",
        "Don't worry, we'll get introduce in a few days. For now, I'm here to transtle what just happened and explain how things work.",
        "For starters, you see the big Purple tent behind me?",
        "That'll serve as the mission center. You're going to walk up to and left click to get the mission menu to open.",
        "As you heard, you'll be given three mission a day to pick from",
        "Once you've selected a mission you like, you'll be asked to pick three of the member of the camp to go out and fight with.",
        "Most of the mission you'll receive will have a scene before them, to explain why they exsit along with the specail charcters to bring.",
        "You don't need to worry about specail charcters right now so I'll save that explation for another time.",
        "Once you have your team ready, you can press the E key to close out the menu.",
        "Note, there's a issue that needs to get cleared up so you might have to press E twice.",
        "Now for the red tent. Should be over on the left side.",
        "That'll serve as your training ground for now.",
        "You'll select one and only one person to train out that ground.",
        "You can train three diffferent stats over there, so depending on how you want to build someone is up to you",
        "Remember one and only one.",
        "Last one for now, yellow is going to hold the resources you get from combat.",
        "There three diffrent resources to gather.",
        "Mutant Blood, Mutant Bones, and Mutant Souls",
        "For now you can't do anything with them so don't worry to much about them.",
        "Once you have everything ready, you'll head to the exit gate, the one oppsite to the mission center, and left click to head out",
        "That's it for now, enjoy what you see for now and stay tune for more.",
        " "

    };
}
