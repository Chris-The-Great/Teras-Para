using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;


public class WaveSystem : MonoBehaviour
{
    TextMeshProUGUI Wavedisplay;
    public int Wave;
    public int Maxwave;
    public static bool ED1;
    public static bool ED2;
    public static bool ED3;
    public bool DisplayR;

    EnemySpawn ES;
    combatUiHolder combatUI;
    Resluts resluts;
    private void Start()
    {
        Wave = 1;
        Maxwave = MissionHolder.NumberOfWaves;
        DisplayR = false;
        combatUI = GameObject.Find("UIDocument").GetComponent<combatUiHolder>();
        resluts = GameObject.Find("CombatCodes").GetComponent<Resluts>();
        combatUI.combatStatHolder.style.display = DisplayStyle.None;
        ES = this.GetComponent<EnemySpawn>();
    }
    private void Update()
    {
        combatUI.waveNumber.text = "Wave : " + Wave;
        if(ED1 && ED2 && ED3)
        {
            NextWave();
        }
    }

    void NextWave()
    {
        if (Wave != Maxwave)
        {
            Wave++;
            ES.S1();
            ES.S2();
            ES.S3();
            ED1 = false;
            ED2 = false;
            ED3 = false;
        }
        else
        {
            combatUI.Background.style.display = DisplayStyle.None;
            combatUI.combatStatHolder.style.display = DisplayStyle.Flex;
            resluts.DisplayMember1R();
            
        }
    }

}