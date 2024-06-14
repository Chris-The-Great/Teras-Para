using TMPro;
using UnityEngine;

public class Medusa : MonoBehaviour
{
    public GameObject PageOpen;
    public GameMaster GM;

    [Header("Stats")]
    public static int MaxHealth = 40;
    public static int Health = 30;
    public static int Knowledge = 10;
    public static int Strengh = 30;
    public static int Slavage = 10;
    public static int Bond = 0;
    public static int Defense =0;
    public static string Status = "Base";

    public static bool isDefending;
    public static int HealRate;

    //Change everyone stats from awake into the top part when you declare them and it'll work just fine.
    public bool StatsBeenSet;
    public int GMC;

    public static bool IsPoisoned;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        GMC = FindObjectsOfType<GameMaster>().Length;
        if (GMC != 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(PageOpen);
    }

    // Update is called once per frame
    void Update()
    {
        PageOpen = GameObject.Find("MedusaP");
        if (PageOpen.gameObject.activeSelf == true)
        {
            GameObject.Find("MedusaN").GetComponent<TextMeshProUGUI>().text = "Medusa";
            GameObject.Find("MedusaH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
            GameObject.Find("MedusaS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
            GameObject.Find("MedusaK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
            GameObject.Find("MedusaST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
            GameObject.Find("MedusaD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
            GameObject.Find("MedusaStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;
        }
    }
}
