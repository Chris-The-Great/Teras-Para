using UnityEngine;

public class CPagesC : MonoBehaviour
{
    public GameMaster GM;
    [Header("Bool")]
    public static bool PCPU;// pull chracter pages up
    [Header("int")]
    public static int PageNumber;
    [Header("Pages")]
    public GameObject avatar;
    public GameObject griffin;
    public GameObject harpy;
    public GameObject cyclops;
    public GameObject medusa;
    public GameObject prodo;
    public GameObject faneia;

    public static bool IsPickingMission;
    public static bool IsPickingResource;
    public static bool IsPickingTraining;
    public static bool IsPickingPool;
    public static bool IsPickingResearch;
    // Start is called before the first frame update
    private void Awake()
    {
        GM = GameObject.Find("Game Master").GetComponent<GameMaster>();
        GM.CPC = this.gameObject.GetComponent<CPagesC>();
        GM.PageHolder();
        avatar.SetActive(false);
        griffin.SetActive(false);
        harpy.SetActive(false);
        cyclops.SetActive(false);
        medusa.SetActive(false);
        prodo.SetActive(false);
        faneia.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            PCPU = true;
            Debug.Log(PCPU);
        }
        if (PCPU == true)
        {
            avatar.SetActive(true);
        }
        else 
        {
            avatar.SetActive(false);
            griffin.SetActive(false);
            harpy.SetActive(false);
            cyclops.SetActive(false);
            medusa.SetActive(false);
            prodo.SetActive(false);
            faneia.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PCPU = false;
            //Mission.PMPU = false;
            ResourcesHolder.pageDisplay = false;
            Debug.Log(PCPU);
            PageNumber = 0;
            Time.timeScale = 1f;
        }
        TurnPage();
    }

    void TurnPage()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && PCPU == true)
        {
            PageNumber -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && PCPU == true)
        {
            PageNumber += 1;
        }
        if (PageNumber <= 1 && PCPU == true)
        {
            PageNumber = 1;
        }
        if (PageNumber >= 7 && PCPU == true)
        {
            PageNumber = 7;
        }

        switch (PageNumber)
        {
            case 1:
                avatar.SetActive(true);
                griffin.SetActive(false);
                harpy.SetActive(false);
                cyclops.SetActive(false);
                medusa.SetActive(false);
                prodo.SetActive(false);
                faneia.SetActive(false);
                break;
            case 2:
                avatar.SetActive(false);
                griffin.SetActive(true);
                harpy.SetActive(false);
                cyclops.SetActive(false);
                medusa.SetActive(false);
                prodo.SetActive(false);
                faneia.SetActive(false);
                break;
            case 3:
                avatar.SetActive(false);
                griffin.SetActive(false);
                harpy.SetActive(true);
                cyclops.SetActive(false);
                medusa.SetActive(false);
                prodo.SetActive(false);
                faneia.SetActive(false);
                break;
            case 4:
                avatar.SetActive(false);
                griffin.SetActive(false);
                harpy.SetActive(false);
                cyclops.SetActive(true);
                medusa.SetActive(false);
                prodo.SetActive(false);
                faneia.SetActive(false);
                break;
            case 5:
                avatar.SetActive(false);
                griffin.SetActive(false);
                harpy.SetActive(false);
                cyclops.SetActive(false);
                medusa.SetActive(true);
                prodo.SetActive(false);
                faneia.SetActive(false);
                break;
            case 6:
                avatar.SetActive(false);
                griffin.SetActive(false);
                harpy.SetActive(false);
                cyclops.SetActive(false);
                medusa.SetActive(false);
                prodo.SetActive(true);
                faneia.SetActive(false);
                break;
            case 7:
                avatar.SetActive(false);
                griffin.SetActive(false);
                harpy.SetActive(false);
                cyclops.SetActive(false);
                medusa.SetActive(false);
                prodo.SetActive(false);
                faneia.SetActive(true);
                break;
            default:
                avatar.SetActive(false);
                griffin.SetActive(false);
                harpy.SetActive(false);
                cyclops.SetActive(false);
                medusa.SetActive(false);
                prodo.SetActive(false);
                faneia.SetActive(false);
                break;
        }
    }
    public void MedusaPageC()
    {
        
        switch(Medusa.Status)
        {// break if statement into different cases
            case "Mission":
                Mission.NM -= 1;
                Medusa.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Medusa.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Medusa.Status = "Base";
                Training.whosTraining = "Medusa";
                break;
            case " Pool":
                Pool.PersonPicked = false;
                Medusa.Status = "Base";
                break;
           default:
                if(Mission.NM < 3 && IsPickingMission)
                {
                    Debug.Log(Mission.NM);
                    Mission.NM += 1;
                    Medusa.Status = "Mission";
                }
                else if(!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Medusa.Status = "Hunting";
                }
                else if(!Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Medusa.Status = "Training";
                }
                else if(!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Medusa.Status = "Pool";
                }
                break;
                
        }
    }
    public void GriffinPageC()
    {
        switch (Griffin.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Griffin.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Griffin.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Griffin.Status = "Base";
                Training.whosTraining = "Griffin";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Griffin.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Griffin.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Griffin.Status = "Hunting";
                }
                else if(Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Griffin.Status = "Training";
                }
                else if(!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Griffin.Status = "Pool";
                }
                break;

        }
    }
    public void HarpyPageC()
    {
        switch (Harpie.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Harpie.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Harpie.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Harpie.Status = "Base";
                Training.whosTraining = "Harpie";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Harpie.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Harpie.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Harpie.Status = "Hunting";
                }
                else if (Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Harpie.Status = "Training";
                }
                else if(!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Harpie.Status = "Pool";
                }
                break;

        }

    }
    public void CyclopsPageC()
    {
        switch (Cyclops.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Cyclops.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Cyclops.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Cyclops.Status = "Base";
                Training.whosTraining = "Cyclops";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Cyclops.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Cyclops.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Cyclops.Status = "Hunting";
                }
                else if (Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Cyclops.Status = "Training";
                }
                else if(!Pool.PersonPicked && IsPickingPool )
                {
                    Pool.PersonPicked = true;
                    Cyclops.Status = "Pool";
                }
                break;

        }

    }
    public void ProdoPageC()
    {
        switch (Prodo.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Prodo.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Prodo.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Prodo.Status = "Base";
                Training.whosTraining = "Prodo";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Prodo.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Prodo.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Prodo.Status = "Hunting";
                }
                else if (Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Prodo.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Prodo.Status = "Pool";
                }
                break;

        }
    }
    public void FaneiaPageC()
    {
        switch (Faneia.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Faneia.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Faneia.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Faneia.Status = "Base";
                Training.whosTraining = "Faneia";
                break;
            case "Pool":
                Pool.PersonPicked = false;
                Faneia.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Mission.NM += 1;
                    Debug.Log(Mission.NM);
                    Faneia.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                   ResourcesHolder.PersonPicked = true;
                   Faneia.Status = "Hunting";
                }
                else if(Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Faneia.Status = "Training";
                }
                else if(!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Faneia.Status = "Pool";
                }
                break;

        }
    }
    public void AvatarPageC()
    {

        switch (Avatar.Status)
        {
            case "Mission":
                Mission.NM -= 1;
                Avatar.Status = "Base";
                break;
            case "Hunting":
                ResourcesHolder.PersonPicked = false;
                Avatar.Status = "Base";
                break;
            case "Training":
                Training.PersonPicked = false;
                Avatar.Status = "Base";
                Training.whosTraining = "Avatar";
                break;
            case " Pool":
                Pool.PersonPicked = false;
                Avatar.Status = "Base";
                break;
            default:
                if (Mission.NM < 3 && IsPickingMission)
                {
                    Debug.Log(Mission.NM);
                    Mission.NM += 1;
                    Avatar.Status = "Mission";
                }
                else if (!ResourcesHolder.PersonPicked && IsPickingResource)
                {
                    ResourcesHolder.PersonPicked = true;
                    Avatar.Status = "Hunting";
                }
                else if (Training.PersonPicked && IsPickingTraining)
                {
                    Training.PersonPicked = true;
                    Avatar.Status = "Training";
                }
                else if (!Pool.PersonPicked && IsPickingPool)
                {
                    Pool.PersonPicked = true;
                    Avatar.Status = "Pool";
                }
                break;

        }
    }
}
