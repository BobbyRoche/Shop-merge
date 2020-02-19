using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logic : MonoBehaviour
{
    // Start is called before the first frame update
    public score_board s;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Item")
        {
            s.score += 1;
        }
    }
}
