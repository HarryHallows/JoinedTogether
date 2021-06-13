using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CraftMove : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler,IEndDragHandler
{


    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;

    private RectTransform objectPosition;

    private void Awake()
    {
        objectPosition = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + GetComponent<RectTransform>().anchoredPosition);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging " + gameObject.name);

        objectPosition.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Finished Dragging");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down on " + gameObject.name);

    }

}
