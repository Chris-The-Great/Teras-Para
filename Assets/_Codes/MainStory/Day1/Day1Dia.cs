using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Day1Dia : MonoBehaviour
{
    [Header("Dai")]
    public Dia dialogue;
    public int index = 0;
    public GameObject TextBox;
    public GameObject Background;
    public GameObject TextBoxDisplay;
    public bool RanAlready;
    public string speaker;
    public GameObject Person1;
    public GameObject Person2;
    public GameObject Person3;

    public Sprite medusa;
    public Sprite griffin;
    public Sprite harpie;
    public Sprite cyclops;
    public Sprite prodo;
    public Sprite faneia;
    

    public void Start()
    {
        NextLine();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
            NextLine();
        }
        if(Input.GetKey(KeyCode.Z))
        {
            index = 92;
        }
    }

    public string[] S = new string[]
    {
        "Avatar is seen sleeping on a not so well maintenanced bed with less than desirable and ripped up sheets. Avatar wakes up and surveys the area. : ???",
        "Yawning softly, they gets out of bed.",
        "Yesterday still wasn't a dream. Damn. : Avatar",
        "Avatar looks at the other bed, seeing if they're not alone. : ???",
        "Guess it's only me. Heard that Prodo's gonna be waiting for me. Better show up and not keep him hanging. : Avatar",
        "Avatar exits the tent. : ???",
        "Avatar steps outside to find Prodo waiting for them. They both share a handshake.",
        "Glad to see you're well rested kid. Now that things have calmed down a bit, let me finally formally introduce myself. : Prodo" ,
        "I'm Prodo, one of the leading founders of Teras Para. I basically make sure that everyone's accounted for and that we have enough food and supplies to get us through the days. ",
        "If any of the others give you any trouble they'll have to answer to both me and... ",
        "Prodo pulls out a medium sized medieval looking sword that looks a tad rusted. He points it towards Avatar's general direction. : ???",
        "Gawain! : Prodo",
        "Avatar stares at Prodo judgmentally. : ???",
        "Okay okay I know, it seems a bit cheesy to name your weapon of choice but you'll find that your gonna find a preferred weapon that you'll want to use over and over again. : Prodo" ,
        "Soon enough that weapon'll be your own kid, and of course you're gonna wanna give a name for your own kid. ",
        "Avatar still stares at Prodo judgmentally. : ???",
        "Hey stop looking at me like that, thought you'd be impressed. : Prodo",
        "Alright enough joking around I suppose. Come with me and I'll show you the ropes and what life has to offer here. : Prodo",
        "Avatar and Prodo walk away from the tent past a single elderly man wearing attire that has been scorched and torn. After walking a bit further distance, they approach... : ???",
        "The Mission Center, which  Avatar and Prodo see Faneia standing just outside of the mission center building with her arms crossed. : ???",
        "How it going sweetheart? : Prodo",
        "I told you never to call me sweetheart. How's the kid adjusting? : Faneia", 
        "So far so good, I was just about to tell him about how the Mission Center works. : Prodo",
        "It's pretty self explanatory. : Faneia",
        "Prodo turns his attention back towards Avatar. : ???",
        "So here's how it works.This is the mission center. Here you can pick up several job postings either from people within Teras Para or within mutant territory if your willing to challenge yourself. : Prodo",
        "Missions can range from simple fetch quests to killing a number of mutants to appease someone.",
        "This is Faneia, she's our central intelligence specialist, any question you have about anything this world has to offer, she's your gal.",
        "Guilty as charged I suppose. : Faneia",
        "On top of that, other missions include... : Prodo",
        "Avatar mouths and motions a response, listing off several of the other mission/quest types such as apprehending traitors, getting items for people, and escort missions. : ???",
        "Wait, what the? : Faneia",
        "Huh. Oh ya, that's exactly what I was going to say. Uh, ya, it looks like you've actually gotta good grip on how this all works then. : Prodo",
        "Prodo rubs the back of his head in confusion. Faneia eyes down Avatar in suspicion. : ???",
        "Well, I guess we'll move on to the training grounds. : Prodo",
        "I'll come with you. It'll be nice to check up on how things are going over there. : Faneia",
        "Avatar, Prodo, and Faneia walk about from the mission center, past a child in yellow and brown colored clothing. " +
        "After walking a longer distance past several other shacklike houses, they come across... : ???",
        "The Training Grounds. It is a wide open area fenced off by wooden plank fences and barbed wire. : ???",
        "Avatar, Prodo, and Faneia come across Griffin training with one of the makeshift test dummies, swiping it with his claws and cawing while doing so. " +
        "Noticing Avatar, Prodo, and Faneia, Griffin jogs towards them.",
        "This is Griffin, one of the best fighters we've got here at Teras Para. : Prodo",
        "Well I can't personally take all of the credit, I'd be nowhere without all of the equipment available to us here at the old training grounds. : Griffin",
        "The world's a screwed up place right now, and this is where you can make it easier on yourself so that you don't have to be worried about all the troubles.",
        "From weight lifting to increase strength, triathlons to increase your speed, and...",
        "Avatar interrupts Griffin, motioning his mouth and arms listing off everything else the training grounds have to offer." +
        "Griffin's eyes widen in shock, with Prodo and Faneia squinting their eyes in suspicion. : ???",
        "Oh wow, huh. Uh...ya, that's exactly it, you can indeed also increase your defense, knowledge, and health with just about everything else we have here. : Griffin",
        "Griffin rubs the back of his head in confusion, with Prodo and Faneia still staring at Avatar in suspicion. " +
        "Griffin walks toward Prodo and Faneia away from Avatar. : ???",
        "He's good.: Griffin",
        "Ya, maybe too good if you ask me. : Faneia",
        "Uh...maybe we should head over towards the resources center. I'm sure the kid'll want to know more about how to prioritize what is needed and unneeded around here. " +
        "What do you think sweetheart? : Prodo",
        "I told you not to call me that in public. : Faneia",
        "Oh come on it's cute, sweetheart. : Prodo",
        "Aarrgghh! : Faneia",
        "Avatar, Prodo, Faneia, and Griffin walk about from the training grounds. After walking a longer distance past several other shack-like houses, they come across... : ???",
        "The Resources Center. Avatar, Prodo, Faneia, and Griffin come across Harpy, who is standing directly next to the resources base with her arms nervously folded into her body upon looking at Avatar.",
        "Avatar takes a back only to be stopped by Prodo, who gives Avatar a reassuring nod, signifying that Harpie means no trouble at all.",
        "So, this is the new recruit I heard so much about huh? : Harpie",
        "That's right little lady, he made quite a mess of things last night, sure does have the potential too. : Griffin",
        "Maybe too much potential if you ask me. : Faneia",
        "What does that mean? : Griffin",
        "Nothing : Faneia",
        "Anyways, this here is Harpie, she isn't like any of those other mutant harpies you saw yesterday. Not anymore at least." +
        "She's the pure definition of a team player, and will do anything to go in for the perfect kill. : Prodo",
        "My apologies for not attending the battle prior, as you already knew I was still recovering from injuries sustained during last week's raid. : Harpie",
        "Don't worry about it, those gorgons aren't nothing to mess with. : Prodo",
        "Medusa isn't with you is she? : Harpie",
        "Haven't seen her today. : Prodo",
        "Good. : Harpie",
        "Huh. : Prodo",
        "Nothing. : Harpie",
        "Prodo turns his attention back towards Avatar. : ???",
        "Well anyways, this here is the resources base, this is where you can stock up on food and resources such as... : Prodo",
        "Before Prodo can continue his sentence, Avatar motions his mouth and arms, listing off various items found in the resources base, such as muntant blood and muntant bones. Everyone's face lights up, both in astonishment and judgment. : ???",
        "Damn kid, are you a psychic or something, how do you know so much about this place? You've got a lot more potential then I thought. : Prodo",
        "Ya seriously, you've sure got the makings for being something else. : Griffin",
        "Must be some sort of prodigy I suppose. : Harpie",
        "Ya but... : Faneia",
        "Before Faniea can contuine, Cyclops approaches the party. : ???",
        "Medusa and I are all set to head out on a mission. : Cyclops",
        "Well then, let's head to the Mission Center and get today started. : Griffin",
        "Avatar, Cyclops, Harpie and Griffin all begin to walk away from the resources base. Prodo and Faneia stay behind, carefully observing Avatar. : ??? ",
        "Look at how that kid walks. : Faniea",
        "I know, it's like he knows every little thing about this place, like he's memorized the entire map or something. : Prodo",
        "It could be possible that the kid's just gifted or something.",
        "You don't think... : Faneia",
        "You mean that day? : Prodo",
        "Ya, a day we all don't want to remember. : Faneia",
        "Definitely looks that way but let's not jump to conclusions right now. : Prodo",
        "Well if it's true, for the time being, lets keep this between us for everyone's protection. : Faneia",
        "Do you think that's wise? : Prodo",
        "Hard to say, but lets be on our guard. : Faneia",
        "Okay : Prodo",
        "If that time does come, I promise I won't abandon you. : Faneia",
        "Same here. : Prodo",
        "Prodo and Faneia walk off screen to join the others. : ???",
        ""

    };

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.say(speech, speaker);

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
            changeTextBox();
            ChangePerson();
        }
    }
    void changeTextBox()
    {
        switch (speaker)
        {
            case " Medusa":
                TextBox.GetComponent<Image>().sprite = Resources.Load<Sprite>("_Art/Amanada/TextBox/MedusaText");
                break;
            case " Griffin":
                TextBox.GetComponent<Image>().sprite = Resources.Load<Sprite>("_Art/Amanada/TextBox/GriffinText");
                break;
            case " Harpie":
                TextBox.GetComponent<Image>().sprite = Resources.Load<Sprite>("_Art/Amanada/TextBox/HarpieText");
                break;
            case " Cyclops":
                TextBox.GetComponent<Image>().sprite = Resources.Load<Sprite>("_Art/Amanada/TextBox/CyclopsText");
                break;
            case " Prodo":
                TextBox.GetComponent<Image>().sprite = Resources.Load<Sprite>("_Art/Amanada/TextBox/ProdoText");
                break;
            case " Faneia":
                TextBox.GetComponent<Image>().sprite = Resources.Load<Sprite>("_Art/Amanada/TextBox/FaneiaText");
                break;
            case " Avatar":
                TextBox.GetComponent<Image>().sprite = Resources.Load<Sprite>("_Art/Amanada/TextBox/AvatarText");
                break;
            case " ???":
                TextBox.GetComponent<Image>().sprite = Resources.Load<Sprite>("_Art/Amanada/TextBox/UnknowText");
                break;
        }
    }

    void ChangePerson()
    {
        switch(index)
        {
            case 8:
                Person1.GetComponent<Image>().sprite = null;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person2.GetComponent<Image>().sprite = null;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person3.GetComponent<Image>().sprite = prodo;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 22:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = faneia;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 41:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = faneia;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = griffin;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 56:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = faneia;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = harpie;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 77:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = faneia;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = cyclops;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 79:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = faneia;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 93:
                Person1.GetComponent<Image>().sprite = null;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person2.GetComponent<Image>().sprite = null;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 94:
                SceneManager.LoadScene(1, LoadSceneMode.Single);
                break;
        }
    }
}

