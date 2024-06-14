using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Day0Dia : MonoBehaviour
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

    Day0CombatUIHolder combatUIHolder;
    public CyclopsUIHolder cyclopsUIHolder;

    public Sprite medusa;
    public Sprite grififn;
    public Sprite harpie;
    public Sprite cyclops;
    public Sprite prodo;
    public Sprite faniea;
    public Sprite avatar;


    public void Start()
    {
        combatUIHolder = GameObject.Find("UIDocument").GetComponent<Day0CombatUIHolder>();
        cyclopsUIHolder = GameObject.Find("UIDocumentBoss").GetComponent<CyclopsUIHolder>();
        combatUIHolder.Root.style.display = DisplayStyle.None;
        cyclopsUIHolder.Root.style.display = DisplayStyle.None;
        NextLine();
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            index = 100;
        }
        if ((Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space)) && index !=61 && index != 101)
        {
            NextLine();
        }
    }

    public string[] S = new string[]
    {
        "Stop it, you're only going to make the pain worse. : Medusa",
        "Relax buddy, we's nots here to make ouchies on you remember? : Cyclops",
        "You don't look good. Did your brain fall out when you hit your head? : Cyclops",
        "Avatar picks himself up from off the pile of blankets and stumbles to thier feet, legs wobbling all the while. " +
        "Avatar tries to make thier way to the flaps of the tent. : ???",
        "Well, you're moving again. That's a good thing right? : Cyclops",
        "Cyclops, you can't just let the human walk away, they'll be back for us any minute now. : Medusa",
        "Cyclops stares at Medusa in a dumbstruck expression, with Medusa forcing herself to shake Cyclops by his shoulder to get his attention. : ???",
        "The human Cyclops. Pay attention to the human. : Medusa",
        "Oh ya, righty-o. : Cyclops",
        "Cyclops dashes towards the main flaps of the tent, preventing Avatar's escape effort. " +
        "Avatar's face sinks and turns gray with fear : ???",
        "Oh come on buddy, I already told you we ain't gonna hurt you! : Cyclops",
        "We're the ones who saved you remember? If it weren't for us you'd have been at the mercy of the mutants by now.: Medusa",
        "Two new figures, PRODO and FANIEA, step into the tent, both out of breath and disheveled. " +
        "They knock Avatar to the ground, not knowing that they were in front of the tent flaps. : ???",
        "Medusa walks over towards Prodo and Faneia, while Cyclops kneels to Avatar's ground level, making sure they aren't hurt further. : ???",
        "Hey! That was mean. You could have hurt them more. : Cyclops",
        "Hey, it's not like I meant it. : Prodo",
        "Okay, maybe I should've yelled first before coming in. I'm sorry. Hate to be a spoil sport but we've got bigger fish to fry right now. : Prodo",
        "In layman's terms, some mutants managed to penetrate Teras Para's defenses.: Faneia",
        "How many? : Medusa",
        "Just four low tier griffins, but it's definitely something we shouldn't take lightly. " +
        "Griffin has already taking the initiative but he needs backup. : Faneia",
        "So make sure this kid is well rested and help us out. We've got at least two more people to worry about and they're pretty high risk as is. : Faneia",
        "I'm fully aware of that. " +
        "Alright, we'll be out shortly, just hold off those mutants and make sure they don't cause extensive damage " +
        "to any of the shelters or get into our food supply.: Medusa",
        "Aye aye. : Prodo",
        "Prodo jokingly salutes Medusa. Faneia lightly hits Prodo and the two step out. : ???",
        "Cyclops, get the human back in bed and lets go. : Medusa",
        "Okie dokie yokie. : Cyclops",
        "Cyclops scoops Avatar in his big arms and carries him back towards the piles of blankets, laying him on top of them gently. "+
        "Medusa and Cyclops exit the text through the front flaps. "+
        "Cyclops purposely drops something on his way out. : ???", 
        "Avatar, still conscious and attentive, picks his head up and motions his upper body to get up while still lying on the blankets. : ???",
        "God, is this a dream? A fantasy? A nightmare? " +
        "I don't how I got here but like hell if I'm staying here for another second. It's literally doomsday out there.: Avatar",
        "Avatar hears sounds of the mutants screeching from outside the tent. : ???",
        "Those monster cries sound so real, so auditory, like something out of a horror movie. But it can't be real. But somehow it is. : Avatar",
        "The sounds of the mutants screeching get closer and closer. : ???",
        "Well whatever the case, I'm not sure if those guys'll be able to handle this on their own. " +
        "If I'm gonna get out of here I'll need them to be alive to help me. I gotta do something at least, but what? : Avatar",
        "Avatar gets up, stumbles a bit, and scopes out the tent. " +
        "In the corner of where they were initially being tended to, they finds two things, a green medical capsule and a pair of brass knuckles. : ???",
        "Well, isn't this convenient. : Avatar",
        "Avatar drinks the green fluid from the medical capsule, completely restoring them and healing all prior cuts, bruises, and other injuries. " +
        "Avatar then proceeds to put on the brass knuckles and posses a fighting stance. : ???",
        "Okay, all or nothing, lets do this. : Avatar",
        "Avatar exits the tent to the sight of... : ???",
        "Mass chaos, smoke and fire enveloping several shack-like building and/or structures. Avatar jolts outside the tent to find Medusa, Cyclops, Prodo, and Faniea battling a " +
        "small hoard of enemies. : ???" +
        "Four small Griffins, quadrupedal creatures with the head and wings of an eagle and body structure of a lion, alongside dark black, orange, violet, and yellow fur" +
        "and feather colorations across all boards, with pulsating bloody red sores on their bodies, pitch black eyes, emanating a shadowy aura and drooling a darkened steamy liquid from their mouths. : ???", 
        "Avatar surveys the area. Teras Para itself look used, run down, almost falling apart. " +
        "Medusa and the others are backed into a concer, Avatar observing them. : ???",
        "Boy, the lord sure was kind to us today. : Cyclops",
        "Kind? If you ask me he's being mean today. : Medusa",
        "Mean? These mutants got us backed up to a corner, we're just lucky they haven't bitten us yet. They're not mean, their ferocious. : Prodo",
        "I think we overestimated our own abilities, a true testament to the true viciousness of these mutants. : Faneia",
        "Where did you say Griffin was? : Cyclops",
        "He had to evacuate the other two, he couldn't hold off these guys by himself anymore. : Faneia",
        "Okay, but how are we supposed to win now? : Cyclops",
        "Avatar rushes over towards Medusa, Cyclops, Prodo, and Faneia and stands right in front of them in a battle ready stance. : ???",
        "New human? What are you doing up and about? I thought we sedated you? : Medusa",
        "And how'd you get better so quickly? : Cyclops",
        "Wait, wasn't that tent back there where we kept our Grade A healing capsules? You moved all of them to the medical tent, didn't you? : Prodo",
        "I must've forgot one then. : Cyclops",
        "Cyclops, you know better don't you. We're supposed to be rationing those out evenly, and to only use them for emergencies only. : Medusa",
        "The Griffins begin roaring, startling everyone. The Griffins begin closing in on the group. : ???",
        "Now's probably not the time to argue about this. These creatures mean business. " +
        "If the kid wants to fight, let him help, we're going to need all of the help we can get at this point. : Faneia",
        "Medusa, Cyclops, and Prodo turn to face each other, then back at Avatar, and then back at each other again. : ???",
        "Okay, okay, looks like we need you after all. But just be careful. : Prodo",
        "Hope you remembered not to skip leg day mutants, because I'm about to come at you. : Prodo ",
        "Just stay cautious little one, don't underestimate these enemies, they're not to be taken lightly. : Medusa",
        "The battle's starting, the battle's starting, the battle's starting! Bring it on! Bring it on! : Cyclops",
        "",
        "A fight ensues, Avatar, Medusa, Cyclops, Prodo, and Faneia versus the Griffins. " +
        "After several punches, sword strikes, and other forms of comabt, the Griffins are defeated, with celebratory posing from every victorious hero. : ???",
        "Avatar, Medusa, Prodo, and Faneia turn their attention towards Cyclops, bloody, cut, and badly bruised, heavily panting on the ground and reaching out his hand towards Medusa. " +
        "Medusa rushes to his side.: ???",
        "Cyclops! Are you okay? : Medusa",
        "Ugh...those little buggers got me good, but I think I'll be okay. They're only little bites, I've gotten hurt way worse before. : Cyclops",
        "Avatar, Prodo, and Faneia rush over towards Cyclops as well. : ???",
        "Oh man that looks serious, you're definitely one to downplay your own injuries Cyclops. : Prodo",
        "It looks like he needs medical attention fast. Someone should escort him to the medical tent. : Medusa",
        "Faneia turns her head towards Prodo, nodding her head directly to Cyclops as a sign of suggestion. : ???",
        "No problem, I'll take him. Keep an eye on the others kid, protect them as if it were me. " +
        "Don't let your guard down, more of them might come. Fend off another hoard on your own if you have to, though personally I wouldn't. : Prodo",
        "You don't have to tell me twice. : Medusa",
        "Placing Cyclops' arm under his shoulder, Prodo carries Cyclops off screen. " +
        "A gust of wind pierces through the heroes. Avatar, Medusa, and Faneia look over their heads to the orange and brown lit skies to see GRIFFIN. : ???",
        "In a hurried pace, Griffin walks over towards Avatar, Medusa, and Faneia, breathing heavily while trying to stretch his wings, screeching in pain in the process of doing so. : ???",
        "M, I successfully relocated the kid and the old man to the designated safe area. : Griffin",
        "That's great to hear, though it doesn't sound like you're way too concerned about that fact. : Medusa",
        "Well don't get me wrong, I was initially worried but I had everything under control. : Griffin",
        "The reason I sound worried is because we've got a little bit of a predicament on our hands. : Griffin",
        "That being? : Faneia",
        "Well...Look. : Griffin",
        "Griffin points towards the direction where he came from. " +
        "Several humanoid flying figures are in the far distance, coming closer and closer with every passing second. : ???",
        "Oh God, are those what I think they are? : Avatar" ,
        "The flying figures come within closer range of the heroes, revealing themselves to be Harpies, humanoid females with bird wings for arms and talons for feet. : ???",
        "There are six of them to be exact, covered in red and black feathers, with pulsating bloody red sores on their bodies, pitch black eyes, emanating a shadowy aura and breathing fiery red smokeout of their mouths. " +
        "Medusa's face scrunches in anger. : ???",
        "Harpies. : Medusa",
        "Yessiree, it's like these mutants are desperate or something. These things only come out when it's really serious. : Griffin",
        "I'm still a bit queasy from the last fight. : Faneia",
        "Medusa clenches her fist in a fit of rage at the sight of the Harpies. " +
        "The Harpies approach the heroes where they all stand, hovering over them by flapping their wings in the air. Avatar backs up a bit. : ???",
        "Yup, no doubt anymore, this is really happening. So lifelike, their details are immeasurable : Avatar",
        "Small quakes of the earth can be felt by Avatar, Medusa, Griffin, and Faneia. The three of them turn to see a gargantuan sized Cyclops. : ???" ,
        "A taller variant with the sharper fangs and dragon-like scales, with pulsating bloody red sores on it's body, a singular large pitch black eye, emanating both a shadowy aura. : ???", 
        "The Cyclops is as tall of the shack-like houses of Teras Para, towering over the heroes. The Cyclops lets out a monstrous roar, almost knocking over the heroes in a mighty gust of wind. : ???",
        "God, we're completely surrounded. Looks like we're going to have to divide the work per say. : Griffin",
        "Agreed. How about you and I take on The Blob over here. And you and the kid do what you can to take care of these harpies. : Faneia",
        "Or you three can take on the monkey and I'll take the harpies on myself. : Medusa",
        "Are you crazy, you're outnumbered. There's no way you can take them all on your own. : Griffin",
        "It's like Prodo just said, Fend off another hoard on your own if you have to. I'll handle it. : Medusa",
        "I think that was more of a sarcastic suggestion. : Griffin",
        "Medusa yanks herself away from Griffin's grasp, running off screen with the harpies giving chase after her. " +
        "Griffin turns his attention back towards the Cyclops, as the large ape beats his chest rapidly, ready to fight. : ???",
        "Ugh, that stubborn gorgon. Well, at least we're outnumbering this guy. : Griffin",
        "Ya, but he sure does beat us in size. : Faneia",
        "That's true. : Griffin",
        "Avatar, Faneia, and Griffin battle the Cyclops. After several punches by Avatar, stabs by Faneia, claw swipes by Griffin, " +
        "and various fist attacks by the mutant Cyclops, the Cyclops collapses, fading away into nothingness. Everyone make a celebratory pose. : ???",
        "Man, that was a rush. : Avatar",
        "Griffin and Faneia survey the surrounding areas. : ???",
        "Well, I think that's about the last of them. : Faneia",
        "Good riddance, but I'm sure it won't be long before more mutant hoards come back here to begin the cycle yet again. " +
        "We've always gotta be on our guard. : Griffin",
        "Faneia nods her head in agreement. : ???",
        "I really hope Medusa didn't over exert herself. Let's check to see if she's making out alright. " +
        "If the harpies are still alive, we'll be there to help her out. : Griffin",
        "Avatar, Faneia, and Griffin runs towards Medusa's direction. After a bit of short distance travel, they find Medusa inspecting the corpses of all six harpies with varying fatal injuries, " +
        "ranging from stab wounds and decapitations, to ripped off limbs and entrails cut out of their bodies. : ???" ,
        "Feathers litter the ground beneath Medusa's feet, as she herself is covered in blood. " +
        "Avatar, Faneia, and Griffin's mouth are ajar in fear and astonishment. Griffin covers Avatar's eyes with his wings. : ???",
        "The harpies have been taken care of. : Medusa",
        "Damn girl, I know you're not too fond of harpies but I never knew you could be capable of this kind of screwed up shit. : Prodo",
        "Prodo approaches the party awestruck, his eyes widened and knees jittering all about, not able to stand still. : ???",
        "Good lord Medusa, this is horrifying. Did you at least make sure no one else saw you basically disembowel these mutants, " +
        "think of the life long scarring you could have caused someone. : Griffin",
        "Oh come on, everyone here is already traumatized as it is, what would have changed had they saw me do it. But that doesn't matter, just look around. : Medusa",
        "Medusa motions her hands all across the refugee camp, showing that no one else is present but them. : ???",
        "We're the only ones here. : Medusa",
        "Well even so, just at least try to control yourself next time. I know you don't like those things but let your emotions get the better of you and you could wind up dead or worse." +
        " Just pray that you know who doesn't find out about this little incident. : Griffin",
        "Medusa looks down at the ground, breaking eye contact from Griffin. : ???",
        "Like I care. Not like these Harpies would've considered you know who a friend. : Medusa",
        "Medusa picks her head back up. Avatar looks at Griffin in confusion. : ???",
        "It's a long story kid, we'll talk later. : Griffin",
        "Avatar, Medusa, Faneia, Griffin, and Prodo all walk off screen. From behind a large boulder emerges HARPIE. " +
        "She looks down upon the corpses of the other harpies. She looks in the direction where Medusa walked off and then back at the harpy corpses.: ???",
        "I'd like to say my heart goes out to all of you, but I can't. You're like a monstrous carbuncle on the face of a much-loved, elegant friend. : Harpie",
        "Avatar, Medusa, Prodo, Faneia, and Griffin surround a bed where Cyclops is lying down with his head elevated slightly." +
        " Prodo gives Cyclops a cup of tea, as Cyclops proceeds to sip it slowly.: ???",
        "How is it? : Prodo",
        "Great, my favorite too. : Cyclops",
        "Blueberry and mint spices with pepper flakes and spider eggs. Always making sure everyone is well nourished and tended to. : Medusa",
        "Cyclops sips the tea much more vigorously. Medusa, Prodo, Faneia, and Griffin turn their attention back towards Avatar. : ???",
        "Okay, so now that the day is won, what are we planning on doing with this kid? : Faneia",
        "When me and Cyclops found them, they was all alone, barely conscious. Who are you exactly? : Medusa",
        "Avatar begins to panic, unsure of what to say. Sweat beads start forming on their face. Eventually, Avatar motions thier mouth and arms in response. " +
        "Medusa, Cyclops, Prodo, Faneia, and Griffin's eyes widen at Avatar's response. : ???",
        "I see, you don't remember anything except for what has happened now. I'm so sorry. : Medusa",
        "Avatar wipes their forehead in relief, relieved that they believed the fib. Cyclops picks himself up from his bed ever so slightly. : ???",
        "Well it seems the kid doesn't have a home. : Cyclops",
        "It wouldn't do us good to leave them to fend for themself on the streets. That's not us. : Griffin",
        "But we've got enough people living here as it is, we're at max capacity here.: Faneia",
        "Oh come off it Faneia, you say that every time someone new comes in but the outcome's always the same. : Prodo",
        "Ya, we all know that deep down you're just a big softy.: Griffin",
        "Faneia stompped the ground in both anger and embarrassment, looking down at the ground all the while. She picks her head back up and turns her attention towards Medusa. : ???",
        "We'll have to rework our food and supply rationing system, give the kid a place to sleep among the others, and to top it all off, we'll have to have to put the kid to work.: Faneia",
        "Like Prodo said, we've managed to make it all work before. : Medusa",
        "I know: Prodo",
        "What do you say, Faneia? : Medusa",
        "Faneia turns her attention back towards the rest of the group. Faneia puts her hands on Avatar's shoulders. : ???",
        "Alright kid, you can stay here. But don't think you'll be living the easy life, you're gonna be putting those fighting skills of yours to good use for us and everyone else in Teras Para." +
        " You will help us on our quest to rid the world of these mutants right? : Faneia",
        "Avatar nods their head in agreement. : ???",
        "Excellent, I'll give you a tour of the facility tomorrow morning. In the mean time, rest and recuperate yourself, there's no telling what those mutants have in store for us. : Prodo",
        "I'm gonna help replenish our defensive barriers in the outer borders, today's battle sure did a good number on them." +
        " It'll probably take me the rest of the day so I'll see you when I see you I guess. : Prodo",
        "Prodo waves goodbye to the group and exits the medical tent. " +
        "Cyclops fully gets up from out of bed and stands up, only loosing balance just a tad. Cyclops walks over towards Avatar: ???",
        "Well looks like you're here to stay buddy. : Cyclops",
        "It might be hard in the beginning but I'm sure you'll manage to learn the ropes in no time. " +
        "It's just a little thing we say to all of our new recruits. : Griffin",
        "Now now, settle down now, lets not excite this child more than they already is. Now keep in mind we can't give you your own tent, " +
        "so you'll have to share with the other child in the camp, are you okay with that? : Medusa",
        "Avatar nods their head in agreement. : ???",
        "Think of it like a sleepover where you'd meet tons of new friends. : Medusa",
        "Since when did you get all sappy? : Faneia",
        "Oh come on Faneia, that's how she always is, she just doesn't show it often. She's a total mom. : Cyclops",
        "The group laughs in merriment, Medusa embarrassed and blushing while still laughing with the rest of the group. : ???"



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
            case 1:
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 2:
                Person1.GetComponent<Image>().sprite = medusa;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = cyclops;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 13:
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 15:
                Person3.GetComponent<Image>().sprite = cyclops;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 16:
                Person1.GetComponent<Image>().sprite = cyclops;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = prodo;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 18:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = faniea;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 19:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = faniea;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 24:
                Person1.GetComponent<Image>().sprite = null;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person2.GetComponent<Image>().sprite = null;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 27:
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 40:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = cyclops;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 44:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = cyclops;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = faniea;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 49:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = cyclops;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 54:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = faniea;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 56:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = cyclops;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 61:
                StartBattle();
                break;
            case 62:
                Person1.GetComponent<Image>().sprite = null;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person2.GetComponent<Image>().sprite = null;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 64:
                Person1.GetComponent<Image>().sprite = medusa;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = cyclops;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 67:
                Person1.GetComponent<Image>().sprite = prodo;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = cyclops;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 72:
                Person1.GetComponent<Image>().sprite = null;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person2.GetComponent<Image>().sprite = null;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person3.GetComponent<Image>().sprite = medusa;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 74:
                Person1.GetComponent<Image>().sprite = medusa;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = grififn;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 78:
                Person3.GetComponent<Image>().sprite = faniea;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 98:
                Person1.GetComponent<Image>().sprite = faniea;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = grififn;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 101:
                StartBossBattle();
                break;
            case 104:
                Person1.GetComponent<Image>().sprite = faniea;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = grififn;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 113:
                Person1.GetComponent<Image>().sprite = medusa;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = grififn;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = prodo;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 123:
                Person1.GetComponent<Image>().sprite = null;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person2.GetComponent<Image>().sprite = null;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                Person3.GetComponent<Image>().sprite = null;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0f);
                break;
            case 124:
                Person3.GetComponent<Image>().sprite = harpie;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 125:
                Person1.GetComponent<Image>().sprite = medusa;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = prodo;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = cyclops;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 130:
                Person1.GetComponent<Image>().sprite = medusa;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = prodo;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = faniea;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 150:
                Person1.GetComponent<Image>().sprite = medusa;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = null;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 0);
                Person3.GetComponent<Image>().sprite = faniea;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 151:
                Person1.GetComponent<Image>().sprite = medusa;
                Person1.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person2.GetComponent<Image>().sprite = cyclops;
                Person2.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                Person3.GetComponent<Image>().sprite = faniea;
                Person3.GetComponent<Image>().color = new Color(255f, 255f, 255f, 255f);
                break;
            case 158:
                SceneManager.LoadScene(4);
                break;

        }
        
    }
    void StartBattle()
    {
        GameObject.Find("Canvas").SetActive(false);
        combatUIHolder.Root.style.display = DisplayStyle.Flex;
    }

    void StartBossBattle()
    {
        GameObject.Find("Canvas").SetActive(false);
        cyclopsUIHolder.Root.style.display = DisplayStyle.Flex;
    }
}
