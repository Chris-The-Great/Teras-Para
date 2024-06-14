using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class Day0CombatCyclops : MonoBehaviour
{
    IEnumerator ChangeTurn;
    IEnumerator EnemyTurn;

    public int switchCounter;

    public GameObject CyclopsBoss;

    public GameObject canvas;

    public CyclopsUIHolder cyclopsUIHolder;

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
        cyclopsUIHolder = GameObject.Find("UIDocumentBoss").GetComponent<CyclopsUIHolder>();
        cyclopsUIHolder.skillsHolder.style.display = DisplayStyle.None;
        cyclopsUIHolder.attack.RegisterCallback<ClickEvent>(AttackingEnemy1);
        //cyclopsUIHolder.skills.RegisterCallback<ClickEvent>(SelectSkill);
    }

    private void Update()
    {
        if(GameObject.Find("CyclopsBoss").GetComponent<CyclopsBossAI>().Health <= 0)
        {
            canvas.gameObject.SetActive(true);
            cyclopsUIHolder.Root.style.display = DisplayStyle.None;
            GameObject.Find("Dia").GetComponent<Day0Dia>().NextLine();
            Destroy(this.gameObject);
        }
    }
    public void SelectSkill()
    {
        //DisplaySkillName();
    }

    public void SelectSkill1()
    {
        isSkilling = true;
        isUseSkill1 = true;
        Debug.Log(isUseSkill1);
    }

    public void SelectSkill2()
    {
        isSkilling = true;
        isUseSkill2 = true;
    }

    public void SelectSkill3()
    {
        isSkilling = true;
        isUseSkill3 = true;
    }

    public void SelectSkill4()
    {
        isSkilling = true;
        isUseSkill4 = true;
    }

    public void AttackingEnemy1(ClickEvent evt)
    {
        if (this.GetComponent<Day0TurnSystemCyclops>().Player1)
        {
            
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Griffin.Strengh;
            

            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Griffin.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Griffin.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Griffin.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Griffin.Strengh;
            }
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player2)
        {
           
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Faneia.Strengh;
            

            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Faneia.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Faneia.Strengh;
            }
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player3)
        {
            
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Avatar.Strengh;
            

            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Avatar.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                CyclopsBoss.GetComponent<CyclopsBossAI>().Health -= Avatar.Strengh;
            }
        }
    }
    public IEnumerator WaitAttackP1()
    {
        if (this.GetComponent<Day0TurnSystemCyclops>().Player1 == true)
        {
            if (isHealing == false && isDefending == false)
            {
                yield return null;
                //yield return new WaitForSeconds(this.GetComponent<AttackAnim>().MedusaAnim[1].length);
            }
            else
            {
                yield return null;
                //yield return new WaitForSeconds(this.GetComponent<AttackAnim>().MedusaAnim[1].length);
            }
           this.GetComponent<Day0TurnSystemCyclops>().PlayerDeath();
            if (Faneia.Health >= 0)
            {
                this.GetComponent<Day0TurnSystemCyclops>().Player2 = true;
                this.GetComponent<Day0TurnSystemCyclops>().DisplayFaneiaInfo();
            }
            else if (Avatar.Health >= 0)
            {
                this.GetComponent<Day0Part1TurnSystem>().Player3 = true;
                this.GetComponent<Day0TurnSystemCyclops>().DisplayAvatarInfo();
            }
            else
            {
                EnemyTurn = this.GetComponent<Day0EnemySystemCyclops>().EnemyAttacking();
                StartCoroutine(EnemyTurn);
            }
            this.GetComponent<Day0TurnSystemCyclops>().Player1 = false;
            isAttacking = false;
            this.GetComponent<Day0EnemySystemCyclops>().CyclopsBossDamage();
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player2 == true)
        {
            if (isHealing == false && isDefending == false)
            {
                yield return null;
                //yield return new WaitForSeconds(this.GetComponent<AttackAnim>().MedusaAnim[1].length);
            }
            else
            {
                yield return null;
                //yield return new WaitForSeconds(this.GetComponent<AttackAnim>().MedusaAnim[1].length);
            }
            if (Avatar.Health >= 0)
            {
                this.GetComponent<Day0TurnSystemCyclops>().Player3 = true;
                this.GetComponent<Day0TurnSystemCyclops>().DisplayAvatarInfo();
            }
            else
            {
                EnemyTurn = this.GetComponent<Day0EnemySystemCyclops>().EnemyAttacking();
                StartCoroutine(EnemyTurn);
            }
            this.GetComponent<Day0TurnSystemCyclops>().Player2 = false;
            isAttacking = false;
            this.GetComponent<Day0EnemySystemCyclops>().CyclopsBossDamage();
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player3 == true)
        {
            if (isHealing == false && isDefending == false)
            {
                yield return null;
                //yield return new WaitForSeconds(this.GetComponent<AttackAnim>().MedusaAnim[1].length);
            }
            else
            {
                yield return null;
                //yield return new WaitForSeconds(this.GetComponent<AttackAnim>().MedusaAnim[1].length);
            }
            this.GetComponent<Day0EnemySystemCyclops>().CyclopsBossDamage();
            this.GetComponent<Day0TurnSystemCyclops>().Player3 = false;
            isAttacking = false;
            this.GetComponent<Day0TurnSystemCyclops>().DisplayAvatarInfo();
            EnemyTurn = this.GetComponent<Day0EnemySystemCyclops>().EnemyAttacking();
            StartCoroutine(EnemyTurn);
        }
    }
} 

