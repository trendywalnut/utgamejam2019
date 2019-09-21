using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitch : MonoBehaviour
{
    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator.Play("StoryBoard");
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
