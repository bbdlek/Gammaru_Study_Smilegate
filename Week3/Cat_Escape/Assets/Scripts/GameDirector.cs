using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject hpGuage;

    void Start()
    {
        this.hpGuage = GameObject.Find("HP_Guage");
    }

    public void DecreaseHp()
    {
        this.hpGuage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
