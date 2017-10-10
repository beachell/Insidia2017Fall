using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionAI : MonoBehaviour {

    List<GameObject> minionTarget = new List<GameObject>();
/// <summary>
/// The goal of this script is to make the minions follow the player that has control over them. when that player is out of 
/// the radius it will race back to it. 
/// </summary>

    public void OnTriggerEnter(Collider ally)
    {
      
    }
}
