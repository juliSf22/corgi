using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class HealControl : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Stimpack heal = e.PickedItem.GetComponent<Stimpack>();
        if (heal != null)
        {
            Debug.Log("healed");
        }
    }
}