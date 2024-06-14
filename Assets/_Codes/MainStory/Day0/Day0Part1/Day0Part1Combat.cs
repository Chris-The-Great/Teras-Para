using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Day0Part1Combat : MonoBehaviour
{
    IEnumerator ChangeTurn;
    IEnumerator EnemyTurn;

    public int switchCounter;

    public GameObject canvas;

    public GameObject Griffin1;
    public GameObject Griffin2;
    public GameObject Griffin3;

    public Day0CombatUIHolder combatUIHolder;

    static bool isAttacking;
    static bool isSkilling;
    static bool isUseSkill1;
    static bool isUseSkill2;
    static bool isUseSkill3;
    static bool isUseSkill4;
    static bool isHealing;
    static bool isDefending;

    private void Start()
    {
        combatUIHolder = GameObject.Find("UIDocument").GetComponent<Day0CombatUIHolder>();
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.None;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.attack.RegisterCallback<ClickEvent>(SelectEnemy);
        combatUIHolder.skills.RegisterCallback<ClickEvent>(SelectSkill);
        combatUIHolder.mutant1.RegisterCallback<ClickEvent>(AttackingEnemy1);
        combatUIHolder.mutant2.RegisterCallback<ClickEvent>(AttackingEnemy2);
        combatUIHolder.mutant3.RegisterCallback<ClickEvent>(AttackingEnemy3);
    }
    public void SelectEnemy(ClickEvent evt)
    {
        isAttacking = true;
        Debug.Log(isAttacking);
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.Flex;
        combatUIHolder.attackCommands.style.display = DisplayStyle.None;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.heroInfo.style.display = DisplayStyle.None;
        combatUIHolder.moveInfo.style.display = DisplayStyle.None;
    }

    public void SelectSkill(ClickEvent evt)
    {
        combatUIHolder.skillsHolder.style.display = DisplayStyle.Flex;
        combatUIHolder.heroInfo.style.display = DisplayStyle.None;
    }

    public void SelectSkill1(ClickEvent evt)
    {
        isSkilling = true;
        isUseSkill1 = true;
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.Flex;
        combatUIHolder.attackCommands.style.display = DisplayStyle.None;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.heroInfo.style.display = DisplayStyle.None;
        combatUIHolder.moveInfo.style.display = DisplayStyle.None;
    }

    public void SelectSkill2(ClickEvent evt)
    {
        isSkilling = true;
        isUseSkill2 = true;
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.Flex;
        combatUIHolder.attackCommands.style.display = DisplayStyle.None;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.heroInfo.style.display = DisplayStyle.None;
        combatUIHolder.moveInfo.style.display = DisplayStyle.None;
    }

    public void SelectSkill3(ClickEvent evt)
    {
        isSkilling = true;
        isUseSkill3 = true;
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.Flex;
        combatUIHolder.attackCommands.style.display = DisplayStyle.None;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.heroInfo.style.display = DisplayStyle.None;
        combatUIHolder.moveInfo.style.display = DisplayStyle.None;
    }

    public void SelectSkill4(ClickEvent evt)
    {
        isSkilling = true;
        isUseSkill4 = true;
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.Flex;
        combatUIHolder.attackCommands.style.display = DisplayStyle.None;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.heroInfo.style.display = DisplayStyle.None;
        combatUIHolder.moveInfo.style.display = DisplayStyle.None;
    }

    public void AttackingEnemy1(ClickEvent evt)
    {
        if (this.GetComponent<Day0Part1TurnSystem>().Player1)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
        }
        else if (this.GetComponent<Day0Part1TurnSystem>().Player2)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
        }
        else if (this.GetComponent<Day0Part1TurnSystem>().Player3)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin1.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
        }
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.None;
        combatUIHolder.attackCommands.style.display = DisplayStyle.Flex;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.heroInfo.style.display = DisplayStyle.Flex;
        combatUIHolder.moveInfo.style.display = DisplayStyle.Flex;
    }
    public void AttackingEnemy2(ClickEvent evt)
    {
        if (this.GetComponent<Day0Part1TurnSystem>().Player1)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
        }
        else if (this.GetComponent<Day0Part1TurnSystem>().Player2)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
        }
        else if (this.GetComponent<Day0Part1TurnSystem>().Player3)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin2.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
        }
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.None;
        combatUIHolder.attackCommands.style.display = DisplayStyle.Flex;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.heroInfo.style.display = DisplayStyle.Flex;
        combatUIHolder.moveInfo.style.display = DisplayStyle.Flex;
    }
    public void AttackingEnemy3(ClickEvent evt)
    {
        if (this.GetComponent<Day0Part1TurnSystem>().Player1)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Prodo.Strength;
            }
        }
        else if (this.GetComponent<Day0Part1TurnSystem>().Player2)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Faneia.Strengh;
            }
        }
        else if (this.GetComponent<Day0Part1TurnSystem>().Player3)
        {
            if (isAttacking)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }

            else if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                Griffin3.GetComponent<Day0GriffinAI>().Health -= Avatar.Strengh;
            }
        }
        combatUIHolder.mutantSelectHolder.style.display = DisplayStyle.None;
        combatUIHolder.attackCommands.style.display = DisplayStyle.Flex;
        combatUIHolder.skillsHolder.style.display = DisplayStyle.None;
        combatUIHolder.heroInfo.style.display = DisplayStyle.Flex;
        combatUIHolder.moveInfo.style.display = DisplayStyle.Flex;
    }

    private void Update()
    {
        if(this.GetComponent<Day0Part1EnemySystem>().Enemy1D && this.GetComponent<Day0Part1EnemySystem>().Enemy2D && this.GetComponent<Day0Part1EnemySystem>().Enemy3D)
        {

            canvas.gameObject.SetActive(true);
            combatUIHolder.Root.style.display = DisplayStyle.None;
            GameObject.Find("Dia").GetComponent<Day0Dia>().NextLine();
            Destroy(this.gameObject);
        }
    }

    public IEnumerator WaitAttackP1()
    {
        if (this.GetComponent<Day0Part1TurnSystem>().Player1 == true)
        {
            if (isHealing == false && isDefending == false)
            {
                yield return null;
            }
            else
            {
                yield return null;
            }
            //Anim would run
            this.GetComponent<Day0Part1EnemySystem>().death();
            if (Faneia.Health > 0)
            {
                this.GetComponent<Day0Part1TurnSystem>().Player2 = true;
                this.GetComponent<Day0Part1TurnSystem>().DisplayFaneiaInfo();
            }
            else if (Avatar.Health > 0)
            {
                this.GetComponent<Day0Part1TurnSystem>().Player3 = true;
                this.GetComponent<Day0Part1TurnSystem>().DisplayAvatarInfo();
            }
            else
            {
                //EnemyTurn = this.GetComponent<Day0Part1TurnSystem>().EnemyAttacking();
                StartCoroutine(EnemyTurn);
            }
            this.GetComponent<Day0Part1TurnSystem>().Player1 = false;
            isAttacking = false;
        }
        else if (this.GetComponent<Day0Part1TurnSystem>().Player2 == true)
        {
            if (isHealing == false && isDefending == false)
            {
                yield return null;
            }
            else
            {
                yield return null;
            }
            //anime would run
            this.GetComponent<Day0Part1EnemySystem>().death();
            if (Avatar.Health > 0)
            {
                this.GetComponent<Day0Part1TurnSystem>().Player3 = true;
                this.GetComponent<Day0Part1TurnSystem>().DisplayAvatarInfo();
            }
            else
            {
                EnemyTurn = this.GetComponent<Day0Part1EnemySystem>().EnemyAttacking();
                StartCoroutine(EnemyTurn);
            }
            this.GetComponent<Day0Part1TurnSystem>().Player2 = false;
            isAttacking = false;
        }
        else if (this.GetComponent<Day0Part1TurnSystem>().Player3 == true)
        {
            if (isHealing == false && isDefending == false)
            {
                yield return null;
            }
            else
            {
                yield return null;
            }
            //anime would run
            this.GetComponent<Day0Part1EnemySystem>().death();
            this.GetComponent<Day0Part1TurnSystem>().Player3 = false;
            isAttacking = false;
            this.GetComponent<Day0Part1TurnSystem>().DisplayAvatarInfo();
            EnemyTurn = this.GetComponent<Day0Part1EnemySystem>().EnemyAttacking();
            StartCoroutine(EnemyTurn);
        }
    }
}
