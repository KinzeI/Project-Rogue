using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject X;
    public Camera Cam;
    private float Sensity;
    private Vector3 PushPosition;
    private Vector3 CameraPushPosition;
    
    void Start()
    {
        FixSensity();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PushPosition = Input.mousePosition;
            CameraPushPosition = Cam.transform.position;
        }
        if (Input.GetMouseButton(0))
        {
            Cam.transform.position = CameraPushPosition + (PushPosition - Input.mousePosition) * Sensity;
        }
    }
    public void CloseApp()
    {
        Application.Quit();
        Debug.Log("Должно было закрыться");
    }
    private void FixSensity()
    {
        float m1 = Cam.ScreenToWorldPoint(new Vector3(0, 0)).x;
        float m2 = Cam.ScreenToWorldPoint(new Vector3(10, 0)).x;
        Sensity = (m2 - m1) / 10;
    }
    public void FillMap()
    {
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
            {
                GameObject Instance = Instantiate(X);
                Instance.transform.position = new Vector3(X.transform.position.x + j * 200, X.transform.position.y - i * 200, X.transform.position.z);
                Instance.transform.parent = X.transform.parent;
            }
    }
}
