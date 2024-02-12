using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicRig : MonoBehaviour
{
    public Transform playerHead;
    public CapsuleCollider bodyColl;

    public float bodyHeightMin = 0.5f;
    public float bodyHeightMax = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        bodyColl.height = Mathf.Clamp(playerHead.localPosition.y, bodyHeightMin, bodyHeightMax);
        bodyColl.center = new Vector3(playerHead.localPosition.x, bodyColl.height / 2, playerHead.localPosition.z);
    }
}
