using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor2D : MonoBehaviour
{
    [SerializeField]
    GameObject followTarget;
    [SerializeField]
    Animator animator;


    private void Awake()
    {

        animator = GetComponent<Animator>();
    }

    private void LateUpdate()
    {
        if (followTarget != null)
        {
            transform.localPosition = new Vector3(followTarget.transform.localPosition.x, followTarget.transform.localPosition.y, followTarget.transform.localPosition.z);
        }

    }
}
