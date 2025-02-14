using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class OpenLevel : MonoBehaviour
{
    public void GoLevel1()
    {
        MMSceneLoadingManager.LoadScene("level1");
    }
}