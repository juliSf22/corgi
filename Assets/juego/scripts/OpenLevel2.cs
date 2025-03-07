using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class OpenLevel2 : MonoBehaviour
{
    public void GoLevel2()
    {
        MMSceneLoadingManager.LoadScene("level2");
    }
}
