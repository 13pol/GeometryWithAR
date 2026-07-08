using UnityEngine;

public class CreditsCam : MonoBehaviour
{

    bool firstTouch = false;
    Vector3 rawPosition;
    public RectTransform canvasToMove;
    float moveReductionFactor = 1.5f;
    float minY = -850;
    public float maxY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Screen.orientation = UnityEngine.ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (!firstTouch)
            {
                rawPosition = touch.position;
                firstTouch = true;
            }

            Vector3 touchPosition = new Vector3(0, touch.position.y, 0);
            Vector3 resta = new Vector3(0, (touchPosition.y - rawPosition.y) * moveReductionFactor, 0);
            Vector3 newPosition = canvasToMove.anchoredPosition3D + resta;

            canvasToMove.anchoredPosition3D = CanvasLimits(newPosition);

            rawPosition = touchPosition;
        }
        else
        {
            firstTouch = false;
        }
    }

    

    private Vector3 CanvasLimits(Vector3 newPosition)
    {
        Vector3 finalPosition = newPosition;
        if (finalPosition.y < minY) { finalPosition.y = minY; }
        if (finalPosition.y > maxY) { finalPosition.y = maxY; }
        return finalPosition;
    }
}
