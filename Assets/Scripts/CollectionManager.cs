using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{

    public GameObject ListitemPrefab;
    public GameObject TargetScrollingObjectCollection;
    private ScrollingObjectCollection scrollingObjectCollectionComponent;
    private GridObjectCollection gridObjectCollectionComponent;

    // Start is called before the first frame update
    void Start()
    {
        scrollingObjectCollectionComponent = TargetScrollingObjectCollection.GetComponent<ScrollingObjectCollection>();

        gridObjectCollectionComponent = scrollingObjectCollectionComponent.GetComponentInChildren<GridObjectCollection>();

        foreach (Transform child in gridObjectCollectionComponent.transform)
        {
            Destroy(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddNewItem()
    {
        Instantiate(ListitemPrefab, gridObjectCollectionComponent.transform);

        gridObjectCollectionComponent.UpdateCollection();

        scrollingObjectCollectionComponent.UpdateContent();
    }
}
