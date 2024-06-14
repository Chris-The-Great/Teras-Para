using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements;

public class DefendSystems : MonoBehaviour
{
    IEnumerator ChangeTurn;
    IEnumerator EnemyTurn;

    public int switchCounter;

    //static bool isHealing;

    public combatUiHolder combatUi;
    public EnemySystem ES;
    public TurnSystem TS;

    private void Start()
    {
        combatUi = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
        ES = GameObject.Find("CombatCodes").GetComponent<EnemySystem>();
        TS = GameObject.Find("CombatCodes").GetComponent<TurnSystem>();

        combatUi.mutantSelectHolder.style.display = DisplayStyle.None;
        combatUi.defend.RegisterCallback<ClickEvent>(Defend);

    }

    void Defend(ClickEvent evt)
    {
        ChangeTurn = WaitAttackP1();
        StartCoroutine(ChangeTurn);
        switch (TurnSystem.whoTurn)
        {
            case "Medusa":
                Medusa.Defense += 4;
                Medusa.isDefending = true;
                break;
            case "Griffin":
                Griffin.Defense += 4;
                Griffin.isDefending = true;
                break;
            case "Harpie":
                Harpie.Defense += 4;
                Harpie.isDefending = true;
                break;
            case "Cyclops":
                Cyclops.Defense += 4;
                Cyclops.isDefending = true;
                break;
            case "Prodo":
                Prodo.Defense += 4;
                Prodo.isDefending = true;
                break;
            case "Faneia":
                Faneia.Defense += 4;
                Faneia.isDefending = true;
                break;
            case "Avatar":
                Avatar.Defense += 4;
                Avatar.isDefending = true;
                break;
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
