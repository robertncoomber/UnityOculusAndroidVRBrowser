using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildInrementer : MonoBehaviour
{
    public string buildNumber;

    private void Awake() {
        Debug.Log("Build Number: " + buildNumber);
    }
}
