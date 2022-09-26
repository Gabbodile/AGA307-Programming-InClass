using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week1 : MonoBehaviour
{
    public int numberOne;
    public int numberTwo;
    public int numberThree;

    public int health = 100;
    public int bonus = 50;

    public GameObject go;
    public Camera cam;
    Light ourLight;
    void Start()
    {
        ourLight =go.GetComponent<Light>();
        ourLight.color = Color.cyan;

        float zPos = go.transform.position.z;

        /*AddNumbers(numberOne, numberTwo);
        AddNumbers(numberThree, numberTwo);
        AddNumbers(numberThree, numberOne);*/
        health = AddValues(health, bonus);
        Debug.Log(health);
    }

    int AddValues(int _one, int _two)
    {
        return _one + _two;
    }
    void AddNumbers(int _one, int _two)
    {
        int answer = _one + _two;
        Debug.Log(answer);
    }
}
