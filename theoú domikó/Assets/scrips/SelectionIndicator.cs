using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionIndicator : MonoBehaviour
{
    public GameObject indicator;
    public void SetSelected(bool selected)
    {
        if (indicator != null)
            indicator.SetActive(selected);
    }
}
