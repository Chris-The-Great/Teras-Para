using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [Header("Int")]
    public static int MutantNumber;// Number of mutants in the world. Scpirts touching are: Mission,UI
    [Header("Others")]
    public int GMC;
    [Header("Codes")]
    public Medusa M;
    public Griffin G;
    public Cyclops C;
    public Harpie H;
    public Prodo P;
    public Faneia F;
    public CPagesC CPC;
    // Start is called before the first frame update

    private void Awake()
    {
        GMC = FindObjectsOfType<GameMaster>().Length;
        if (GMC != 1)
        {
            Destroy(this.gameObject);
        }
        MutantNumber = 10000;
        
    }

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void MissionMath()
    {

    }
    public void PageHolder()
    {
        M = GameObject.Find("TeamStats").GetComponent<Medusa>();
        G = GameObject.Find("TeamStats").GetComponent<Griffin>();
        C = GameObject.Find("TeamStats").GetComponent<Cyclops>();
        H = GameObject.Find("TeamStats").GetComponent<Harpie>();
        P = GameObject.Find("TeamStats").GetComponent<Prodo>();
        F = GameObject.Find("TeamStats").GetComponent<Faneia>();
    }

}
