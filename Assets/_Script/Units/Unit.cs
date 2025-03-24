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
   
    
    

    private void Update()
    {
        //if (GlobalManager.Instance.playerTarget != null)
        //    agent.Agent.SetDestination(GlobalManager.Instance.playerTarget.transform.position);
    }


}