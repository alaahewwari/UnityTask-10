using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int result = multipy(i, 5);
            Debug.Log("5 * " + i + " = " + result);
        }
    }
    int multipy(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
}
