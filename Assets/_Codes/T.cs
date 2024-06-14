using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class T : MonoBehaviour
{
    
    public AsyncOperation AO;
    [Header("Dai")]
    public Dia dialogue;
    public static int index = 0;
    public static GameObject TextBox;
    [Header("Anime/Music")]
    public static GameObject Background;
    public GameObject TPRW;
    public Animator Fade;
    public bool RanAlready;
    [Header("Codes")]
    public GameMaster GM;
    public int TI;


    private void Awake()
    {
        TI = FindObjectsOfType<T>().Length;
        if (TI != 1)
        {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        dialogue = Dia.instance;
        Background = GameObject.Find("Background");
        //GM = GameObject.Find("GameMaster").GetComponent<GameMaster>();
        Background.GetComponent<Image>().sprite = Resources.Load<Sprite>("Temp/Room");
        TPRW.SetActive(false);

        NextLine();

    }
    public string[] s = new string[]
    {
        "Teras Para… 10,000 copies sold. : Player",
        "Well deals a deal. Time to hold up my end of the bargain.: Player",
        "Downloads got a few minutes.: Player",
        "I wonder how he feels right now, knowing he reached his goal. : Player",
        "I still remember the day I met him. Guy couldn’t shut his ego off. : Player",
        " ",
        "I got time for one more game to view before judging begins. : Player",
        "An epic tale of greek mythology. : Chris",
        "Well I’ve played most of the games here. : Player",
        "I’d like to try your game. : Player",
        " ",
        "Are you ready to have your mind blow? : Chris",
        "This isn’t any ordinary game, this is the greatest game ever made. : Chris",
        "Is...Is it really? : Player",
        "No but it’s the best game here 100%. : Chris",
        "So...not even close to the greatest game ever made. : Player",
        "You say not even close, I say it needs a bug fix or two from being the greatest. : Chris",
        "Same thing. : Chris",
        "Anyway, are you ready for a game on greek mythology?: Chris",
        "Battle against mutants trying to bring about the end of the world? : Chris",
        "Yeah… that sounds pretty good actually. : Player",
        "Well then, set up to the computer and hit play!! : Chris",
        " ",
        "Welcome to Teras Para. : Chris",
        "Nice title screen. You make it yourself? : Player",
        "Of course not, I don’t have an artistic bone in my body. : Chris: Chris",
        "Then how are you designing video games? : Player",
        "Just hit play. : Chris",
        "Alright here we go. : Player",
        " ",
        "Well what do you think? : Chris",
        "It’s just… it’s just a bunch of cubes and circles. : Player",
        "Well yeah, I was focused on gameplay, I only had 12 hours to do this after all. : Chris",
        "Fair enough. Walk me through it. : Player",
        "Right, see the bar on the top of your screen, that’s the mutant tracker.: Chris",
        "Your goal is to get the bar down to zero, ridding the world of mutants. : Chris",
        "How are you going to do that you might be thinking? : Chris",
        "Well you’ll embark on a mission and fight against the mutants. : Chris",
        "You see the model standing there in front of the yellow cube. ",
        "Talk to it to have missions explained to you.  : Chris",
        "Press X to talk to each of the models.: Chris",
        " ",
        "You’re here, I can explain missions to you. : Fáneia",
        "Each day, you’ll be given three options for a mission to choose from. : Fáneia",
        "They’ll either be general type or character type. : Fáneia",
        "For a better understanding; One mission would be to go out and fight mutants: Fáneia",
        "And the other would be based on a request from us, like going to a location. : Fáneia",
        "Once a mission is selected, you can send up to three members of the party on it.: Fáneia",
        "After picking a mission you’re free to do the rest of the planning around the base. : Fáneia",
        "When everything is planned, head to the exit gate to head out on the mission. : Fáneia",
        "Alright simple enough, what else do I need to know. : Player",
        "Next is the model in front of the blue cube. You’ll learn about the training.: Chris",
        " ",
        "My turn, this is the training grounds. : Griffin",
        "Our training is fairly simple. Pick a spot on the grounds you want to train. : Griffin",
        "There are three different areas you can pick to train in.: Griffin",
        "One for health, another for strength, and finally knowledge. :Griffin",
        "From there, all you have to do is send one of us off to the training grounds. : Griffin",
        "Our training will happen once you leave base, so no need to do anything extra. : Griffin",
        "Okay I got it… but a question, shouldn’t it the other way around? : Player",
        "Like I pick the person I want to train, then I send them somewhere on the grounds.: Player",
        "That’s… A really good point…: Chris",
        "I should change that around after you’re done playing. : Chris",
        "Anyway, move to the next model by the pink and find out about resources.: Chris",
        " ",
        "Let’s get this over with, I have a plate of food with my name on it. :Harpie",
        "This is where we keep our stuff, along with mutant bones, blood and souls. : Harpie",
        "If you want to send someone out for resources just come here. : Harpie",
        "Whoever goes out will bring back all three of the resources.: Harpie",
        "That’s it for me, I’m eating, anything else you can figure out yourself. :Harpie",
        " ",
        "That was… a person… I think. Anyway, what do you do with resources?: Player",
        "Uh…(Embarrassing laugh) Well, you see…:Chris",
        "You don’t have anything programmed for the resources.: Player",
        "When you put it like that…: Chris",
        "I ran into a bug and it was faster to gut it then try and fix it. :Chris",
        "Moving on from my failure as a programmer. : Chris",
        "Go over to the next one and learn about researching.: Chris",
        " ",
        "Finally you’re here, I thought the other would talk your ear off.: Prodo",
        "Although, given those three… yeah, I take back my last statement. :Prodo",
        "Enough rambling, let me teach you how to research some mutants. : Prodo",
        "There are six different types of mutants we’ve been tracking. :Prodo",
        "Powerfully mutants that could wipe us out in a second. : Prodo",
        "At least with the strength we have now.: Prodo",
        "This works the same as training, send someone to research one of the mutants.: Prodo",
        "Oh, one more thing before you leave. :Prodo",
        "Each one of the mutants that you’ll be researching is tied to our personal arcs. :Prodo",
        "So we’ll be researching the one tied to ourselves.: Prodo",
        " ",
        "Alright Prodo, enough out of you.: Chris",
        "Is that everything, because…:Player",
        "One last thing you have to learn about before you can start.: Chris",
        "Press the T key and pull out the team page will you. I’ll explain this quick.: Chris",
        " ",
        "So this is the Team/Character page.:Chris ",
        "It’s what you’re going to see when you need to send someone somewhere. : Chris",
        "Most of the page is straightforward, I only need to teach you salvage and status.: Chris",
        "Salvage is how much of the base resources someone will bring.: Chris",
        "Status, it’ll display where you’ve selected to send someone, like mission. : Chris",
        "Alright that’ll do it, you're ready to play Teras Para. : Chris",
        " ",
        "Playtime is over gamers, please report to the voting booths to cast your vote for best game. : Announcer",
        "... : Chris",
        "Well that’s unfortunate. : Player",
        "... : Chris",
        "So… I’ll see you when the announce who the winner is? : Player",
        "... : Chris",
        " ",
        "The winner of TNAC game jam is… Waifu Runner!!! : Announcer",
        "Please look at the game board to see the scores of all the games tonight. : Announcer",
        "Game board… Let's see Wafui Runner, 10,000. Talk about a landslide. : Player",
        "Oh, I wonder where Teras Para landed… : Player",
        "I landed at zero. : Chris",
        "Oh...ah… for what it’s worth I thought your game had potential. it ‘s just: Player",
        "It’s okay, you don’t need to damage control. My pride alright with the results. : Chris",
        "This board just showed the difference between me and everyone else here. : Chris",
        "The biggest thing this board showed me was just how far I am from greatness. : Chris",
        "But I’m not discouraged, there’s no way I would stop now.: Chris",
        "After all, greatness is always obtainable just as long as you have the will to be: Chris",
        "So don’t worry, I’ll absolutely turn this number zero into a number that can pierce the heavens. :Chris",
        "That’s a promise. :Chris",
        "Pierce the heavens huh. : Player",
        "Good, then whenever you sell Teras Para and it’s sells number reaches 10,000, I’ll be 10,001. : Player",
        " ",
        "I’ll hold you to that. Deal. :Chris",
        "Well, took him over a year to launch the game from the game jam.: Player",
        "And in just a few days, hit 10,000. : Player",
        "Download done, well then, it’s time to play TERAS PARA!! : Player",
        " ",


    };

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            NextLine();
        }
        StringCommands();
        Fade = GameObject.Find("Fade").GetComponent<Animator>();
    }

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.say(speech, speaker);

    }

    public IEnumerator WaitMet()
    {
        yield return new WaitForSeconds(1f);
        if(RanAlready == false)
        {
            
            NextLine();
            RanAlready = true;
            if (index == 30)
            {
                AO = SceneManager.LoadSceneAsync(2);
                AO.allowSceneActivation = false;
               
            }
        }
        
    }
    public void NextLine()
    {
        if (!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
        {
            if (index >= s.Length)
            {
                return;
            }
            Say(s[index]);
            index++;

        }
    }
   
    public void Moveto()
    {

    }

    public void StringCommands()
    {
        switch(index)
        {
            case 6:
                Fade.SetTrigger("Fade");
                StartCoroutine(WaitMet());
                break;
            case 7:
                Fade.SetTrigger("FadeBack");
                Fade.ResetTrigger("Fade");
                Background.GetComponent<Image>().sprite = Resources.Load<Sprite>("Temp/CONB");
                break;
            case 11:
                RanAlready = false;
                Fade.ResetTrigger("FadeBack");
                Fade.SetTrigger("Fade");
                StartCoroutine(WaitMet());
                break;
            case 12:
                Fade.ResetTrigger("Fade");
                Fade.SetTrigger("FadeBack");
                GameObject.Find("Person 1").GetComponent<Image>().color = new Color(255, 255, 255, 1f);
                break;
            case 23:
                Fade.ResetTrigger("FadeBack");
                Fade.SetTrigger("Fade");
                RanAlready = false;
                StartCoroutine(WaitMet());
                break;
            case 24:
                Fade.ResetTrigger("Fade");
                Fade.SetTrigger("FadeBack");
                TPRW.SetActive(true);
                break;
            case 29:
                Fade.ResetTrigger("FadeBack");
                Fade.SetTrigger("Fade");
                RanAlready = false;
                StartCoroutine(WaitMet());
                break;
            case 30:
                Fade.SetTrigger("FadeBack");
                Fade.ResetTrigger("Fade");
                Background.SetActive(false);
                TPRW.SetActive(false);
                AO.allowSceneActivation = true;
                GameObject.Find("Person 1").SetActive(false);
                break;
            //next is talking ot each of the charcters


        }
    }
}
