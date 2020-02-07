using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    void Start()
    {
        
    }
    public void CloseApp()
    {
        Application.Quit();
        Debug.Log("Должно было закрыться");
    }
}
