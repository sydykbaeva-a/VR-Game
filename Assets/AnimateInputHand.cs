using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateInputHand : MonoBehaviour
{
    public InputActionProperty pressAnimation;
    public InputActionProperty gripAnimation;
    public Animator handAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //reading the value from Input
        float readAnim = pressAnimation.action.ReadValue<float>();
        handAnim.SetFloat("Trigger", readAnim);

        float gripAnim = gripAnimation.action.ReadValue<float>();
        handAnim.SetFloat("Grip", gripAnim);
    }
}
