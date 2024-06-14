using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class EnemySystem : MonoBehaviour
{
    public static bool Enemy1Turn;
    public static bool Enemy2Turn;
    public static bool Enemy3Turn;

    public GameObject mutantEnemy1;
    public GameObject mutantEnemy2;
    public GameObject mutantEnemy3;

    public static string Mutant;

    public combatUiHolder combatUi;

    public void Start()
    {
        combatUi = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
    }
    public void Update()
    {
        healthDisplay();
    }
    public void healthDisplay()
    {
        switch(combatUi.mutantMember1.name)
        {
            case "Griffin":
                combatUi.mutant1.text = mutantEnemy1.GetComponent<GriffinAI>().Health + " / " + mutantEnemy1.GetComponent<GriffinAI>().MaxHealth;
                break;
            case "Gorgon":
                combatUi.mutant1.text = mutantEnemy1.GetComponent<GorgonAI>().Health + " / " + mutantEnemy1.GetComponent<GorgonAI>().MaxHealth;
                break;
            case "Harpy":
                combatUi.mutant1.text = mutantEnemy1.GetComponent<HarpieAI>().Health + " / " + mutantEnemy1.GetComponent<HarpieAI>().MaxHealth;
                break;
            case "Cyclops":
                combatUi.mutant1.text = mutantEnemy1.GetComponent<CyclopsAI>().Health + " / " + mutantEnemy1.GetComponent<CyclopsAI>().MaxHealth;
                break;
        }
        switch (combatUi.mutantMember2.name)
        {
            case "Griffin":
                combatUi.mutant2.text = mutantEnemy2.GetComponent<GriffinAI>().Health + " / " + mutantEnemy2.GetComponent<GriffinAI>().MaxHealth;
                break;
            case "Gorgon":
                combatUi.mutant2.text = mutantEnemy2.GetComponent<GorgonAI>().Health + " / " + mutantEnemy2.GetComponent<GorgonAI>().MaxHealth;
                break;
            case "Harpy":
                combatUi.mutant2.text = mutantEnemy2.GetComponent<HarpieAI>().Health + " / " + mutantEnemy2.GetComponent<HarpieAI>().MaxHealth;
                break;
            case "Cyclops":
                combatUi.mutant2.text = mutantEnemy2.GetComponent<CyclopsAI>().Health + " / " + mutantEnemy2.GetComponent<CyclopsAI>().MaxHealth;
                break;
        }
        switch (combatUi.mutantMember3.name)
        {
            case "Griffin":
                combatUi.mutant3.text = mutantEnemy3.GetComponent<GriffinAI>().Health + " / " + mutantEnemy3.GetComponent<GriffinAI>().MaxHealth;
                break;
            case "Gorgon":
                combatUi.mutant3.text = mutantEnemy3.GetComponent<GorgonAI>().Health + " / " + mutantEnemy3.GetComponent<GorgonAI>().MaxHealth;
                break;
            case "Harpy":
                combatUi.mutant3.text = mutantEnemy3.GetComponent<HarpieAI>().Health + " / " + mutantEnemy3.GetComponent<HarpieAI>().MaxHealth;
                break;
            case "Cyclops":
                combatUi.mutant3.text = mutantEnemy3.GetComponent<CyclopsAI>().Health + " / " + mutantEnemy3.GetComponent<CyclopsAI>().MaxHealth;
                break;
        }
    }

    public void death()
    {
        switch(combatUi.mutantMember1.name)
        {
            case "Griffin":
                if(mutantEnemy1.GetComponent<GriffinAI>().Health <=0)
                {
                    combatUi.mutantMember1.style.backgroundImage = new StyleBackground();
                    mutantEnemy1.GetComponent<GriffinAI>().enabled = false;
                    WaveSystem.ED1 = true;
                }
                break;
            case "Gorgon":
                if(mutantEnemy1.GetComponent<GorgonAI>().Health <=0)
                {
                    combatUi.mutantMember1.style.backgroundImage = new StyleBackground();
                    mutantEnemy1.GetComponent<GorgonAI>().enabled = false;
                    WaveSystem.ED1 = true;
                }
                break;
            case "Harpy":
                if (mutantEnemy1.GetComponent<HarpieAI>().Health <= 0)
                {
                    combatUi.mutantMember1.style.backgroundImage = new StyleBackground();
                    mutantEnemy1.GetComponent<HarpieAI>().enabled = false;
                    WaveSystem.ED1 = true;
                }
                break;
            case "Cyclops":
                if (mutantEnemy1.GetComponent<CyclopsAI>().Health <= 0)
                {
                    combatUi.mutantMember1.style.backgroundImage = new StyleBackground();
                    mutantEnemy1.GetComponent<CyclopsAI>().enabled = false;
                    WaveSystem.ED1 = true;
                }
                break;

        }
        switch (combatUi.mutantMember2.name)
        {
            case "Griffin":
                if (mutantEnemy2.GetComponent<GriffinAI>().Health <= 0)
                {
                    combatUi.mutantMember2.style.backgroundImage = new StyleBackground();
                    mutantEnemy2.GetComponent<GriffinAI>().enabled = false;
                    WaveSystem.ED2 = true;
                }
                break;
            case "Gorgon":
                if (mutantEnemy2.GetComponent<GorgonAI>().Health <= 0)
                {
                    combatUi.mutantMember2.style.backgroundImage = new StyleBackground();
                    mutantEnemy2.GetComponent<GorgonAI>().enabled = false;
                    WaveSystem.ED2 = true;
                }
                break;
            case "Harpy":
                if (mutantEnemy2.GetComponent<HarpieAI>().Health <= 0)
                {
                    combatUi.mutantMember2.style.backgroundImage = new StyleBackground();
                    mutantEnemy2.GetComponent<HarpieAI>().enabled = false;
                    WaveSystem.ED2 = true;
                }
                break;
            case "Cyclops":
                if (mutantEnemy2.GetComponent<CyclopsAI>().Health <= 0)
                {
                    combatUi.mutantMember2.style.backgroundImage = new StyleBackground();
                    mutantEnemy2.GetComponent<CyclopsAI>().enabled = false;
                    WaveSystem.ED2 = true;
                }
                break;
        }
        switch (combatUi.mutantMember3.name)
        {
            case "Griffin":
                if (mutantEnemy3.GetComponent<GriffinAI>().Health <= 0)
                {
                    combatUi.mutantMember3.style.backgroundImage = new StyleBackground();
                    mutantEnemy3.GetComponent<GriffinAI>().enabled = false;
                    WaveSystem.ED3 = true;
                }
                break;
            case "Gorgon":
                if (mutantEnemy3.GetComponent<GorgonAI>().Health <= 0)
                {
                    combatUi.mutantMember3.style.backgroundImage = new StyleBackground();
                    mutantEnemy3.GetComponent<GorgonAI>().enabled = false;
                    WaveSystem.ED3 = true;
                }
                break;
            case "Harpy":
                if (mutantEnemy3.GetComponent<HarpieAI>().Health <= 0)
                {
                    combatUi.mutantMember3.style.backgroundImage = new StyleBackground();
                    mutantEnemy3.GetComponent<HarpieAI>().enabled = false;
                    WaveSystem.ED3 = true;
                }
                break;
            case "Cyclops":
                if (mutantEnemy3.GetComponent<CyclopsAI>().Health <= 0)
                {
                    combatUi.mutantMember3.style.backgroundImage = new StyleBackground();
                    mutantEnemy3.GetComponent<CyclopsAI>().enabled = false;
                    WaveSystem.ED3 = true;
                }
                break;
        }
    }
   
    
    public void Enemy1Attack()
    {
        switch (combatUi.mutantMember1.name)
        {
            case "Griffin":
                mutantEnemy1.GetComponent<GriffinAI>().Attacked();
                mutantEnemy1.GetComponent<GriffinAI>().hasAttacked = false;
                Enemy1Turn = false;
                break;
            case "Gorgon":
                mutantEnemy1.GetComponent<GorgonAI>().Attacked();
                mutantEnemy1.GetComponent<GorgonAI>().hasAttacked = false;
                Enemy1Turn = false;
                break;
            case "Harpy":
                mutantEnemy1.GetComponent<HarpieAI>().Attacked();
                mutantEnemy1.GetComponent<HarpieAI>().hasAttacked = false;
                Enemy1Turn = false;
                break;
            case "Cyclops":
               mutantEnemy1.GetComponent<CyclopsAI>().Attacked();
               mutantEnemy1.GetComponent<CyclopsAI>().hasAttacked = false;
                Enemy1Turn = false;
                break;

        }
    }
    public void Enemy2Attack()
    {
        
        switch (combatUi.mutantMember2.name)
        {
            case "Griffin":
               mutantEnemy2.GetComponent<GriffinAI>().Attacked();
               mutantEnemy2.GetComponent<GriffinAI>().hasAttacked = false;
                Enemy2Turn = false;
                break;
            case "Gorgon":
               mutantEnemy2.GetComponent<GorgonAI>().Attacked();
               mutantEnemy2.GetComponent<GorgonAI>().hasAttacked = false;
                Enemy2Turn = false;
                break;
            case "Harpy":
               mutantEnemy2.GetComponent<HarpieAI>().Attacked();
               mutantEnemy2.GetComponent<HarpieAI>().hasAttacked = false;
                Enemy2Turn = false;
                break;
            case "Cyclops":
               mutantEnemy2.GetComponent<CyclopsAI>().Attacked();
               mutantEnemy2.GetComponent<CyclopsAI>().hasAttacked = false;
                Enemy2Turn = false;
                break;

        }
    }
    public void Enemy3Attack()
    {
        switch (combatUi.mutantMember3.name)
        {
            case "Griffin":
               mutantEnemy3.GetComponent<GriffinAI>().Attacked();
               mutantEnemy3.GetComponent<GriffinAI>().hasAttacked = false;
                Enemy3Turn = false;
                break;
            case "Gorgon":
               mutantEnemy3.GetComponent<GorgonAI>().Attacked();
               mutantEnemy3.GetComponent<GorgonAI>().hasAttacked = false;
                Enemy3Turn = false;
                break;
            case "Harpy":
               mutantEnemy3.GetComponent<HarpieAI>().Attacked();
               mutantEnemy3.GetComponent<HarpieAI>().hasAttacked = false;
                Enemy3Turn = false;
                break;
            case "Cyclops":
               mutantEnemy3.GetComponent<CyclopsAI>().Attacked();
               mutantEnemy3.GetComponent<CyclopsAI>().hasAttacked = false;
                Enemy3Turn = false;
                break;

        }
    }
    

    public IEnumerator EnemyAttacking()
    {
        if(Enemy1Turn && !WaveSystem.ED1)
        {

            Enemy1Attack();
            yield return new WaitForSeconds(3.0f);
            KillPlayer1();
            KillPlayer2();
            KillPlayer3();
            if (!WaveSystem.ED2)
            {
                Enemy2Turn = true;
            }
            else if (!WaveSystem.ED3)
            {
                Enemy3Turn = true;
            }
            Enemy1Turn = false;
        }
        else
        {
            if (!WaveSystem.ED2)
            {
                Enemy2Turn = true;
            }
            else if(!WaveSystem.ED3)
            {
                Enemy3Turn = true;
            }
            
        }
        if(Enemy2Turn && !WaveSystem.ED2)
        {
            Debug.Log(Enemy2Turn);
            Enemy2Attack();
            yield return new WaitForSeconds(3.0f);
            KillPlayer1();
            KillPlayer2();
            KillPlayer3();
            if (!WaveSystem.ED3)
            {
                Enemy3Turn = true;
            }
            Enemy2Turn = false;

        }
        else
        {
            if(!WaveSystem.ED3)
            {
                Enemy3Turn = true;
            }
            
        }
        if(Enemy3Turn && !WaveSystem.ED3)
        {
            Debug.Log(Enemy3Turn);
            Enemy3Attack();
            yield return new WaitForSeconds(3.0f);
            KillPlayer1();
            KillPlayer2();
            KillPlayer3();
            WhoTurn();
            ResetStats();
            Enemy3Turn = false;
        }

        else
        {
            WhoTurn();
            ResetStats();
        }
        
    }
    public void KillPlayer1()
    {
        switch (combatUi.heroMember1.name)
        {
            case "Medusa":
                if (Medusa.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player1 = false;
                    combatUi.heroMember1.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember1.name = "";
                }
                
                break;
            case "Griffin":
                if (Griffin.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player1 = false;
                    combatUi.heroMember1.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember1.name = "";
                }
                
                break;
            case "Cyclops":
                if (Cyclops.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player1 = false;
                    combatUi.heroMember1.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember1.name = "";
                }
                
                break;
            case "Harpie":
                if (Harpie.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player1 = false;
                    combatUi.heroMember1.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember1.name = "";
                }
                
                break;
            case "Prodo":
                if (Prodo.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player1 = false;
                    combatUi.heroMember1.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember1.name = "";
                }
                
                break;
        }
    }
    public void KillPlayer2()
    {
        switch (combatUi.heroMember2.name)
        {
            case "Griffin":
                if (Griffin.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player2 = false;
                    combatUi.heroMember2.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember2.name = "";
                }

                break;
            case "Cyclops":
                if (Cyclops.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player2 = false;
                    combatUi.heroMember2.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember2.name = "";
                }

                break;
            case "Harpie":
                if (Harpie.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player2 = false;
                    combatUi.heroMember2.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember2.name = "";
                }

                break;
            case "Prodo":
                if (Prodo.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player2 = false;
                    combatUi.heroMember2.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember2.name = "";
                }

                break;
            case "Faneia":
                if (Faneia.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player2 = false;
                    combatUi.heroMember2.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember2.name = "";
                }

                break;
        }
    }
    public void KillPlayer3()
    {
        switch (combatUi.heroMember3.name)
        {
            case "Cyclops":
                if (Cyclops.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player3 = false;
                    combatUi.heroMember3.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember3.name = "";
                }

                break;
            case "Harpie":
                if (Harpie.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player3 = false;
                    combatUi.heroMember3.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember3.name = "";
                }

                break;
            case "Prodo":
                if (Prodo.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player3 = false;
                    combatUi.heroMember3.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember3.name = "";
                }

                break;
            case "Faneia":
                if (Faneia.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player3 = false;
                    combatUi.heroMember3.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember3.name = "";
                }
                break;
            case "Avatar":
                if(Avatar.Health <= 0)
                {
                    GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player3 = false;
                    combatUi.heroMember3.style.backgroundImage = new StyleBackground();
                    combatUi.heroMember3.name = "";
                }
                break;
        }
    }

    public void WhoTurn()
    {
        if (!this.GetComponent<TurnSystem>().Player1 && combatUi.heroMember1.name != "")
        {
            GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player1 = true;
            GameObject.Find("CombatCodes").GetComponent<TeamSpawn>().DisplayTM1Info();
        }
        else if (!this.GetComponent<TurnSystem>().Player2 && combatUi.heroMember2.name != "")
        {
            GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player2 = true;
            GameObject.Find("CombatCodes").GetComponent<TeamSpawn>().DisplayTM2Info();
        }
        else if (!this.GetComponent<TurnSystem>().Player3 && combatUi.heroMember3.name != "")
        {
            GameObject.Find("CombatCodes").GetComponent<TurnSystem>().Player3 = true;
            GameObject.Find("CombatCodes").GetComponent<TeamSpawn>().DisplayTM3Info();
        }

        else
        {
            Resluts.TP.allowSceneActivation = true;
        }
        Debug.Log("WhoTurnRan");
    }

    public void ResetStats()
    {
        Medusa.IsPoisoned = false;
        if (Medusa.isDefending) Medusa.Defense -= 4;
        Medusa.isDefending = false;
        if (Griffin.isDefending) Griffin.Defense -= 4;
        Griffin.isDefending = false;
        if (Harpie.isDefending) Harpie.Defense -= 4;
        Harpie.isDefending = false;
        if (Cyclops.isDefending) Cyclops.Defense -=4;
        Cyclops.isDefending = false;
        if (Prodo.isDefending) Prodo.Defense -= 4;
        Prodo.isDefending = false;
        if (Faneia.isDefending) Faneia.Defense -= 4;
        Faneia.isDefending = false;
    }
}
