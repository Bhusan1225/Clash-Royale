using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable 
{

    BaseState Stats { get; }
    List<GameObject> HitTargets { get; }

    GameObject Target { get; set; }

    void TakeDamage(float damage);

  
}
