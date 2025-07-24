// --------------------------------------------------------------------------------------
// Class Name:       OnHoveringBioText
// Author:           Chetana Mali
// Created Date:     3-9-2024
// Last Modified:    29-10-2024 by [Chetana Mali]
// Description:      Manages the visibility of a biography text panel in a bug-themed card game.
//                   The panel appears when the mouse hovers over the element and hides when
//                   the mouse exits. Implements IPointerEnterHandler and IPointerExitHandler
//                   to handle UI hover events in Unity.
// --------------------------------------------------------------------------------------


using UnityEngine;
using UnityEngine.EventSystems;

public class OnHoveringBioText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameObject bioTextPanel;
    private void Start()
    {
        bioTextPanel.SetActive(false);
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("onmouseover");
        bioTextPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("onmouseexit");
        bioTextPanel.SetActive(false);
    }
}
