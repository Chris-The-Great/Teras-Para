using TMPro;
using UnityEngine;

public class Prodo : MonoBehaviour
{
    public GameObject PageOpen;

    [Header("Stats")]
    public static int MaxHealth = 40;
    public static int Health = 40;
    public static int Knowledge = 10;
    public static int Strength = 30;
    public static int Slavage = 10;
    public static int Bond = 0;
    public static int Defense = 0;
    public static string Status = "Base";
    
    
    public static bool isDefending;
    public static int HealRate = 3;
    private void Awake()
    {
        GameObject.Find("ProdoN").GetComponent<TextMeshProUGUI>().text = "Prodo";
        GameObject.Find("ProdoH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
        GameObject.Find("ProdoS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
        GameObject.Find("ProdoK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
        GameObject.Find("ProdoST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strength.ToString();
        GameObject.Find("ProdoD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
        GameObject.Find("ProdoStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;




    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        PageOpen = GameObject.Find("ProdoP");
        if (PageOpen.gameObject.activeSelf == true)
        {


            GameObject.Find("ProdoN").GetComponent<TextMeshProUGUI>().text = "Prodo";
            GameObject.Find("ProdoH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
            GameObject.Find("ProdoS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
            GameObject.Find("ProdoK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
            GameObject.Find("ProdoST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strength.ToString();
            GameObject.Find("ProdoD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
            GameObject.Find("ProdoStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;
        }
    }
}
