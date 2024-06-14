using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealSystems : MonoBehaviour
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
        combatUi.heal.RegisterCallback<ClickEvent>(Healing);

    }

    void Healing(ClickEvent evt)
    {
        ChangeTurn = WaitAttackP1();
        StartCoroutine(ChangeTurn);
        switch (TurnSystem.whoTurn)
        {
            case "Medusa":
                Medusa.Health += Medusa.HealRate;
                if(Medusa.Health> Medusa.MaxHealth)
                {
                    Medusa.Health = Medusa.MaxHealth;
                }
            break;
            case "Griffin":
                Griffin.Health += Griffin.HealRate;
                if(Griffin.Health> Griffin.MaxHealth)
                {
                    Griffin.Health = Griffin.MaxHealth;
                }
            break;
            case "Harpie":
                Harpie.Health += Harpie.HealRate;
                if(Harpie.Health> Harpie.MaxHealth)
                {
                    Harpie.Health = Harpie.MaxHealth;
                }
            break;
            case "Cyclops":
                Cyclops.Health += Cyclops.HealRate;
                if(Cyclops.Health> Cyclops.MaxHealth)
                {
                    Cyclops.Health = Cyclops.MaxHealth;
                }
            break;
            case "Prodo":
                Prodo.Health += Prodo.HealRate;
                if(Prodo.Health> Prodo.MaxHealth)
                {
                    Prodo.Health = Prodo.MaxHealth;
                }
            break;
            case "Faneia":
                Faneia.Health += Faneia.HealRate;
                if(Faneia.Health> Faneia.MaxHealth)
                {
                    Faneia.Health = Faneia.MaxHealth;
                }
            break;
            case "Avatar":
                Avatar.Health += Avatar.HealRate;
                if(Avatar.Health> Avatar.MaxHealth)
                {
                    Avatar.Health = Avatar.MaxHealth;
                }
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
