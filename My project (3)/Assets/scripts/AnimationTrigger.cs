using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    Animator m_Animator;
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame 

    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            m_Animator.SetTrigger("isDying");

        }
    }
}
