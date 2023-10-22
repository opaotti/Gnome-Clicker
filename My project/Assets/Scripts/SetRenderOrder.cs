using UnityEngine;

public class SetRenderOrder : MonoBehaviour
{
    public int sortingOrder = 1; // Dieser Wert wird im Inspector festgelegt

    void Start()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();

        foreach (Renderer renderer in renderers)
        {
            renderer.sortingOrder = sortingOrder;
        }
    }
}
