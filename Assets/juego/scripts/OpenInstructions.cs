
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class OpenInstructions : MonoBehaviour
{
    public void Instructions()
    {
        MMSceneLoadingManager.LoadScene("Instructions");
    }
}