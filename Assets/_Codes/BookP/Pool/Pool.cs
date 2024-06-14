using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pool : MonoBehaviour
{
    public static GameObject pool;

    public TextMeshProUGUI PoolStatus;
    public TextMeshProUGUI BloodNeeded;
    public static int BloodN;
    public static bool PersonPicked;

    public static bool PUPP;

    public void Awake()
    {
        pool = GameObject.Find("PoolP");
        PUPP = false;
        pool.SetActive(false);
        BloodN = 10;
    }

    private void Update()
    {
        DisplayInfo();
        
    }

    void DisplayInfo()
    {
        BloodNeeded.text = "Amount of blood needed/Blood had : " + BloodN + " / " + ResourcesHolder.MutantBlood.ToString();
        if (ResourcesHolder.MutantBlood >= BloodN)
        {
            PoolStatus.text = "Status : Available";

        }
        else
        {
            PoolStatus.text = "Status : Unavailble";
        }
    }

    public void UsePool()
    {
        pool.SetActive(false);
        PUPP = true;
        CPagesC.PageNumber = 1;
        CPagesC.PCPU = true;
        CPagesC.IsPickingMission = false;
        CPagesC.IsPickingResource = false;
        CPagesC.IsPickingTraining = false;
        CPagesC.IsPickingPool = true;
    }
}
