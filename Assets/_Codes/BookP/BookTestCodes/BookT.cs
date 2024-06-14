using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookT : MonoBehaviour
{
    public GameObject LeftPage;
    public GameObject LeftC;
    public GameObject RightPage;
    public GameObject[] NumberOfPages;
    private void Start()
    {
        LeanTween.moveX(LeftPage.GetComponent<RectTransform>(), -408f, 2f);
        LeftPage.gameObject.GetComponent<RectTransform>().eulerAngles = new Vector3(0, 180, 0) * Time.deltaTime;
    }
}
