using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Avatar : MonoBehaviour
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
        GameObject.Find("AvatarN").GetComponent<TextMeshProUGUI>().text = "Avatar";
        GameObject.Find("AvatarH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
        GameObject.Find("AvatarS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
        GameObject.Find("AvatarK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
        GameObject.Find("AvatarST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
        GameObject.Find("AvatarD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
        GameObject.Find("AvatarStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        PageOpen = GameObject.Find("AvatarP");
        if (PageOpen.gameObject.activeSelf == true)
        {
            GameObject.Find("AvatarN").GetComponent<TextMeshProUGUI>().text = "Avatar";
            GameObject.Find("AvatarH").GetComponent<TextMeshProUGUI>().text = "Health : " + Health.ToString() + "/" + MaxHealth.ToString();
            GameObject.Find("AvatarS").GetComponent<TextMeshProUGUI>().text = "Slavage : " + Knowledge.ToString();
            GameObject.Find("AvatarK").GetComponent<TextMeshProUGUI>().text = "Knowledge : " + Knowledge.ToString();
            GameObject.Find("AvatarST").GetComponent<TextMeshProUGUI>().text = "Strength : " + Strengh.ToString();
            GameObject.Find("AvatarD").GetComponent<TextMeshProUGUI>().text = "Defense : " + Defense.ToString();
            GameObject.Find("AvatarStatus").GetComponent<TextMeshProUGUI>().text = "Status : " + Status;
        }
    }
}
