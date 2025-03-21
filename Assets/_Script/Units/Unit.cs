using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Unit : MonoBehaviour
{

    [SerializeField]
    private Actor3D agent;
    [SerializeField]
    private Actor2D unitSprite;
    [SerializeField]
    private GameObject target;
    [SerializeField]
    

    private void Update()
    {
        if (target != null)
            agent.Agent.SetDestination(target.transform.position);
    }


}