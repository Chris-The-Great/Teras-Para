using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class StoryStarter : MonoBehaviour
{
    public UIDocument day7;
    public UIDocument day7Part2;

    static StoryStarter gameObjectHolder = new StoryStarter();
    private void Start()
    {
        hideCutsence();
        startCutsence();
        //deleteCutsence();
        
    }

    void startCutsence()
    {
        
        switch (UI.dayNightCycle)
        {
            case 2:
                day7.gameObject.SetActive(true);
                break;
        }
    }
    void deleteCutsence()
    {
        if(UI.dayNightCycle > 7)
        {
            Destroy(day7.gameObject);
        }
    }
    void hideCutsence()
    {
        day7.gameObject.SetActive(false);
    }

   public static bool LeaveBaseForMission()
    {
        switch(UI.dayNightCycle) 
        {
            case 2:
                LeaveBase.Async = SceneManager.LoadSceneAsync("Day7");
                //gameObjectHolder.day7Part2.gameObject.SetActive(true);
                return true;
            default:
                LeaveBase.Async = SceneManager.LoadSceneAsync("CombatV2");
                return false;
        }                                              
    }
}
