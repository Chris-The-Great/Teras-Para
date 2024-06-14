using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestA : MonoBehaviour
{
    public Animator MedusaA;
    public Image TeamMember1;

    bool Idle;
    bool Damaged;

    private void Start()
    {
        MedusaA = TeamMember1.GetComponent<Animator>();
        
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Idle)
        {
            Debug.Log("ButtonPressed");
            MedusaA.SetBool("isIdle", false);
            MedusaA.SetBool("isDamaged", true);
            Damaged = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Damaged)
        {

        }
    }


    public IEnumerator WaitForAnima()
    {

        yield return new WaitForSeconds(MedusaA.GetCurrentAnimatorStateInfo(0).length + MedusaA.GetCurrentAnimatorStateInfo(0).normalizedTime);
    }
}
