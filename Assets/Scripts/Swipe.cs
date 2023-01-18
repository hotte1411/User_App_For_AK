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
        //�������� ��������� ������� 
        clickedElement = eventData.pointerCurrentRaycast.gameObject.transform;
        //���������� �������� ��� ����������� ������
        offset = clickedElement.localPosition - Input.mousePosition;
        //������������ ��������� �������
        startPosition = clickedElement.GetComponent<RectTransform>().anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //�������, ����������� �������� ������� � ����
        if (clickedElement != null && clickedElement.CompareTag("Item"))
        {
            Vector3 newPosition = clickedElement.localPosition;
            newPosition.x = Input.mousePosition.x + offset.x;
            clickedElement.localPosition = newPosition;


            //����� ������ �� ��������� 
            float threshold = clickedElement.GetComponent<RectTransform>().rect.width * thresholdValue;

/*            //���� ��������� �� ������ - �������� ������, ��� ����� ��������� � �������� � �����
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

        //���� ��������� �� ������ - �������� � �����
        if (clickedElement.localPosition.x >= threshold)
        {
            AddToOrder();
        }

        //������� ����� � ��������� �������
        if (clickedElement != null)
        {
            clickedElement.GetComponent<RectTransform>().anchoredPosition = startPosition;
        }
    }

    //��������
    private void AddToOrder()
    {
     //   basket.GetComponent<TMP_Text>().text += clickedElement.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text + ", ";
    }
}

