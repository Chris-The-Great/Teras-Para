using UnityEngine;

public class LookTemp : MonoBehaviour
{
    int Person = 1 << 11;
    [Header("Vector3")]
    public Vector3 Placeholder;
    public Vector3 Direction;

    public static GameObject Panel;
    public static GameObject Uiinfo;
    public static GameObject FaneiaI;
    public static GameObject GriffinI;
    public static GameObject HarpyI;
    public static GameObject ProdoI;
    public T t;
    public static GameObject TeamPage;

    public static int Pic;
    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.Find("Dia").GetComponent<T>();
        Panel = GameObject.Find("Panel");
        Panel.SetActive(false);
        Uiinfo = GameObject.Find("UI Info");
        FaneiaI = GameObject.Find("Faneia I");
        GriffinI = GameObject.Find("Griffin I");
        HarpyI = GameObject.Find("Harpy I");
        ProdoI = GameObject.Find("Prodo I");
        TeamPage = GameObject.Find("TeamPage");
        TeamPage.SetActive(false);
        FaneiaI.SetActive(false);
        GriffinI.SetActive(false);
        HarpyI.SetActive(false);
        ProdoI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Placeholder = this.transform.position;
        Direction = transform.TransformDirection(Vector3.forward);
        FindF();
        FindG();
        FindH();
        FindP();
    }

    void FindF()
    {
        RaycastHit F;

        if (Physics.CheckSphere(Placeholder, 20f, Person, QueryTriggerInteraction.Collide))

        {
            Debug.Log("X");
            if (Input.GetKeyDown(KeyCode.X) && Pic == 1)
            {
                Debug.Log("XX");
                Panel.SetActive(true);
                Uiinfo.SetActive(false);
                FaneiaI.SetActive(true);
                T.TextBox.SetActive(true);
                t.NextLine();
            }
        }
        else
        {
            Debug.DrawRay(Placeholder, Direction * 1000, Color.white);
        }
    }
    void FindG()
    {
        if (Physics.CheckSphere(Placeholder, 20f, Person, QueryTriggerInteraction.Collide))

        {
            Debug.Log("X");
            if (Input.GetKeyDown(KeyCode.X) && Pic == 2)
            {
                Debug.Log("XX");
                Panel.SetActive(true);
                Uiinfo.SetActive(false);
                GriffinI.SetActive(true);
                T.TextBox.SetActive(true);
                t.NextLine();
            }
        }
        else
        {
            Debug.DrawRay(Placeholder, Direction * 1000, Color.white);
        }
    }
    void FindH()
    {
        if (Physics.CheckSphere(Placeholder, 20f, Person, QueryTriggerInteraction.Collide))

        {
            Debug.Log("X");
            if (Input.GetKeyDown(KeyCode.X) && Pic == 3)
            {
                Debug.Log("XX");
                Panel.SetActive(true);
                Uiinfo.SetActive(false);
                HarpyI.SetActive(true);
                T.TextBox.SetActive(true);
                t.NextLine();
            }
        }
        else
        {
            Debug.DrawRay(Placeholder, Direction * 1000, Color.white);
        }
    }
    void FindP()
    {
        if (Physics.CheckSphere(Placeholder, 20f, Person, QueryTriggerInteraction.Collide))

        {
            Debug.Log("X");
            if (Input.GetKeyDown(KeyCode.X) && Pic == 4)
            {
                Debug.Log("XX");
                Panel.SetActive(true);
                Uiinfo.SetActive(false);
                ProdoI.SetActive(true);
                T.TextBox.SetActive(true);
                t.NextLine();
            }
        }
        else
        {
            Debug.DrawRay(Placeholder, Direction * 1000, Color.white);
        }
    }
}
