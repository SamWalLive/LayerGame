using UnityEngine;
using System.Collections;

public class SlowingField : MonoBehaviour
{

    public float originalMultiplier;
    public float newMultiplier;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().multiplier = newMultiplier;
            return;
        }
        else if(other.CompareTag("NPC"))
        {
            other.GetComponent<NPCMovement>().multiplier = newMultiplier;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().multiplier = originalMultiplier;
        }
        else if(other.CompareTag("NPC"))
        {
            other.GetComponent<NPCMovement>().multiplier = originalMultiplier;
        }
    }

}