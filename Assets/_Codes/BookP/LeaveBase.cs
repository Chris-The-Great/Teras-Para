using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LeaveBase : MonoBehaviour
{

    public static AsyncOperation Async;
    [Header("LayerMask")]
    int ExitGate = 1 << 9;
    int MissionCenter = 1 << 10;
    int ResourceBase = 1 << 12;
    int TrainingGround = 1 << 13;
    int PoolW = 1 << 14;
    int ResearchBaseO = 1 << 15;
    [Header("Vector3")]
    public Vector3 Placeholder;
    public Vector3 Direction;
    [Header("Float")]
    public float Thiccc;
    // [Header("Gameobject")]
    //public GameObject CombatScreen;
    // Start is called before the first frame update
    void Start()
    {

        Thiccc = 3;
        //StoryStarter.LeaveBaseForMission();
        Async.allowSceneActivation = false;
    }

    // Update is called once per frame
    void Update()
    {
        Placeholder = this.transform.position;
        Direction = transform.TransformDirection(Vector3.forward);
        LeaveBaseM();
        MissionCeneterSelect();
        ResourcesBaseSelect();
        TrainingGroundSelect();
        PoolSelect();
        ResearchSelect();
    }

    void LeaveBaseM()
    {
        if (Physics.CheckSphere(Placeholder, 100f, ExitGate))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if(StoryStarter.LeaveBaseForMission())
                {
                    // do nothing
                }
                else
                {
                    //Async.allowSceneActivation = true;
                }
            }
        }
    }

    void MissionCeneterSelect()
    {

        if (Physics.CheckSphere(Placeholder, 100f, MissionCenter))
        {
            Debug.Log(Mission.pageDisplay);
            if (Input.GetKeyDown(KeyCode.Mouse0) && Mission.pageDisplay == "false")
            {
                Debug.Log(Mission.pageDisplay);
                Mission.pageDisplay = "ture";
                Mission.pageNumber = 1;
                Mission.Root1.style.display = DisplayStyle.Flex;
            }
        }

    }

    void ResourcesBaseSelect()
    {
        if (Physics.CheckSphere(Placeholder, 100f, ResourceBase))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && ResourcesHolder.pageDisplay == false)
            {
                ResourcesHolder.Root.style.display = DisplayStyle.Flex;
                ResourcesHolder.pageDisplay = true;
                Time.timeScale = 0f;
            }
        }

    }
    void TrainingGroundSelect()
    {
        if (Physics.CheckSphere(Placeholder, 100f, TrainingGround))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && Training.pageDisplay == false)
            {
                Training.Root.style.display = DisplayStyle.Flex;
                Training.pageDisplay = true;
                Time.timeScale = 0f;
            }
        }
    }

    void PoolSelect()
    {
        if (Physics.CheckSphere(Placeholder, 100f, PoolW))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && Pool.PUPP == false)
            {
                Pool.pool.SetActive(true);
                Pool.PUPP = true;
                Time.timeScale = 0f;
            }
        }
    }

    void ResearchSelect()
    {
        if (Physics.CheckSphere(Placeholder, 100f, ResearchBaseO))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && ResearchBase.PRBP == false)
            {
                ResearchBase.ResearchPage.SetActive(true);
                ResearchBase.PRBP = true;
                Time.timeScale = 0f;
            }
        }
    }

    void CloseAll()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Mission.Root1.style.display = DisplayStyle.None;

            GameObject.Find("ResourceP").SetActive(false);
            ResourcesHolder.pageDisplay = false;
            Time.timeScale = 1f;
        }
    }

}
