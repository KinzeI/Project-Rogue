using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    public static Holder Instance;
    public Sprite Creature;
    void Start()
    {
        Instance = this;
    }
}
