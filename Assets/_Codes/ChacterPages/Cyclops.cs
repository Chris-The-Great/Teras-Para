using TMPro;
using UnityEngine;

public class Cyclops : MonoBehaviour
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
    public static int EyeBallDamage;
    
    
    public static bool isDefending;
    public static int HealRate = 3;
    private void Awake()
    {
        GameObject.Find("CyclopsN").GetComponent<TextMeshProUGUI>().text = "Cyclops";
        GameObject.Find("CyclopsH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
        GameObject.Find("CyclopsS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
        GameObject.Find("CyclopsK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
        GameObject.Find("CyclopsST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
        GameObject.Find("CyclopsD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
        GameObject.Find("CyclopsStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;




    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        PageOpen = GameObject.Find("CyclopsP");
        if (PageOpen.gameObject.activeSelf == true)
        {
            GameObject.Find("CyclopsN").GetComponent<TextMeshProUGUI>().text = "Cyclops";
            GameObject.Find("CyclopsH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
            GameObject.Find("CyclopsS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
            GameObject.Find("CyclopsK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
            GameObject.Find("CyclopsST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
            GameObject.Find("CyclopsD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
            GameObject.Find("CyclopsStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;
        }
    }
}
