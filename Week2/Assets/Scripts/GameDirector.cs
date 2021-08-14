using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;

    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
    }
}
