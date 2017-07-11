using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{

    void Update()
    {
        Animator anim = GetComponent<Animator>();
        if (Input.GetKeyDown("space"))
        {
            anim.SetTime(0);
            anim.Play("JUMP00");
        }
    }
}
