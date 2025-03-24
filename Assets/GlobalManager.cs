using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public static GlobalManager Instance;



    private void Awake()
    {
        Instance = this;
    }

    public GameObject playerTarget;





}
