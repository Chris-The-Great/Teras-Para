using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsS;
    public Slider VolumeS;
    // Start is called before the first frame update
    void Start()
    {
        OptionsS.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _CutsceneT.TPSS = true;
        }
    }

    public void StartGame()
    {
        if (_CutsceneT.TPSS == false)
        {
            SceneManager.LoadScene("Day0", LoadSceneMode.Single);
        }
        else
        {
            //SceneManager.LoadScene("Teras Para", LoadSceneMode.Single);

        }
    }
    public void Countuine()
    {
        if (_CutsceneT.TPSS == true)
        {
            //SceneManager.LoadScene("Teras Para", LoadSceneMode.Single);
        }
    }
    public void Options()
    {
        OptionsS.gameObject.SetActive(true);
    }
    public void BackMM()
    {
        OptionsS.gameObject.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();

    }
    private void Awake()
    {

    }
}
