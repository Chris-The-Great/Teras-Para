using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class AttackSystem : MonoBehaviour
{

    IEnumerator ChangeTurn;
    IEnumerator EnemyTurn;

    public int switchCounter;

    public GameObject mutantEnemy1;
    public GameObject mutantEnemy2;
    public GameObject mutantEnemy3;

    static bool isAttacking;

    public combatUiHolder combatUi;
    public EnemySystem ES;
    public TurnSystem TS;



    private void Start()
    {
        combatUi = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
        ES = GameObject.Find("CombatCodes").GetComponent<EnemySystem>();
        TS = GameObject.Find("CombatCodes").GetComponent<TurnSystem>();

        combatUi.mutantSelectHolder.style.display = DisplayStyle.None;
        combatUi.attack.RegisterCallback<ClickEvent>(SelectEnemy);
        combatUi.mutant1.RegisterCallback<ClickEvent>(AttackingEnemy1);
        combatUi.mutant2.RegisterCallback<ClickEvent>(AttackingEnemy2);
        combatUi.mutant3.RegisterCallback<ClickEvent>(AttackingEnemy3);

        combatUi.attack.RegisterCallback<MouseEnterEvent>(ShowAttackInfo);
    }
    public void ShowAttackInfo(MouseEnterEvent evt)
    {
        switch (TurnSystem.whoTurn)
        {
            case "Medusa":
                combatUi.moveName.text = "Snake Shot";
                combatUi.moveDes.text = "Medusa shoot snakes from her hair";
                break;
            case "Griffin":
                combatUi.moveName.text = "Griffin Bite";
                combatUi.moveDes.text = "Griffin bites an single enemy";
                break;
            case "Harpie":
                combatUi.moveName.text = "Harpie Feather Shot";
                combatUi.moveDes.text = "Haprie flaps her wings and shoot a feather at an single enemy";
                break;
            case "Cyclops":
                combatUi.moveName.text = "Cyclops Slam";
                combatUi.moveDes.text = "Cyclops Slam his hands down on a single enemy";
                break;
            case "Prodo":
                combatUi.moveName.text = "Sword Slash";
                combatUi.moveDes.text = "Prodo slash his sword at a single enemy";
                break;
            case "Faneia":
                combatUi.moveName.text = "Rapier Stab";
                combatUi.moveDes.text = "Faneia Stabs an single enemy";
                break;
            case "Avatar":
                combatUi.moveName.text = "Avatar Basic Attack";
                combatUi.moveDes.text = "Avatar Basic Attack Info";
                break;
        }
    }
    public void SelectEnemy(ClickEvent evt)
    {
        combatUi.mutantSelectHolder.style.display = DisplayStyle.Flex;
        combatUi.attackCommands.style.display = DisplayStyle.None;
        combatUi.heroInfo.style.display = DisplayStyle.None;
        combatUi.moveInfo.style.display = DisplayStyle.None;
        isAttacking = true;
    }

    

    public void AttackingEnemy1(ClickEvent evt)
    {
        if (isAttacking)
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
                    break;
                case "Griffin":
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
                    break;
                case "Harpie":
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
                    break;
                case "Cyclops":
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
                    break;
                case "Prodo":
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
                    break;
                case "Faneia":
                    switch (switchCounter)
                    {
                        case 1:
                            if (Faneia.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive > 0) mutantEnemy1.GetComponent<GriffinAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GriffinAI>().Defenive);
                            break;
                        case 2:
                            if (Faneia.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive > 0) mutantEnemy1.GetComponent<GorgonAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<GorgonAI>().Defenive);
                            break;
                        case 3:
                            if (Faneia.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive > 0) mutantEnemy1.GetComponent<HarpieAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<HarpieAI>().Defenive);
                            break;
                        case 4:
                            if (Faneia.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive > 0) mutantEnemy1.GetComponent<CyclopsAI>().Health -= (Griffin.Strengh - mutantEnemy1.GetComponent<CyclopsAI>().Defenive);
                            break;
                    }
                    break;
                case "Avatar":
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
                    break;
            }
        }
    }
    public void AttackingEnemy2(ClickEvent evt)
    {
        if (isAttacking)
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
                    break;
                case "Griffin":
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
                    break;
                case "Harpie":
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
                    break;
                case "Cyclops":
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
                    break;
                case "Prodo":
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
                    break;
                case "Faneia":
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
                    break;
                case "Avatar":
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
                    break;
            }
        }
    }
    public void AttackingEnemy3(ClickEvent evt)
    {
        if (isAttacking)
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
                    break;
                case "Griffin":
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
                    break;
                case "Harpie":
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
                    break;
                case "Cyclops":
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
                    break;
                case "Prodo":
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
                    break;
                case "Faneia":
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
                    break;
                case "Avatar":
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
                    break;
            }
        }
    }

    public IEnumerator WaitAttackP1()
    {
        switch(TurnSystem.whoTurn)
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
        isAttacking = false;
        ES.death();

        if(combatUi.heroMember2.name != "" && TS.Player1 == true)
        {
            TS.Player1 = false;
            TS.Player2 = true;
            GameObject.Find("CombatCodes").GetComponent<TeamSpawn>().DisplayTM2Info();
        }
        else if(combatUi.heroMember3.name != "" && (TS.Player1== true || TS.Player2== true)) 
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
            Debug.Log("Switch to Enemy Turn");
            EnemySystem.Enemy1Turn = true;
            EnemyTurn = GameObject.Find("CombatCodes").GetComponent<EnemySystem>().EnemyAttacking();
            StartCoroutine(EnemyTurn);
        }
        combatUi.mutantSelectHolder.style.display = DisplayStyle.None;
        combatUi.attackCommands.style.display = DisplayStyle.Flex;
        combatUi.heroInfo.style.display = DisplayStyle.Flex;
        combatUi.moveInfo.style.display = DisplayStyle.Flex;
    }
}
