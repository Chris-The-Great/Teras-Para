using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class Day7CombatSystem : MonoBehaviour
{
    IEnumerator ChangeTurn;
    IEnumerator EnemyTurn;

    public int switchCounter;

    public GameObject BloodGorgon;
    public GameObject griffin1;
    public GameObject griffin2;

    public BloodGorgonUIHolder bloodGorgonUIHolder;

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
        bloodGorgonUIHolder = GameObject.Find("UIDocument").GetComponent<BloodGorgonUIHolder>();
        bloodGorgonUIHolder.skillsHolder.style.display = DisplayStyle.None;
        bloodGorgonUIHolder.attack.RegisterCallback<ClickEvent>(AttackingBloodGorgon);
        //cyclopsUIHolder.skills.RegisterCallback<ClickEvent>(SelectSkill);
    }

    private void Update()
    {
        //GameObject.Find("Dia").GetComponent<Day0Dia>().NextLine();
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

    public void AttackingBloodGorgon(ClickEvent evt)
    {
        if (this.GetComponent<Day7TurnSystem>().Player1)
        {
            
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Prodo.Strength;
            

            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Prodo.Strength;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Prodo.Strength;
            }
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player2)
        {
           
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Faneia.Strengh;
            

            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Faneia.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Faneia.Strengh;
            }
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player3)
        {
            
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Avatar.Strengh;
            

            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Avatar.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                BloodGorgon.GetComponent<BloodGorgonAI>().Health -= Avatar.Strengh;
            }
        }
    }
    public void AttackingGriffin1(ClickEvent evt)
    {
        if (this.GetComponent<Day0TurnSystemCyclops>().Player1)
        {

            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            griffin1.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;


            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;
            }
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player2)
        {

            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            griffin1.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;


            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;
            }
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player3)
        {

            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            griffin1.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;


            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<CyclopsBossAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin1.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;
            }
        }
    }
    public void AttackingGriffin2(ClickEvent evt)
    {
        if (this.GetComponent<Day0TurnSystemCyclops>().Player1)
        {

            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            griffin2.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;


            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Prodo.Strength;
            }
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player2)
        {

            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            griffin2.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;


            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Faneia.Strengh;
            }
        }
        else if (this.GetComponent<Day0TurnSystemCyclops>().Player3)
        {

            ChangeTurn = WaitAttackP1();
            StartCoroutine(ChangeTurn);
            griffin2.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;


            if (isSkilling && isUseSkill1)
            {

                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;


            }
            else if (isSkilling && isUseSkill2)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill3)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;
            }
            else if (isSkilling && isUseSkill4)
            {
                ChangeTurn = WaitAttackP1();
                StartCoroutine(ChangeTurn);
                griffin2.GetComponent<Day7GriffinAI>().Health -= Avatar.Strengh;
            }
        }
    }
    public IEnumerator WaitAttackP1()
    {
        if (this.GetComponent<Day7TurnSystem>().Player1 == true)
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
           this.GetComponent<Day7TurnSystem>().PlayerDeath();
            if (Faneia.Health >= 0)
            {
                this.GetComponent<Day7TurnSystem>().Player2 = true;
                this.GetComponent<Day7TurnSystem>().DisplayFaneiaInfo();
            }
            else if (Avatar.Health >= 0)
            {
                this.GetComponent<Day7TurnSystem>().Player3 = true;
                this.GetComponent<Day7TurnSystem>().DisplayAvatarInfo();
            }
            else
            {
                EnemyTurn = this.GetComponent<Day7EnemySystem>().EnemyAttacking();
                Day7EnemySystem.bloodGorgonTurn = true;
                StartCoroutine(EnemyTurn);
            }
            this.GetComponent<Day7TurnSystem>().Player1 = false;
            isAttacking = false;
        }
        else if (this.GetComponent<Day7TurnSystem>().Player2 == true)
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
                this.GetComponent<Day7TurnSystem>().Player3 = true;
                this.GetComponent<Day7TurnSystem>().DisplayAvatarInfo();
            }
            else
            {
                EnemyTurn = this.GetComponent<Day7EnemySystem>().EnemyAttacking();
                Day7EnemySystem.bloodGorgonTurn = true;
                StartCoroutine(EnemyTurn);
            }
            this.GetComponent<Day7TurnSystem>().Player2 = false;
            isAttacking = false;
        }
        else if (this.GetComponent<Day7TurnSystem>().Player3 == true)
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
            this.GetComponent<Day7TurnSystem>().Player3 = false;
            isAttacking = false;
            this.GetComponent<Day7TurnSystem>().DisplayAvatarInfo();
            Day7EnemySystem.bloodGorgonTurn = true;
            EnemyTurn = this.GetComponent<Day7EnemySystem>().EnemyAttacking();
            StartCoroutine(EnemyTurn);
        }
    }
} 

