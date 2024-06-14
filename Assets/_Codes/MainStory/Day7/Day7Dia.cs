using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;

public class Day7Dia : MonoBehaviour
{

    [Header("New UI")]
    VisualElement Root;
    VisualElement Background;
    VisualElement person1;
    VisualElement person2;
    VisualElement person3;
    VisualElement textBox;
    Label textDia;
    [Header("Dai")]
    public Day7DaiCont dialogue;
    public int index = 0;
    public bool RanAlready;
    public string speaker;

    public Sprite medusa;
    public Sprite griffin;
    public Sprite harpie;
    public Sprite cyclops;
    public Sprite prodo;
    public Sprite faneia;
    public Sprite GameMaker;

    public UI uiCode;

    public void Start()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        Background = Root.Q<VisualElement>("backGround");
        person1 = Background.Q<VisualElement>("person1");
        person2 = Background.Q<VisualElement>("person2");
        person3 = Background.Q<VisualElement>("person3");
        textBox = Root.Q<VisualElement>("textBox");
        textDia = textBox.Q<Label>("textDia");

        Day7DaiCont.instance.DialogueBox = textBox;
        Day7DaiCont.instance.DialogueTextBox = textDia;

        NextLine();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            NextLine();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            index = 149;
        }
    }

    public string[] S = new string[]
    {
        "Avatar, Cyclops, Prodo, Faneia, and Griffin walk in from the main flaps of the Tactics Tent where they see Medusa standing next to a bulletin board with a map of the area stuck to it with pins.  : ???",
        "The tent itself is made out of poorly stitched together blue fabric with many holes. The floor is dirt with many dead weeds and browned grass covering every inch of the ground. " ,
        "In the middle of the tent is a circular wooden table with several pieces of paper stacked up in a pile, crumpled up pieces of paper, and various writing." ,
        "Utensils such as pens and pencils, most of which are broken or snapped in half. Medusa makes her way to the rest of the group.",
        "Let's get this meeting started. : Faneia",
        "The main party gathers around the circular wooden table. : ???",
        "So, just gonna be blunt here, the mountains close to where we've built Teras Para has yet to be explored.: Faneia",
        "Do you really think that's a good idea Faneia? I mean, I get where you're coming from, there might be some great resources there, but it's the primo hot spot for mutants. : Griffin",
        "I'm sure she has her reasons, let's hear what she has to say first before we take a definitive vote. : Prodo",
        "Thank you Prodo. : Faneia",
        "Faneia walks back towards the bulletin board, the rest of the group following suit.: ???",
        "Stopping for a moment, Avatar picks up a crumbled up piece of paper and unfolds it's contents, revealing a poorly sketched out picture of a mutant, a harpy to be exact. ",
        "The drawing is covered in blood and obstructs the intricate details of the drawing. Avatar crumples it back up again and drops it to the ground. ", 
        "Avatar walks over to the bulletin board with the rest of the group. ",
        "Okay, so we all know that the mutants have ravaged this land for what feels like countless years now. Unfortunately, we've yet to pinpoint their exact origin but I have a hunch. : Faneia",
        "We're having lunch soon? : Cyclops",
        "No not lunch Cyclops, I said hunch! : Faneia",
        "But my back feels fine. : Cyclops",
        "Not that kind of hunch, I mean... : Faneia",
        "Before Faneia can continue her sentence, Griffin covers her mouth with his claw. : ???",
        "We're getting off topic here. : Griffin",
        "Yes, please continue Faneia.",
        "Don't worry, I'll calm down Cyclops. :Medusa",
        "Medusa confines Cyclops to a stilled position, giving him a piece of steak that he promptly started gnawing and chewing. Faneia picks up a stick propped up against a stool and points to a location on the map. : ???",
        "Judging from the aerial and flight patterns of the harpies and the griffins, and their sharpened claws and talons appropriate to a mountainous environment, :Faneia", 
        "I have reason to believe that most, if not all, of the mutants are converging somewhere in these specific mountain areas.",
        "So you're thinking we can take em out all at once if this hypothesis is correct. : Medusa",
        "Not necessarily.: Faneia",
        "I was thinking more like it'd be a good idea for us to potentially incapacitate one of the lesser mutants in a surprise attack and bring it back to base for further analysis. : Faneia",
        "What about all of the corpses we pilled up a few days ago? : Griffin",
        "It won't do us good to study a specimens that are too damaged. We need a complete, living, in tact mutant. : Faneia",
        "We need to know exactly what makes them tick if we're ever gonna get a chance to take back the world.",
        "Prodo examines the map more closely, squinting his eyes as hard as he can with his face pressed deeply on the map's contents. : ???",
        "Do you think we're ready? The mountains are unforgiving and treacherous. : Prodo",
        "I don't think our current supplies are enough to wrangle a mutant, especially if we're talking about harpies. They require netting.",
        "We have sleeping inducing darts don't we? : Faneia",
        "Yeah : Prodo",
        "I think Faneia's on to something here. Those should do just fine. Cyclops can do all of the heavy lifting from there. Isn't that right sweetie? : Medusa",
        "Ya, that's me, I'm a Hercules. : Cyclops",
        "It'll take at least ten or twenty of those darts to knock out a harpy, let alone a cyclops. You know that right? : Prodo",
        "I think it's worth the risk. : Faneia",
        "Prodo looks back at the group and then turns his attention back towards Faneia. : ???",
        "If we're able to pull this off, we'll need someone to take a record of everything the mutant does while we have it tied up in base. : Prodo",
        "I'm talking mannerisms, potential diet, sleep patterns, the whole kit and caboodle.",
        "I'll do it. : Cyclops",
        "Cyclops, no offense but drawing pictures of ducks in red crayon and dirt doesn't necessarily mean you're of great penmanship. Stick to what you know. : Faneia",
        "Oh okay... : Cyclops",
        "The groups turns their attention towards Avatar, meeting thier gaze. : ???",
        "Faneia grabs Medusa's arm, dragging her to the furthest corner of the tactics tent, making sure they're out of Avatar's hearing distance. : ???",
        "Do you really think the kid's really our best bet for this job? I mean, what about Griffin? : Faneia",
        "You and I both know I value Griffin's hard work and determination but hetends to over strain his thinking muscles, especially when it comes to combat. : Medusa",
        "Not quite sure how that'll transition in a note taking format.",
        "True, but we don't even know if their a great note taker. : Faneia",
        "Plus, between you and me, even if it turns out his/her notes suffice, whose to say he/she won't use those notes to his/her advantage.",
        "What do you mean? : Medusa",
        "Oh..well...I mean...well...I didn't actually mean...I didn't actually mean to say...well...uh... : Faneia",
        "Before Faneia can finish her sentence, they, alongside the rest of the group, hear a loud crashing sound coming from outside the tent, almost as if it were a massive explosion. : ???",
        "What in the world was that? : Griffin",
        "Oh God, did reinforcements make their way here already? Better saddle up if that's the case. : Prodo",
        "Are we gonna be bopping some peoples over the heads again today? : Cyclops",
        "Not people, mutants. : Faneia",
        "Even better. : Cyclops",
        "Everyday its the same thing. A mundane schedule to say the least, but the sooner we get this over with, the sooner we can continue to protect ourselves and the rest of the world. : Medusa",
        "Let's be ready to face whatever life has dished out this time.",
        "Avatar, Medusa, Cyclops, Prodo, Faneia, and Griffin exit through the main flaps of the tent in a hurried pace, dashing through various crumpled pieces of paper as they tumble through the wind. : ???",
        "The main group walk out of the tactic tent. The main group gaze upon a cloud of black smoke that had enveloped the surrounding area. From the smoke, a figure emerges. : ???", 
        "This is THE GAME MAKER. The Game Maker is seen levitating in the air. The main group backs away a bit, all except for Avatar, who stays exactly where he is standing.",
        "It seems that the narrative is going as planned. : Game Maker",
        "Avatar motions his lips and arms, replying to The Game Maker's off handed comment, asking him who exactly he is. : ???",
        "Avatar and The Game Maker are out of hearing distance from the rest of the party.",
        "You don't know who I am, but I certainly know who you are Avatar. The same sentiment applies to your friends as well. : Game Maker",
        "Medusa and the others slowly and hesitantly walk closer towards The Game Maker. : ???",
        "Who are you? What business do you have here? : Medusa",
        "Well he certainly doesn't look like an ally to me. : Faneia",
        "Is he the bad guy? : Cyclops",
        "The Game Maker stops his levitating state, stepping down on the ground and walks closer towards the main party. : ???",
        "Don't mind me, I'm just a lonepasserby. Just wanted to make sure you were all on the right track. : Game Maker",
        "The right track? : Griffin",
        "You're not making any sense! Who the hell are you? : Faneia",
        "That is not your concern as of right now. That is for me to know and for you to find out on your own accord. : Game Maker",
        "As I have stated before, I am simply here to ensure your plans of venturing in the mountains will proceed as planned.",
        "Everyone in the group's eyes widen at The Game Maker's comment, with Medusa grabbing The Game Maker by the collar of his shirt. : ???",
        "How do you know what we're up to? : Medusa",
        "As I stated before, I'm just a common passerby who just happened to listen in on your conversation. : Game Maker",
        "It's not the fault of mine that your voices can be heard across the horizon.",
        "Hey, I'm not that loud, I've just got a big mouth. : Cyclops",
        "Besides, you're allowing yourselves to become distracted by my presence. : Game Maker",
        "You should be more concerned about them.",
        "The main party notices a flock of mutant griffins hovering a few feet behind The Game Maker. Medusa releases her grip of The Game Maker and runs back to the group. : ???",
        "Everyone readies their weapons and poses in battle stances. The mutant griffins roar and squawk, getting closer and closer to the main party.",
        "More enemies?! : Griffin",
        "Well this is just fantastic. Prodo, I thought you refortified the defenses after the last attack! : Faneia",
        "I did! : Prodo",
        "Did you have something to do with this? : Medusa",
        "It is not my place to say, but from my deductive reasoning it's likely these griffins were predestined to attack on this very hour. : Game Maker",
        "Predestined? What's that mean? : Cyclops",
        "It means it was meant to happen. : Faneia",
        "Well predestined or not, looks like we've gotta job to do again. Everyone be on your guard, first we'll protect our base yet again, and then we'll deal with this stranger ourselves. : Medusa",
        "Looks to me like this is a blessing in disguise. : Prodo",
        "The mutants came to us, so if we manage to take on down without killing it, we don't have to go to them to get a specimen.",
        "He's gotta point. : Cyclops",
        "Alright then, let's do that. Everyone, to battle! : Medusa",
        "The main party begins to charge at the mutant griffin, the mutant griffins themselves charging towards the main party. : ???",
        "Before a battle can ensue, The Game Maker stands in the middle of the conflict.",
        "No. : Game Maker",
        "Turning in the direction of the mutant griffins, The Game Maker extends his left arm and opens the palm of his hand. His hand begins to glow. :??? ",
        "A powerful blue beam of energy shoots out of The Game Maker's hand, hitting the mutant griffins and vaporizing them instantly. " ,
        "The blue beam of energy disappears as soon as The Game Maker closes his hand and clenches his fist. Nothing but ashes remains from the mutants. " ,
        "The entire main party stands in astonishment, putting their weapons away in the process. The Game Maker turns back towards the main party, with the main party stepping back away from The Game Maker a bit.",
        "The narrative dictates you were to kill the monsters, not incapacitate them. That is to come for later. : Game Maker",
        "The main party looks at the ashes left behind from the vaporized mutants, looking back at The Game Maker. : ???",
        "Holy crap. You, annihilated them! : Prodo",
        "That was awesome. Awesome...but a little scary too. : Cyclops",
        "I've never seen anything like that in my life. : Griffin",
        "Who the hell are you? : Faneia",
        "And what do you mean, the narrative? : Medusa",
        "As I stated before, that is for me to know and for you to find out on your own accord. I'd suggest heading to Proti Vasi to find out more. : Game Maker",
        "Proti Vasi? : Medusa",
        "The Game Maker begins levitating again as black smoke envelopes his entire body. Small bursts of fire erupt from the smoke as The Game Maker begins to vanish. : ???",
        "And as for you, it would be wise for you not to tamper with the narrative, otherwise you'd suffer the dire consequences. : Game Maker",
        "Farewell to you all, may our paths cross again as dictated by the narrative.",
        "More smoke envelopes The Game Makers body. The black smoke soon becomes nothing but a spherical ball of fire. The fireball implodes, leaving nothing in it's trace. : ???",
        "The Game Maker has disappeared completely. The main party walk over towards where The Game Maker originally stood, looking for any trace of him with no avail. Medusa rubs her head in confusion.",
        "Was that a dream? We all saw him right? : Medusa",
        "You ain't hallucinating, that was real alright. : Prodo",
        "What was he even talking about? Narrative? Predestined? Proti Vasi? : Griffin",
        "It's like he was talking in tongues or something.",
        "What are we gonna do now? : Medusa",
        "Does this mean we have to actually go in the mountains now? I was really hoping we could just snag a mutant here and catch up on sleep. : Cyclops",
        "I'm afraid so Cyclops. And call it intuition, but something tells me those mountains hold a lot more than we know. : Faneia" ,
        "And if we're lucky, we'll come across our new friend while we're there.",
        "Well then what are we waiting for, lets get to it. : Griffin",
        "We'll have to make a ton of preparations before heading out. : Prodo",
        "Sounds about righty-o. : Cyclops",
        "Now hold on now, Teras Para is at risk again. We'll need a couple of volunteers to stay behind to keep an eye on the little boy and the old man while me and Prodo are away. : Faneia",
        "You and Prodo? : Medusa",
        "You and me? : Prodo",
        "Well ya, I have more sense of the land and Prodo will be the muscle. We'll have to worry about getting a specimen later, more pressing matters are at hand now. : Faneia",
        "Well if you say so. : Griffin",
        "Any volunteers willing to stay? : Faneia",
        "Medusa, Cyclops, and Griffin raise their hands in unison. Avatar meets eyes contact with Prodo and Faneia without his hand raised. : ???",
        "So you want to come along with us eh? Fair enough, I guess it'll give you a chance to gain real fighting experience. : Faneia",
        "And I guess I'm fine with all you staying as well. It'll give you all a chance to fortify our defenses properly this time.",
        "Hey! : Prodo",
        "Faneia walks over towards Avatar, kneels down, and places both her hands on his/her shoulders. : ???",
        "Now look, this journey is going to be treacherous and unforgiving. We'll be here to protect you but you shouldn't rely on us heavily. Make sure you've used every resource imaginable in Teras Para to get ready. : Faneia",
        "Once you're ready, the mountains will be calling our names. Do you understand?",
        "Avatar nods thier head in agreement. : ???",
        "Splendid, just say the word and we'll go from there. : Faneia",
        ""
    };

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.say(speech);

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
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/MedusaText"));
                break;
            case " Griffin":
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/GriffinText"));
                break;
            case " Harpie":
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/HarpieText"));
                break;
            case " Cyclops":
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/CyclopsText"));
                break;
            case " Prodo":
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/ProdoText"));
                break;
            case " Faneia":
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/FaneiaText"));
                break;
            case " Avatar":
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/AvatarText"));
                break;
            case " ???":
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/UnknowText"));
                break;
            case " Game Marker":
                textBox.style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("_Art/Amanada/TextBox/GameMasterText"));
                break;
        }
    }

    void ChangePerson()
    {
        switch (index)
        {
            case 16:
                person2.style.backgroundImage = new StyleBackground(cyclops);
                break;
            case 27:
                person2.style.backgroundImage = new StyleBackground(medusa);
                break;
            case 33:
                person1.style.backgroundImage = new StyleBackground(prodo);
                break;
            case 45:
                person2.style.backgroundImage = new StyleBackground(cyclops);
                break;
            case 50:
                person3.style.backgroundImage = new StyleBackground(medusa);
                person2.style.backgroundImage = new StyleBackground(faneia);
                person1.style.opacity = 0;
                break;
            case 68:
                person3.style.opacity = 0;
                person2.style.opacity = 0;
                person1.style.backgroundImage = new StyleBackground(GameMaker);
                person1.style.opacity = 100;
                break;
            case 73:
                person2.style.opacity = 100;
                person2.style.backgroundImage = new StyleBackground(medusa);
                break;
            case 74:
                person3.style.opacity = 100;
                person3.style.backgroundImage = new StyleBackground(faneia);
                break;
            case 86:
                person3.style.backgroundImage = new StyleBackground(cyclops);
                break;
            case 99:
                person3.style.backgroundImage = new StyleBackground (prodo);
                break;
            case 113:
                person2.style.backgroundImage = new StyleBackground(cyclops);
                break;
            case 117:
                person3.style.backgroundImage = new StyleBackground(medusa);
                break;
            case 123:
                person1.style.opacity = 0;
                break;
            case 125:
                person1.style.opacity = 100;
                person1.style.backgroundImage = new StyleBackground(prodo);
                break;
            case 126:
                person2.style.backgroundImage = new StyleBackground(griffin);
                break;
            case 130:
                person2.style.backgroundImage = new StyleBackground(faneia);
                break;
            case 150:
                uiCode.Root.style.display = DisplayStyle.Flex;
                Destroy(this.gameObject);
                
                break;





        }
    }
}
