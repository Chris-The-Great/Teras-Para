using TMPro;
using UnityEngine;

public class Faneia : MonoBehaviour
{
    public GameObject PageOpen;

    [Header("Stats")]
    public static int MaxHealth = 40;
    public static int Health = 40;
    public static int Knowledge = 10;
    public static int Strengh = 30;
    public static int Slavage = 10;
    public static int Bond = 0;
    public static int Defense = 0;
    public static string Status = "Base";

    public static bool isDefending;

    public static int HealRate = 3;

    private void Awake()
    {
        GameObject.Find("FaneiaN").GetComponent<TextMeshProUGUI>().text = "Faneia";
        GameObject.Find("FaneiaH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
        GameObject.Find("FaneiaS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
        GameObject.Find("FaneiaK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
        GameObject.Find("FaneiaST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
        GameObject.Find("FaneiaD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
        GameObject.Find("FaneiaStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;




    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        PageOpen = GameObject.Find("FaneiaP");
        if (PageOpen.gameObject.activeSelf == true)
        {
            GameObject.Find("FaneiaN").GetComponent<TextMeshProUGUI>().text = "Faneia";
            GameObject.Find("FaneiaH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
            GameObject.Find("FaneiaS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
            GameObject.Find("FaneiaK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
            GameObject.Find("FaneiaST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
            GameObject.Find("FaneiaD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
            GameObject.Find("FaneiaStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;
        }
    }
}
