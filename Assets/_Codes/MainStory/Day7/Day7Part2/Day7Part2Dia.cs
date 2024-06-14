using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;

public class Day7Part2Dia : MonoBehaviour
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
    public Day7Part2DaiCont dialogue;
    public int index = 0;
    public bool RanAlready;
    public string speaker;

    public Sprite prodo;
    public Sprite faneia;
    public Sprite GameMaker;

    //public UI uiCode;

    public void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
        Root = GetComponent<UIDocument>().rootVisualElement;
        Background = Root.Q<VisualElement>("backGround");
        person1 = Background.Q<VisualElement>("person1");
        person2 = Background.Q<VisualElement>("person2");
        person3 = Background.Q<VisualElement>("person3");
        textBox = Root.Q<VisualElement>("textBox");
        textDia = textBox.Q<Label>("textDia");

        Day7Part2DaiCont.instance.DialogueBox = textBox;
        Day7Part2DaiCont.instance.DialogueTextBox = textDia;

        NextLine();
        Debug.Log("Worked");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            NextLine();
        }
        
    }

    public string[] S = new string[]
    {
        "Avatar approaches Prodo and Faneia. : ???",
        "So, are you raring to go? : Faneia",
        "Avatar nods his/her head in agreement.: ???",
        "Okay then, remember, there's no turning back. What you have with you is what you'll have for a while.There might be some more supplies in the mountains but I cannot guarantee it. : Faneia",
        "So hopefully you packed smart. But given what we've seen from you so far, I'd say you'll manage fine even if you packed a little lighter then usual. : Prodo",
        "Good luck you three, make sure the moon don't beat you to the mountains,don't loose the race. : Cyclops",
        "Avatar, Prodo, and Faneia begin to walk away from the Tactic Tent, with Medusa, Cyclops, and Griffin waving them goodbye. : ???",
        "Faneia grabs Prodo by his shoulder, stopping him dead in his tracks as he turns to face Faneia. Avatar continues on without him.",
        "Remember, let's keep our guard when it comes to the kid. : Faneia",
        "I'm still not sure, we could be wrong. : Prodo",
        "But we could also be right. On the off chance he knows the mountains like the back of his hand, we shouldn't loosen up. : Faneia",
        "No problem. : Prodo",
        "And don't forget, it's our secret for now. If the kid proves a serious threat, that's when we out him.",
        "Well maybe we should take the time to assess the situation rather than just blindly outing them in front of Medusa and the others. We'd have to figure out what to do with them if you're right. : Prodo",
        "I wouldn't want to take the chance, if they are who we think they are,their outta here. : Faneia",
        "Well, we'll talk later, how does that sound? : Prodo",
        "Fine, later. Let's just focus on this mission and be careful okay. : Faneia",
        "I promise. I love you. : Prodo",
        "Don't say it like that, you know you can be really cliche sometimes. : Faneia",
        "Hey, they're effective aren't they? : Prodo",
        "Prodo and Faneia kiss each others cheeks. Prodo and Faneia walks off screen to join Avatar. : ???",
        "Avatar, Prodo, and Faneia venture through rough and rugged mountain terrains. The coloration of the various rocks that make up the mountains range from light purple to light brown and ash gray.",
        "Mist envelopes the mountain region and is very thick and condensed.",
        "", // Fighting in mountains 
        "The three party members make their way through the mountains via climbing, long jumping, and navigating which pathways are correct and which pathways lead no where.",
        "They come across a few enemies, which include harpies, griffins, and cyclopes'. After various instances of defeating mutants, solving puzzles, and traversing the harsh landscape, the three party members finally comes across...",
        "Proti Vasi, a large structure resembling a castle of Romanesque, Gothic, Renaissance, and Baroque origin. It looks run down and half demolished, plagued by water damage and vines have entangled almost every nook and cranny.",
        "The fortress is blocked off by an iron gate and barbed wire, two chipped and cracked gargoyle statues stand parallel at the gate.",
        "The front of the property is littered with human bones and various geysers erupt with steam and boiling hot water. The path leading to the front of the house is made out of cobblestone with weeds growing out of the crack. The three party members approach the iron gate.",
        "What is this place? : Prodo",
        "Hard to say, looks like the house of a recluse. : Faneia",
        "Should we go in? : Prodo",
        "Doesn't look like we have that much of an option? : Faneia",
        "Indeed, but question is, how are we gonna get in? : Prodo",
        "Avatar stands closer in front of the iron gate and picks the lock, opening it. Avatar looks back at Prodo and Faneia in a triumphant stance. : ???",
        "Oh...well...great job. : Prodo",
        "Well, that's definitely one way to open a lock. : Faneia",
        "The three party members make their way through the iron gates and soon manage to open the front door of the estate.The three party members head into Proti Vasi. : ???",
        "The three party members enter the main foyer of Proti Vasi. There are many staircases leading both upstairs and downstairs.",
        "The foyer itself is Victorian in design and aesthetic, 19th century Dutch light fixtures, black and white checkerboard marble floor tiles, natural cedar doors throughout house, arched stained glass windows, floor medallion, upholstered benches, decorative credenza, and a cathedral-esque ceiling.",
        "Everyone's mouth are gaped and their eyes are widened. Avatar stands in the front of the foyer, observing everything he is able to see.",
        "This place is pretty, but in a lot more ways then one. : Prodo",
        "Pretty nice. : Faneia ",
        "But also pretty ominous. : Prodo",
        "Prodo and Faneia meet in the center where Avatar is standing. : ???",
        "What are you thinking? : Prodo",
        "Avatar motions his mouth and arms in response. : ???",
        "I see, so you have a feeling you think something's here too. What exactly? : Avatar",
        "Before Avatar can respond, Prodo and Faneia hear a screaming sound coming from one of the rooms furthest from them.",
        "Did you hear that? : Prodo",
        "Could be a mutant. : Faneia",
        "We better check it out. No time to waste. Stay close to me and each other.: Prodo",
        "The three party members make their way to a door in the furthest corner of the foyer, a door made out of wood and reinforced iron. The three party members notice the door is cracked open, with puddles of green liquid spilled on the floor outside of the door. Faneia opens the door, leading the rest of the party inside to find... : ???",
        "A room cluttered with large vile-like tubes filled with suspiciously thick green liquid of unknown origin. All the tubes are bubbling, some overflowing at the top and spilling all over the floor.",
        "In the room, a thick metallic freezer door is open, it's contents comprising of various organs such as hearts, spleens, and brains pickled in red labeled jars.",
        "The coolness from the freezer seeps into the room, evident by frost forming on a work desk covered in various papers, syringes, and prescription drug containers spilled all over the desk. Prodo examines the confines of the desk, looking over various papers.",
        "Faneia examines the freezer, picking up a brain in a jar, being careful not to drop it due to the cold touch of the glass. Avatar examines the green tubes, being careful not to step in the overflowing green liquid. The room is like a fun house maze for Avatar, looking at himself/herself in the reflection of the glass tubes.",
        "Uh...guys, take a look at this. : Faneia",
        "Avatar and Prodo walk over towards one of the green tubes where Faneia is standing, still holding the brain in a jar.: ???",
        "Faneia looks at a sleeping figure floating in the tube in astonishment, a mutant gorgon, with dark red skin adorned with white spot markings, hair comprised of multiple hissing snakes, a serpentine body alongside skinny, bony legs, with pulsating bloody red sores on her body, pitch black eyes, and emanating a shadowy aura.",
        "Faneia drops the brain in a jar, with everyone looking down at the mess of liquid, brain matter, and broken glass.",
        "Sorry, its just, I mean, oh my god. : Faneia",
        "Avatar, Prodo, and Faneia look back at the gorgon in the  tube.",
        "Did they kidnap Medusa? : Prodo",
        "It can't be her, this gorgon's a lot larger than she is. I'm not sure what I'm looking at here. : Faneia",
        "Holy shit. : Prodo",
        "Look at that.",
        "Prodo points in the direction of other tubes in the room across from where he is standing. In those tubes are more mutant griffins, floating unconscious. Faneia walks over towards the other tubes and places her hand on the glass, hoping to get the attention of the unconscious mutant to no avail.",
        "This is some next level Frankenstein shit going on here. I don't know what's going on here but I want answers now. : Faneia",
        "I found some papers on the desk over there. : Prodo",
        "Prodo hands Medusa the papers. : ???",
        "It's all gibberish, must be in a\r\ndifferent language or something. I\r\ncan't read this.\r\n: Faneia",
        "Faneia looks at the papers, trying desperately to read them.\r\nFrustrated, she crumples up the papers and throws them on\r\nthe ground. : ???",
        "I don't get it, I just don't get it.\r\nWhat's going on here. : Faneia",
        "Isn't it obvious? : Game Maker",
        "From behind on of the tubes, The Game Maker makes himself\r\npresent. Prodo and Faneia back up a bit, while Avatar stands\r\nhis ground. : ???",
        "You again!\r\n : Faneia",
        "What do you want this time pal? Is\r\nthis your lab? : Prodo",
        "The Game Maker walks closer to the main party.\r\n : ???",
        "Maybe it is, maybe it isn't. Isn't\r\nthe mind fascinating? So many\r\nquestions lingering in your head, and\r\nyet, it can't comprehend it's own\r\ncomprehension of reality being\r\nbroken. ",
        "Prodo unsheaths his sword and points it in The Game Maker's\r\ndirection.",
        "You better start talking, you better\r\nstart talking right now. : Prodo",
        "I thought for sure you would've\r\nfigured it out right now, so I guess\r\nI'll help you pinpoint the truth.\r\n : Game Maker",
        "I don't necessarily blame you for\r\n\r\nbeing flustered, it's a lot to take\r\nin. A cluttered mind is never a good\r\nthing.\r\n",
        "Out with it! : Prodo",
        "It's pretty obvious isn't it, the\r\ntubes, the organs, the\r\ndocumentations. All the makings of a\r\nsuspenseful classic science fiction\r\nhorror movie. I believe your romatinc intrest called referenced this\r\nscenario with that of a Frankenstein\r\nmovie, did I hear that right? : Game Maker",
        "So...this is where the mutants came\r\nfrom? : Prodo",
        "Precisely.\r\n : Game Maker",
        "The three party members look at each other in astonishment,\r\nFaneia putting her hands on her head. : ???",
        "Medusa was born here? : Prodo",
        "The others were born here. : Faneia",
        "The lights in the room begin to flicker red with sirens\r\ngoing on and off. The tube holding the gorgon mutant open,\r\nit's liquid seeping all over the floor. The gorgon drops to\r\nthe floor quickly. The gorgon gets up and opens her eyes,\r\nexamines the main party, and hisses. : ???",
        "Subsequently, three\r\ntubes housing griffin mutants open as well, the liquids\r\nseeping all over the floor. The griffins drop to the floor\r\nquickly. The griffins open their eyes, examine the main\r\nparty, and begin to squawk and roar. The gorgon and griffin\r\nmutants start to approach the main party together.\r\n",
        "Seems to me that you've got a battle\r\nto win here. Better get to it. You\r\ndon't want to disturb the narrative\r\nnow do you? : Game Maker",
        "Jesus Christ, looks like we're at it\r\nagain. : Faneia",
        "Here goes nothing I guess. : Prodo",
        "", // Boss Battle
        "A boss battle ensues. Avatar, Prodo, and Faneia versus the\r\nmutant gorgon and mutant griffins. : ???",
        "After several punches,\r\nsword strikes, club batting, and shooting, the gorgon and\r\ngriffins are defeated, with celebratory posing from every\r\nvictorious hero. The main party turns their attention back\r\ntowards The Game Maker, who is slowly clapping at their\r\nvictory. ",
        "Bravo, bravo, well done, that looked\r\nlike a battle for the ages.\r\n : Game Maker",
        "Cut the crap, all right, cut it. : Faneia",
        "Please don't tell me you're the one\r\nresponsible for this.\r\n : Prodo",
        "As I've said many times, maybe I am,\r\nmaybe I'm not. It is for you to find\r\nout.\r\n : Game Maker",
        "You keep saying that but I don't\r\nunderstand what you're talking about. : Faneia",
        "The narrative knew you'd say\r\nsomething like that. : Game Maker",
        "The narrative? What do you mean by\r\nthe narrative? : Prodo",
        "This world is like a story, I am in\r\ncharge of explaining it's intricate\r\ninner mechanisms and ensuring\r\neverything that has been set in stone\r\ngoes as according to plan. : Game Maker",
        "Nothing is\r\nto detract from the initial goal and\r\nI must ensure you all stay on the\r\nbeaten path. ",
        "You mean that fight back there, you\r\nknew it'd happen.\r\n: Prodo",
        "Correct.: Game Maker",
        "And you knew we'd be alright, didn't\r\nyou? : Faneia",
        "That is also correct. The narrative\r\ndictates by the end of the day that\r\nsix of you will live to see another\r\nday. : Game Maker",
        "Wait...: Prodo",
        "Prodo counts with his fingers. : ???",
        "They're seven of us in our main\r\ngroup. : Prodo",
        "I did not miscount. : Game Maker",
        "Oh no. : Prodo",
        "What is it? : Faneia",
        "We have to head back to Teras Para. : Prodo",
        "What? : Faneia",
        "Now! : Prodo",
        "As inscribed by the narrative. But I\r\nwouldn't get your hopes up. : Game Maker",
        "The three party members leave the mutant tank room, with The\r\nGame Maker vanishing in thin air as soon as Avatar is the\r\nlast one to leave the room. : ???",
        "Medusa, Cyclops, Griffin, and Harpy are fighting off a hoard\r\nof three mutant cyclops'. Harpy swipes at two of them with\r\nher sharp talons but is swatted away like a house fly.",
        "Griffin pecks at their heads. Cyclops tries tackling\r\nthem but is shoved on the ground. Avatar, Prodo, and Faneia\r\nreturn from the mountains to aid the rest of the party in\r\nthe battle.",
        "Miss us? : Prodo",
        "You arrived just in time! : Medusa",
        "They came out of now where, like they\r\njust appeared out of thin air. : Harpy",
        "It's probably that guy who did it. : Cyclops",
        "What guy? : Harpy",
        "Oh that's right, you weren't there,\r\nwell you seen, there was this scary\r\ncomputer face guy, and he... : Cyclops",
        "Griffin slaps Cyclops on the back, cutting him off from his\r\nsentence. : ???",
        "This isn't story time, it's battle\r\ntime. : Griffin",
        "Oh ya, right.\r\n",
        "Medusa hisses at the mutant cyclops', protecting the six\r\nother heroes with her serpentine body. : ???",
        "Did you make sure the boy and the old\r\nman are safe? : Faneia",
        "Last I saw they were running to the\r\ndesignated safe area, though these\r\nthree didn't give chase. I think it's\r\nus they're concerned about. : Medusa",
        "Then lets show them that they picked\r\nthe wrong people to mess with.\r\n : Faneia",
        "",
        "A battle ensues. The main party versus the mutant cyclops'.\r\nAfter several punches, sword strikes, bitting, and clawing the cyclops' are defeated, with celebratory posing\r\nfrom every victorious hero.: ???",
        "Two cyclops corpses are badly\r\ndamages, with one relatively in tact. The main party puts\r\ntheir weapons away and looks at the damage. ",
        "Looks like they didn't really do that\r\nmuch to the camp.\r\n : Prodo",
        "Very minimal damage. : Griffin",
        "Lets be fortunate it wasn't worst. : Harpy",
        "Behind them, the still in tact mutant cyclops opens his eye,\r\nmaking his gaze to Faneia unbeknownst to her. : ???",
        "So you're saying you had no idea how\r\nthey got in here? : Medusa",
        "No clue, one minute is was in the\r\ntraining grounds minding my own\r\nbusiness, next thing I know, three\r\ncyclops' come out of no where. I\r\ndidn't here a crash or foot stomps or\r\nanything. They just appeared. : Medusa",
        "I have a lunch it's that guy that did\r\nit, I bet on it. : Cyclops",
        "Hunch sweetheart. : Medusa",
        "After what we saw today, for once\r\nCyclops, I think you might be on to\r\nsomething. : Faneia",
        "Really? : Cyclops",
        "The mutant cyclops picks his head up and raises his arm\r\ntowards where Faneia is standing, ready to crush her. : ???",
        "What do you mean by vaporize? : Harpy",
        "Well it's like he shot a beam of\r\nlight from his hand and... : Cyclops",
        "Prodo turns his head and see the still living mutant cyclops\r\nready to crush Faneia. : ???",
        "Faneia! Look out! : Prodo",
        "Huh? : Faneia",
        "Prodo begins to sprint towards were Faneia is standing.\r\nNoticing Faneia is in trouble. Avatar leaps in next to\r\nFaneia. : ???",
        "The cyclops swipe his hand down, but Avatar is able\r\nto catch the mutant cyclops' palm, holding it in place\r\nbefore he can crush Faneia. Seeing an opportunity to escape,\r\nFaneia runs out of the way.",
        "Avatar swings the mutant\r\ncyclops' arm out of the way as the mutant cyclops' back\r\nfalls back on the ground. Prodo leaps in the air sword in\r\ntow, falling back to the ground as he plunges his sword in\r\nthe mutant cyclops' eye, killing him instantly.",
        "The mutant\r\ncyclops' corpse subsequently burst into flames at a rapid\r\npace until there is nothing left. Prodo comforts Faneia as\r\nthe two of them fall to the ground.",
        "Are you okay? : Prodo",
        "Ya, I'm fine, I thought for sure we\r\njust killed it. : Faneia",
        "Must've had a little bit more juice\r\nin him. : Prodo",
        "That was close. : Griffin",
        "Too close if you ask me.\r\n : Cyclops",
        "Guess you're glad the kid was there\r\nto save your ass. : Harpy",
        "Enough sass Harpy, I don't need that\r\nright now. : Faneia",
        "Medusa approaches Faneia. : ???",
        "Are you okay? : Medusa",
        "Yes, I'm fine, I guess I got the kid\r\nto thank. : Faneia",
        "Avatar motions his arms and mouth for a response. : ???",
        "Yes, you're definitely lucky. : Medusa",
        "Okay, we've dealt with a lot today so\r\nI say we call it a night. I'll brief\r\nyou all on what we found out\r\ntomorrow, but be warned, the news\r\nwon't be pretty. : Faneia",
        "What do you mean by that? : Griffin",
        "Faneia looks down at the ground for a second and picks her\r\nhead back up. : ???",
        "I don't want to talk about it right\r\nnow. For now, lets just get some\r\nrest, okay. : Faneia",
        "Amen to that.: Griffin",
        "Here here. : Cyclops",
        "Prodo and Faneia are seen lying on top of the same bed\r\n together. The bed is worn out with tattered sheets. The tent\r\n itself is lined in pinkish, poorly stitched together fabric,\r\n the only other decoration being a rack of weapons on the\r\n ground. : ???",
        "Prodo is wearing blue color toned pajamas and Faneia\r\n is wearing white lingerie. Prodo has his arm around Faneia's\r\n body, with Faneia comfortable snuggling herself on Prodo's\r\n chest.",
        "Are you okay? : Prodo",
        "I'm hanging in there. Still kind of\r\n shook up about what we saw in the\r\n mansion looking place. : Faneia",
        "I feel that. : Prodo",
        "We definitely have to go back and get\r\n more answers. : Faneia",
        "I'm not sure how the others will\r\n handle it though. : Prodo",
        "I know, especially Medusa. : Faneia",
        "I'm more worried about Cyclops. : Prodo",
        "I want to ask you something about the\r\n kid. : Faneia",
        "Shoot. : Prodo",
        "Did something seem off about them today? : Faneia",
        "Not that I saw. What about you? : Prodo",
        "I definitely noticed it, the way he\r\n saved me back there tonight. It's\r\n like, somehow he was one step ahead\r\n of you. : Faneia",
        "He was a bit closer to you then me,\r\n he was just faster then I was. : Prodo",
        "Well I don't think that at all, I\r\n think it was purely instinct that\r\n drove him to save me. Like, he knew I\r\n would've been dead otherwise. : Faneia",
        "That guy we met today, said stuff\r\n about a narrative. He said that one\r\n person was going to die today. : Prodo",
        "And let me guess, that person was me,\r\n wasn't it? : Faneia",
        "You came close to it: Prodo",
        " Well I guess his prediction was\r\n wrong. : Faneia",
        "I'm really thankful it was wrong. : Prodo",
        "Do you think they're connected? : Faneia",
        "Huh? : Prodo",
        "The kid and that mystery guy. Do you\r\n think they're connected somehow? : Faneia",
        "If they were connected in any way,\r\n I'm sure the kid would've said\r\n something. Or at least, any of us\r\n would've picked up on it. : Prodo",
        "Again, let just be on our guard. He might've saved me, but they might be playing a game of his own. : Faneia",
        " I'll be sure to do that. : Prodo",
        "Don't try and get attached to them either. That might be part of his game. : Faneia",
        "Oh don't be that way, just because\r\n you've had bad experiences with\r\n personal connections doesn't mean you\r\n have to ruin relations for everyone\r\n else. : Prodo",
        "Do you want to have sex tonight? : Faneia",
        "YES : Prodo",
        "Than I'd suggest you don't say another word. : Faneia",
        "Prodo and Faneia continue to lie on top of the bed\r\n motionless.: ???",
        " A television monitor depicts Prodo and Faneia lying in bed,\r\n as several television monitors depicts several surveillance\r\n images of Teras Para after the prior battle with the\r\n mutants. : ???",
        "The room is dark and desolate, gray and metallic,\r\n the only light fixture in the room focused on a man sitting\r\n in a lone chair, The Game Maker. He has his hands close to\r\n his face as he ponder what he is looking at on the main\r\n screen",
        "So, it appears as if the game has\r\n changed. We'll just have to perform a\r\n course correction to ensure\r\n everything goes as originally\r\n sequenced. : Game Maker",
        "The Game Make turns his chair around as more lights flicker\r\n on, revealing various test tubes housing mutants of\r\n different shapes and sizes. The Game Maker gets up from his\r\n chair and walks over towards one of the larger test tubes,\r\n this one housing a mutated hybrid of a Cyclops and a\r\n Griffin, a large, bulbous creature with a singular pitch\r\n black eye on it's forehead, : ???",
        "four quadruped legs comprised of\r\n a goat's and lion's legs, muscular man-like arms with bird\r\n talon features, dark purple feathers and dark green dragon\r\nlike scales, wings that appear to still be growing, with\r\n pulsating bloody red sores on it's body and emanating a\r\n shadowy aura.",
        "The Game Maker strokes the outside of the test\r\n tube as if he was petting the mutant as if it was his child.\r\n The hybrid mutant opens it's eye, silently moaning, crying,\r\n and roaring at the sight of the Game Maker.",
        "These character must make no changes\r\n to their stories. The narrative must\r\n be kept uniform. : Game Maker",
        "The Game Maker looks at a few more of the television\r\n monitors, focusing in on one where Griffin is seen playing\r\n with a child in yellow and brown colored clothing. The two\r\n are passing a ball back and forth. : ???",
        "It seems I have something to work\r\n with. : Game Maker"

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
        
    }
}
