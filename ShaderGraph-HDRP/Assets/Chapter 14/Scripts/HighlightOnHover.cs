using UnityEngine;
using UnityEngine.EventSystems;

public class HighlightOnHover : MonoBehaviour, 
                                IPointerEnterHandler, 
                                IPointerExitHandler
{
    public Color highlightColor = Color.red;

    private Material material;

    // Use this for initialization
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;

        // Turn off glow
        OnPointerExit(null);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        material.SetColor("HoverColor", highlightColor);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        material.SetColor("HoverColor", Color.black);
    }
}
