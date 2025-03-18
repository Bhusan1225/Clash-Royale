using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Unit : MonoBehaviour, IDamagable
{

    [SerializeField]
    private Actor3D agent;
    [SerializeField]
    private Actor2D unitSprite;
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private BaseState stats;
    [SerializeField]
    private List<GameObject> hitTargets;

 





    public BaseState Stats
    {
        get { return stats; }
        
    }
    public Actor3D Agent { get { return agent; } }
    public Actor2D UnitSprite { get { return unitSprite; } }
    public GameObject Target
    {
        get { return target; }
        set { target = value; }
    }
    public List<GameObject> HitTargets
    {
        get { return hitTargets; }

    }



    List<GameObject> IDamagable.HitTargets => throw new System.NotImplementedException();

    

    void IDamagable.TakeDamage(float amount)
    {
        stats.CurrentHealth -= amount;
    }

    private void Update()
    {
        if (target != null)
            agent.Agent.SetDestination(target.transform.position);
    }


}