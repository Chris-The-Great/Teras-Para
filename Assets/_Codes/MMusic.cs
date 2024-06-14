using UnityEngine;
using UnityEngine.UI;

public class MMusic : MonoBehaviour
{

    public AudioSource AS;
    public AudioClip ThemeSong;
    public Slider VolumeS;
    public int MMC;

    private void Awake()
    {
        VolumeS = GameObject.Find("VolumeS").GetComponent<Slider>();
        MMC = FindObjectsOfType<MMusic>().Length;
        if (MMC != 1)
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        AS = GameObject.Find("MMusic").GetComponent<AudioSource>();
        ThemeSong = Resources.Load<AudioClip>("_Music_sounds/Hope");
        VolumeS.value = .2f;
        AS.clip = ThemeSong;
        AS.Play();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (VolumeS != null)
        {
            AS.volume = VolumeS.value;
        }

    }
}
