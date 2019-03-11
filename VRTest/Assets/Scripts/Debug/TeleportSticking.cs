using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class TeleportSticking : MonoBehaviour
{
    private GameObject mg_LastHit;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<TeleportArea>())
        {
            Debug.Log("Hit new surface");
            if (mg_LastHit)
            {
                if(mg_LastHit != other.gameObject)
                {
                    //Debug.Log("Hit new surface");
                    //transform.SetParent(other.transform);
                }
            }
            else
            {
                mg_LastHit = other.gameObject;
            }
        }
    }
}
