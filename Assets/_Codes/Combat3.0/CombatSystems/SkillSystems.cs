using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkillSystems : MonoBehaviour
{

    IEnumerator ChangeTurn;
    IEnumerator EnemyTurn;

    static bool isSkilling;
    static bool isUseSkill1;
    static bool isUseSkill2;
    static bool isUseSkill3;
    static bool isUseSkill4;

    public int switchCounter;

    public GameObject SkillCom;

    public GameObject mutantEnemy1;
    public GameObject mutantEnemy2;
    public GameObject mutantEnemy3;

    public combatUiHolder combatUi;

    public EnemySystem ES;
    public TurnSystem TS;

    public void Start()
    {
        combatUi = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
        ES = GameObject.Find("CombatCodes").GetComponent<EnemySystem>();
        TS = GameObject.Find("CombatCodes").GetComponent<TurnSystem>();

        combatUi.skillsHolder.style.display = DisplayStyle.None;
        combatUi.skills.RegisterCallback<ClickEvent>(SelectSkill);
        combatUi.skills1.RegisterCallback<ClickEvent>(SelectSkill1);
        combatUi.skills2.RegisterCallback<ClickEvent>(SelectSkill2);
        combatUi.skills3.RegisterCallback<ClickEvent>(SelectSkill3);
        combatUi.skills4.RegisterCallback<ClickEvent>(SelectSkill4);
        combatUi.mutant1.RegisterCallback<ClickEvent>(attackMutant1Skills);
        combatUi.mutant2.RegisterCallback<ClickEvent>(attackMutant2Skills);
        combatUi.mutant3.RegisterCallback<ClickEvent>(attackMutant3Skills);

        combatUi.skills1.RegisterCallback<MouseEnterEvent>(ShowSkill1Info);
        combatUi.skills2.RegisterCallback<MouseEnterEvent>(ShowSkill2Info);
        combatUi.skills3.RegisterCallback<MouseEnterEvent>(ShowSkill3Info);
        combatUi.skills4.RegisterCallback<MouseEnterEvent>(ShowSkill4Info);


    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            combatUi.skillsHolder.style.display = DisplayStyle.None;
            combatUi.mutantSelectHolder.style.display = DisplayStyle.None;
            combatUi.attackCommands.style.display = DisplayStyle.Flex;
            combatUi.heroInfo.style.display = DisplayStyle.Flex;
            combatUi.heroInfo.style.opacity = 100;

            combatUi.attack.style.display = DisplayStyle.Flex;
            combatUi.skills.style.display = DisplayStyle.Flex;
            combatUi.defend.style.display = DisplayStyle.Flex;
            combatUi.heal.style.display = DisplayStyle.Flex;
            combatUi.moveInfo.style.display = DisplayStyle.Flex;
        }
    }

    public void SelectSkill(ClickEvent evt)
    {
        combatUi.attack.style.display = DisplayStyle.None;
        combatUi.skills.style.display = DisplayStyle.None;
        combatUi.defend.style.display = DisplayStyle.None;
        combatUi.heal.style.display = DisplayStyle.None;
        combatUi.heroInfo.style.opacity = 0;
        combatUi.skillsHolder.style.display = DisplayStyle.Flex;
        isSkilling = true;
    }

    public void SelectSkill1(ClickEvent evt)
    {
        isSkilling = true;
        isUseSkill1 = true;
        if (TurnSystem.whoTurn != "Medusa")
        {
            combatUi.skillsHolder.style.display = DisplayStyle.None;
            combatUi.mutantSelectHolder.style.display = DisplayStyle.Flex;
        }
        else
        {
            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
        }
    }
    public void ShowSkill1Info(MouseEnterEvent evt)
    {
        switch (TurnSystem.whoTurn)
        {
            case "Medusa":
                combatUi.moveName.text = "Posion Mist";
                combatUi.moveDes.text = "Medusa covers her body in posion mist, anyone that hits her will take damage";
                break;
            case "Grififn":
                combatUi.moveName.text = "Griffin Howl";
                combatUi.moveDes.text = "Griffin let's a loud scream. AOE";
                break;
            case "Harpie":
                combatUi.moveName.text = "Harpie Spin";
                combatUi.moveDes.text = "Harpie spins her wings, using them to attack an single enemy three times";
                break;
            case "Cyclops":
                combatUi.moveName.text = "Cyclops Slam";
                combatUi.moveDes.text = "Cyclops picks up a single enemy and slams them down to the ground.";
                break;
            case "Prodo":
                combatUi.moveName.text = "Gold Strike";
                combatUi.moveDes.text = "Prodo strikes his enemy with the golden sword, chance to turn enemy to gold";
                break;
            case "Faneia":
                combatUi.moveName.text = "Vemon Blade";
                combatUi.moveDes.text = "Faneia coat her blade in medusa vemon before striking an single enemy. Chance for posion";
                break;
            case "Avatar":
                combatUi.moveName.text = "Skill 1";
                combatUi.moveDes.text = "Avatar defealt skill";
                break;

        }
    }
    public void ShowSkill2Info(MouseEnterEvent evt)
    {
        switch (TurnSystem.whoTurn)
        {
            case "Medusa":
                combatUi.moveName.text = "Vemon Punch";
                combatUi.moveDes.text = "Medusa coats her hand in vemon before punching an single enemy";
                break;
            case "Grififn":
                combatUi.moveName.text = "Griffin Leap";
                combatUi.moveDes.text = "Griffin jumps from one enemy to the next, attacking all enemies in battle.";
                break;
            case "Harpie":
                combatUi.moveName.text = "Harpie Bite";
                combatUi.moveDes.text = "Harpie flies over to an single enemy and bites them, heal her health";
                break;
            case "Cyclops":
                combatUi.moveName.text = "Cyclops Clap";
                combatUi.moveDes.text = "Cyclops claps his hands together quickly, sending a wind blow to a single enemy.";
                break;
            case "Prodo":
                combatUi.moveName.text = "X Blade";
                combatUi.moveDes.text = "Using two blades, prodo cross them forming an X on a single enemy";
                break;
            case "Faneia":
                combatUi.moveName.text = "Rapier Implae";
                combatUi.moveDes.text = "Faneia grabs an enemy simialr to cyclops and impales her rapier into them";
                break;
            case "Avatar":
                combatUi.moveName.text = "Skill 1";
                combatUi.moveDes.text = "Avatar defealt skill";
                break;

        }
    }
    public void ShowSkill3Info(MouseEnterEvent evt)
    {
        switch (TurnSystem.whoTurn)
        {
            case "Medusa":
                combatUi.moveName.text = "Stone Shot";
                combatUi.moveDes.text = "Medusa turns her snakes into stone before shooting them an a single enemy";
                break;
            case "Grififn":
                combatUi.moveName.text = "Griffin Claw";
                combatUi.moveDes.text = "Griffin uses his claws and dig into an single enemy, clausing bleed";
                break;
            case "Harpie":
                combatUi.moveName.text = "Harpie Slash";
                combatUi.moveDes.text = "Harpie uses her wing like a blade and cuts an wound on a single enemy. Will cause bleed";
                break;
            case "Cyclops":
                combatUi.moveName.text = "Ccylops Swing";
                combatUi.moveDes.text = "Cyclops picks up a single enemy and swings them around. 2- 5 hits";
                break;
            case "Prodo":
                combatUi.moveName.text = "Sword Stab";
                combatUi.moveDes.text = "Prodo charges at an a single enemy and stab his sword deep inside them.";
                break;
            case "Faneia":
                combatUi.moveName.text = "Rally Roar";
                combatUi.moveDes.text = "Faneia commands the battlefield with a roar like Griffin. Increase team damage and defense";
                break;
            case "Avatar":
                combatUi.moveName.text = "Skill 1";
                combatUi.moveDes.text = "Avatar defealt skill";
                break;

        }
    }
    public void ShowSkill4Info(MouseEnterEvent evt)
    {
        switch (TurnSystem.whoTurn)
        {
            case "Medusa":
                combatUi.moveName.text = "Kiss of death";
                combatUi.moveDes.text = "Medusa kisses an single enemy, posioning them for the rest of the fight";
                break;
            case "Grififn":
                combatUi.moveName.text = "Griffin Fly";
                combatUi.moveDes.text = "Griffin takes flight, attacking everything he see, including team members. AOE";
                break;
            case "Harpie":
                combatUi.moveName.text = "Harpie Windstrom";
                combatUi.moveDes.text = "Harpie flaps her wings widly, causing a windstrom that covers the battlefield";
                break;
            case "Cyclops":
                combatUi.moveName.text = "Ccylops Laser Beam";
                combatUi.moveDes.text = "Cyclops fires a laser beam out of his eye. Will damage cyclops the more he uses it.";
                break;
            case "Prodo":
                combatUi.moveName.text = "Air Strike";
                combatUi.moveDes.text = "Prodo uses all hiw power and is able to cut the air, sending a powerful wind current at a single enemy";
                break;
            case "Faneia":
                combatUi.moveName.text = "X Cross";
                combatUi.moveDes.text = "Studying Prodo X attack Faneia froms a X on enemy before stabbing the center";
                break;
            case "Avatar":
                combatUi.moveName.text = "Skill 1";
                combatUi.moveDes.text = "Avatar defealt skill";
                break;

        }
    }

    public void SelectSkill2(ClickEvent evt)
    {
        isUseSkill2 = true;
        isSkilling = true;
        combatUi.skillsHolder.style.display = DisplayStyle.None;
        combatUi.mutantSelectHolder.style.display = DisplayStyle.Flex;
    }

    public void SelectSkill3(ClickEvent evt)
    {
        isUseSkill3 = true;
        isSkilling = true;
        combatUi.skillsHolder.style.display = DisplayStyle.None;
        combatUi.mutantSelectHolder.style.display = DisplayStyle.Flex;
    }

    public void SelectSkill4(ClickEvent evt)
    {
        isSkilling = true;
        isUseSkill4 = true;
        combatUi.skillsHolder.style.display = DisplayStyle.None;
        combatUi.mutantSelectHolder.style.display = DisplayStyle.Flex;
    }

    public void attackMutant1Skills(ClickEvent evt)
    {
        if (isSkilling)
        {
            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            if (combatUi.mutantMember1.name == "Griffin")
            {
                switchCounter = 1;

            }
            else if (combatUi.mutantMember1.name == "Gorgon")
            {
                switchCounter = 2;

            }
            else if (combatUi.mutantMember1.name == "Harpy")
            {
                switchCounter = 3;

            }
            else if (combatUi.mutantMember1.name == "Cyclops")
            {
                switchCounter = 4;

            }
            switch (TurnSystem.whoTurn)
            {
                case "Medusa":
                    MedusaSkills1();
                    break;
                case "Griffin":
                    GriffinSkills1();
                    break;
                case "Harpie":
                    HarpieSkills1();
                    break;
                case "Cyclops":
                    CyclopsSkills1();
                    break;
                case "Prodo":
                    ProdoSkills1();
                    break;
                case "Faneia":
                    FaneiaSkills1();
                    break;
                case "Avatar":
                    AvatarSkills1();
                    break;
            }
        }
    }
    public void attackMutant2Skills(ClickEvent evt)
    {
        if (isSkilling)
        {
            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            if (combatUi.mutantMember2.name == "Griffin")
            {
                switchCounter = 1;

            }
            else if (combatUi.mutantMember2.name == "Gorgon")
            {
                switchCounter = 2;

            }
            else if (combatUi.mutantMember2.name == "Harpy")
            {
                switchCounter = 3;

            }
            else if (combatUi.mutantMember2.name == "Cyclops")
            {
                switchCounter = 4;

            }
            switch (TurnSystem.whoTurn)
            {
                case "Medusa":
                    MedusaSkills2();
                    break;
                case "Griffin":
                    GriffinSkills2();
                    break;
                case "Harpie":
                    HarpieSkills2();
                    break;
                case "Cyclops":
                    CyclopsSkills2();
                    break;
                case "Prodo":
                    ProdoSkills2();
                    break;
                case "Faneia":
                    FaneiaSkills2();
                    break;
                case "Avatar":
                    AvatarSkills2();
                    break;
            }
        }
    }
    public void attackMutant3Skills(ClickEvent evt)
    {
        if (isSkilling)
        {
            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            if (combatUi.mutantMember3.name == "Griffin")
            {
                switchCounter = 1;

            }
            else if (combatUi.mutantMember3.name == "Gorgon")
            {
                switchCounter = 2;

            }
            else if (combatUi.mutantMember3.name == "Harpy")
            {
                switchCounter = 3;

            }
            else if (combatUi.mutantMember3.name == "Cyclops")
            {
                switchCounter = 4;

            }
            switch (TurnSystem.whoTurn)
            {
                case "Medusa":
                    MedusaSkills3();
                    break;
                case "Griffin":
                    GriffinSkills3();
                    break;
                case "Harpie":
                    HarpieSkills3();
                    break;
                case "Cyclops":
                    CyclopsSkills3();
                    break;
                case "Prodo":
                    ProdoSkills3();
                    break;
                case "Faneia":
                    FaneiaSkills3();
                    break;
                case "Avatar":
                    AvatarSkills3();
                    break;
            }
        }
    }

    private void MedusaSkills1()
    {
        if(isUseSkill1)
        {
            Medusa.IsPoisoned = true;
        }

        else if(isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if(isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if(isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void GriffinSkills1()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void HarpieSkills1()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void CyclopsSkills1()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void ProdoSkills1()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void FaneiaSkills1()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void AvatarSkills1()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void MedusaSkills2()
    {
        if(isUseSkill1)
        {
            Medusa.IsPoisoned = true;
        }

        else if(isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if(isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if(isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void GriffinSkills2()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void HarpieSkills2()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void CyclopsSkills2()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void ProdoSkills2()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void FaneiaSkills2()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void AvatarSkills2()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy2.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy2.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy2.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy2.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy2.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void MedusaSkills3()
    {
        if(isUseSkill1)
        {
            Medusa.IsPoisoned = true;
        }

        else if(isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if(isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if(isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Medusa.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Medusa.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void GriffinSkills3()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Griffin.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void HarpieSkills3()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Harpie.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Harpie.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void CyclopsSkills3()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Cyclops.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Cyclops.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void ProdoSkills3()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Prodo.Strength - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Prodo.Strength - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void FaneiaSkills3()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Faneia.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Faneia.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }
    private void AvatarSkills3()
    {
        if (isUseSkill1)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }

        else if (isUseSkill2)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill3)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
        else if (isUseSkill4)
        {
            switch (switchCounter)
            {
                case 1:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy3.GetComponent<GriffinAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<GriffinAI>().Defenive);
                    break;
                case 2:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy3.GetComponent<GorgonAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<GorgonAI>().Defenive);
                    break;
                case 3:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy3.GetComponent<HarpieAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<HarpieAI>().Defenive);
                    break;
                case 4:
                    if (Avatar.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy3.GetComponent<CyclopsAI>().Health -= (Avatar.Strengh - mutantEnemy3.GetComponent<CyclopsAI>().Defenive);
                    break;
            }
        }
    }

    public IEnumerator WaitAttackP1()
    {
        switch (TurnSystem.whoTurn)
        {
            case "Medusa":
                yield return new WaitForSeconds(1.0f);
                break;
            case "Griffin":
                yield return new WaitForSeconds(1.0f);
                break;
            case "Harpie":
                yield return new WaitForSeconds(1.0f);
                break;
            case "Cyclops":
                yield return new WaitForSeconds(1.0f);
                break;
            case "Prodo":
                yield return new WaitForSeconds(1.0f);
                break;
            case "Faneia":
                yield return new WaitForSeconds(1.0f);
                break;
            case "Avatar":
                yield return new WaitForSeconds(1.0f);
                break;
        }
        isSkilling = false;
        ES.death();

        if (combatUi.heroMember2.name != "" && TS.Player1 == true)
        {
            TS.Player1 = false;
            TS.Player2 = true;
            GameObject.Find("CombatCodes").GetComponent<TeamSpawn>().DisplayTM2Info();
        }
        else if (combatUi.heroMember3.name != "" && (TS.Player1 == true || TS.Player2 == true))
        {
            TS.Player1 = false;
            TS.Player2 = false;
            TS.Player3 = true;
            GameObject.Find("CombatCodes").GetComponent<TeamSpawn>().DisplayTM3Info();

        }
        else
        {
            TS.Player1 = false;
            TS.Player2 = false;
            TS.Player3 = false;
            EnemyTurn = GameObject.Find("CombatCodes").GetComponent<EnemySystem>().EnemyAttacking();
            StartCoroutine(EnemyTurn);
        }
        combatUi.mutantSelectHolder.style.display = DisplayStyle.None;
        combatUi.attackCommands.style.display = DisplayStyle.Flex;
        combatUi.attack.style.display = DisplayStyle.Flex;
        combatUi.skills.style.display = DisplayStyle.Flex;
        combatUi.defend.style.display = DisplayStyle.Flex;
        combatUi.heal.style.display = DisplayStyle.Flex;
        combatUi.heroInfo.style.display = DisplayStyle.Flex;
        combatUi.moveInfo.style.display = DisplayStyle.Flex;

        combatUi.heroInfo.style.opacity = 100;
    }
}
