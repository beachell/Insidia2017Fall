using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//put on an empty game object
public class BulletPool : MonoBehaviour {

    public static List<Rigidbody> bullets = new List<Rigidbody>();
    public static bool shooting;
	
}
