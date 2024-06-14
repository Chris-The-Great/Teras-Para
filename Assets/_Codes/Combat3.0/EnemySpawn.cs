using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class EnemySpawn : MonoBehaviour
{
    public GameObject mutantEnemy1;
    public GameObject mutantEnemy2;
    public GameObject mutantEnemy3;


    public int RandomPick;
    public GameObject Enemy;

    public combatUiHolder combatUi;
    public spriteHolder spriteHolder;
    
    
    private void Start()
    {
        combatUi = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
        spriteHolder = GameObject.Find("UIDocument").GetComponent<spriteHolder>();
        S1();
        S2();
        S3();
        //Enemy.SetActive(false);
    }

    public void S1()
    {

        RandomPick = Random.Range(1, 5);
        switch (RandomPick)
        {
            case 1:
                combatUi.mutantMember1.name = "Griffin";
                mutantEnemy1.GetComponent<GriffinAI>().enabled = true;
                mutantEnemy1.GetComponent<GriffinAI>().Health = mutantEnemy1.GetComponent<GriffinAI>().MaxHealth;
                combatUi.mutantMember1.style.backgroundImage = new StyleBackground(spriteHolder.griffinMutant);
                combatUi.mutant1.style.backgroundImage = new StyleBackground(spriteHolder.girffinMutantHealthBar);
                break;
            case 2:
                combatUi.mutantMember1.name = "Gorgon";
                mutantEnemy1.GetComponent<GorgonAI>().enabled = true;
                mutantEnemy1.GetComponent<GorgonAI>().Health = mutantEnemy1.GetComponent<GorgonAI>().MaxHealth;
                combatUi.mutantMember1.style.backgroundImage = new StyleBackground(spriteHolder.gorgonMutant);
                combatUi.mutant1.style.backgroundImage = new StyleBackground(spriteHolder.gorgonMutantHealthBar);
                break;
            case 3:
                combatUi.mutantMember1.name = "Harpy";
                mutantEnemy1.GetComponent<HarpieAI>().enabled = true;
                mutantEnemy1.GetComponent<HarpieAI>().Health = mutantEnemy1.GetComponent<HarpieAI>().MaxHealth;
                combatUi.mutantMember1.style.backgroundImage = new StyleBackground(spriteHolder.harpyMutant);
                combatUi.mutant1.style.backgroundImage = new StyleBackground(spriteHolder.harpyMutantHealthBar);
                break;
            case 4:
                combatUi.mutantMember1.name = "Cyclops";
                mutantEnemy1.GetComponent<CyclopsAI>().enabled = true;
                mutantEnemy1.GetComponent<CyclopsAI>().Health = mutantEnemy1.GetComponent<CyclopsAI>().MaxHealth;
                combatUi.mutantMember1.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsMutant);
                combatUi.mutant1.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsMutantHealthBar);
                break;
        }
    }
    public void S2()
    {
        RandomPick = Random.Range(1, 5);
        switch (RandomPick)
        {

            case 1:
                combatUi.mutantMember2.name = "Griffin";
                mutantEnemy2.GetComponent<GriffinAI>().enabled = true;
                mutantEnemy2.GetComponent<GriffinAI>().Health = mutantEnemy2.GetComponent<GriffinAI>().MaxHealth;
                combatUi.mutantMember2.style.backgroundImage = new StyleBackground(spriteHolder.griffinMutant);
                combatUi.mutant2.style.backgroundImage = new StyleBackground(spriteHolder.girffinMutantHealthBar);
                break;
            case 2:
                combatUi.mutantMember2.name = "Gorgon";
                mutantEnemy2.GetComponent<GorgonAI>().enabled = true;
                mutantEnemy2.GetComponent<GorgonAI>().Health = mutantEnemy2.GetComponent<GorgonAI>().MaxHealth;
                combatUi.mutantMember2.style.backgroundImage = new StyleBackground(spriteHolder.gorgonMutant);
                combatUi.mutant2.style.backgroundImage = new StyleBackground(spriteHolder.gorgonMutantHealthBar);
                break;
            case 3:
                combatUi.mutantMember2.name = "Harpy";
                mutantEnemy2.GetComponent<HarpieAI>().enabled = true;
                mutantEnemy2.GetComponent<HarpieAI>().Health = mutantEnemy2.GetComponent<HarpieAI>().MaxHealth;
                combatUi.mutantMember2.style.backgroundImage = new StyleBackground(spriteHolder.harpyMutant);
                combatUi.mutant2.style.backgroundImage = new StyleBackground(spriteHolder.harpyMutantHealthBar);
                break;
            case 4:
                combatUi.mutantMember2.name = "Cyclops";
                mutantEnemy2.GetComponent<CyclopsAI>().enabled = true;
                mutantEnemy2.GetComponent<CyclopsAI>().Health = mutantEnemy2.GetComponent<CyclopsAI>().MaxHealth;
                combatUi.mutantMember2.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsMutant);
                combatUi.mutant2.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsMutantHealthBar);
                break;
        }
    }
    public void S3()
    {
        RandomPick = Random.Range(1, 5);
        switch (RandomPick)
        {

            case 1:
                combatUi.mutantMember3.name = "Griffin";
                mutantEnemy3.GetComponent<GriffinAI>().enabled = true;
                mutantEnemy3.GetComponent<GriffinAI>().Health = mutantEnemy3.GetComponent<GriffinAI>().MaxHealth;
                combatUi.mutantMember3.style.backgroundImage = new StyleBackground(spriteHolder.griffinMutant);
                combatUi.mutant3.style.backgroundImage = new StyleBackground(spriteHolder.girffinMutantHealthBar);
                break;
            case 2:
                combatUi.mutantMember3.name = "Gorgon";
                mutantEnemy3.GetComponent<GorgonAI>().enabled = true;
                mutantEnemy3.GetComponent<GorgonAI>().Health = mutantEnemy3.GetComponent<GorgonAI>().MaxHealth;
                combatUi.mutantMember3.style.backgroundImage = new StyleBackground(spriteHolder.gorgonMutant);
                combatUi.mutant3.style.backgroundImage = new StyleBackground(spriteHolder.gorgonMutantHealthBar);
                break;
            case 3:
                combatUi.mutantMember3.name = "Harpy";
                mutantEnemy3.GetComponent<HarpieAI>().enabled = true;
                mutantEnemy3.GetComponent<HarpieAI>().Health = mutantEnemy3.GetComponent<HarpieAI>().MaxHealth;
                combatUi.mutantMember3.style.backgroundImage = new StyleBackground(spriteHolder.harpyMutant);
                combatUi.mutant3.style.backgroundImage = new StyleBackground(spriteHolder.harpyMutantHealthBar);
                break;
            case 4:
                combatUi.mutantMember3.name = "Cyclops";
                mutantEnemy3.GetComponent<CyclopsAI>().enabled = true;
                mutantEnemy3.GetComponent<CyclopsAI>().Health = mutantEnemy3.GetComponent<CyclopsAI>().MaxHealth;
                combatUi.mutantMember3.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsMutant);
                combatUi.mutant3.style.backgroundImage = new StyleBackground(spriteHolder.cyclopsMutantHealthBar);
                break;
        }
    }

}
