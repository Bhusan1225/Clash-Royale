using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public static GlobalManager Instance;
    public GameObject playerTarget;


    private void Awake()
    {
        Instance = this;
    }
}
