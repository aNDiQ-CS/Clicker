using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L6 : MonoBehaviour
{
    [SerializeField] private Transform popupInventoty;
    [SerializeField] private Transform popupShop;
    private bool isVisible = true;
    public void ShowPopup(Transform popup)
    {
        isVisible = !isVisible;
        popup.gameObject.SetActive(isVisible);
        popup.SetAsLastSibling();
    }

}
