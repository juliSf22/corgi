using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class OpenYouWin : MonoBehaviour
{
    public void YouWin1()
    {
        MMSceneLoadingManager.LoadScene("YouWin");
    }
}