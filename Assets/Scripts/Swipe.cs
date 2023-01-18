using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    Vector3 offset;
    Vector3 startPosition;
    Transform clickedElement;

    [SerializeField] float thresholdValue = 0.4f;
    [SerializeField] Transform basket;

    public void OnPointerDown(PointerEventData eventData)
    {
        //Получить кликнутый элемент 
        clickedElement = eventData.pointerCurrentRaycast.gameObject.transform;
        //Установить смещение для правильного свайпа
        offset = clickedElement.localPosition - Input.mousePosition;
        //Закэшировать начальную позицию
        startPosition = clickedElement.GetComponent<RectTransform>().anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Условие, позволяющее свайпать позиции в меню
        if (clickedElement != null && clickedElement.CompareTag("Item"))
        {
            Vector3 newPosition = clickedElement.localPosition;
            newPosition.x = Input.mousePosition.x + offset.x;
            clickedElement.localPosition = newPosition;


            //Порог свайпа до активации 
            float threshold = clickedElement.GetComponent<RectTransform>().rect.width * thresholdValue;

/*            //Если свайпнули до порога - показать плашку, что можно отпустить и добавить в заказ
            if (clickedElement.localPosition.x >= threshold)
            {
                clickedElement.GetChild(5).gameObject.SetActive(true);
            }
            else if (clickedElement.localPosition.x <= threshold)
            {
                clickedElement.GetChild(5).gameObject.SetActive(false);
            }*/
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        float threshold = clickedElement.GetComponent<RectTransform>().rect.width * thresholdValue;

        //Если свайпнули до порога - добавить в заказ
        if (clickedElement.localPosition.x >= threshold)
        {
            AddToOrder();
        }

        //Вернуть айтем в начальную позицию
        if (clickedElement != null)
        {
            clickedElement.GetComponent<RectTransform>().anchoredPosition = startPosition;
        }
    }

    //заглушка
    private void AddToOrder()
    {
     //   basket.GetComponent<TMP_Text>().text += clickedElement.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text + ", ";
    }
}

