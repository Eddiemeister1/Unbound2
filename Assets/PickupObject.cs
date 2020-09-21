using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
           GameObject.Find("Gun").GetComponent<Gun>().currentammo = GameObject.Find("Gun").GetComponent<Gun>().maxammo;
            Destroy(gameObject);
        }
    }
}
