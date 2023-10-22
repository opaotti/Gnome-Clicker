using UnityEngine;

public class ChangeRenderOrder : MonoBehaviour
{
    public GameObject infoboxPrefab; // Das Infobox-Prefab im Inspector zuweisen

    private void Start()
    {
        if (infoboxPrefab != null)
        {
            Renderer infoboxRenderer = infoboxPrefab.GetComponent<Renderer>();
            if (infoboxRenderer != null)
            {
                infoboxRenderer.sortingOrder = 1; // Ändere die Sortierreihenfolge nach Bedarf
            }
        }
    }
}
