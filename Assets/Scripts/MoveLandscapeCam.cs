using UnityEngine;


public class MoveLandscapeCam : MonoBehaviour
{
    public Camera cameraToMove;

    public int id;

    int actualState = 0;
    bool firstTouch = false;

    Vector3 rawPosition;
    float moveReductionFactor;

    float rawDistance;
    public float zoomReductionFactor;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;


    private void Start()
    {
        
    }

    private void Update()
    {
        cameraToMove.transform.position = CameraLimits(cameraToMove.transform.position);
        moveReductionFactor = FindMoveReductionFactor();

        if (Input.touchCount == 1 && (actualState == 0 || actualState == 1))
        {
            actualState = 1;

            Touch touch = Input.GetTouch(0);
            if (!firstTouch)
            {
                rawPosition = touch.position;
                firstTouch = true;
            }
           
            Vector3 touchPosition = new Vector3(touch.position.x, touch.position.y, 0);
            Vector3 resta = new Vector3((touchPosition.x - rawPosition.x) * -moveReductionFactor, (touchPosition.y - rawPosition.y) * -moveReductionFactor, 0);
            Vector3 newPosition = cameraToMove.transform.position + resta ;
            
            cameraToMove.transform.position = CameraLimits(newPosition);

            rawPosition = touchPosition;
        }
        else if(Input.touchCount == 2 && (actualState == 0 || actualState == 2))
        {
            actualState = 2;

            if (!firstTouch)
            {
                rawDistance = Mathf.Sqrt(Mathf.Pow(Input.GetTouch(0).position.x - Input.GetTouch(1).position.x, 2) + Mathf.Pow(Input.GetTouch(0).position.y - Input.GetTouch(1).position.y, 2));
                firstTouch = true;
            }

            float distance = Mathf.Sqrt(Mathf.Pow(Input.GetTouch(0).position.x - Input.GetTouch(1).position.x, 2) + Mathf.Pow(Input.GetTouch(0).position.y - Input.GetTouch(1).position.y, 2));
            float resta = distance - rawDistance;
            float restaY = 0;
            
            if  (cameraToMove.transform.eulerAngles.x >= 30)
            {
                restaY = resta * -0.58f;
            }

            Vector3 newPosition = new Vector3(cameraToMove.transform.position.x, cameraToMove.transform.position.y + restaY * zoomReductionFactor, cameraToMove.transform.position.z + resta * zoomReductionFactor);
            cameraToMove.transform.position = CameraLimits(newPosition);

            rawDistance = distance;
        }
        else
        {
            firstTouch = false;
            actualState = 0;
        }
    }

    private Vector3 CameraLimits(Vector3 newPosition)
    {
        Vector3 finalPosition = newPosition;
        if(finalPosition.x < minX) { finalPosition.x = minX; }
        if (finalPosition.x > maxX) { finalPosition.x = maxX; }
        if (finalPosition.y < minY) { finalPosition.y = minY; }
        if (finalPosition.y > maxY) { finalPosition.y = maxY; }
        if (finalPosition.z < minZ) { finalPosition.z = minZ; }
        if (finalPosition.z > maxZ) { finalPosition.z = maxZ; }
        return finalPosition;
    }

    private float FindMoveReductionFactor()
    {
        float MRF;
        switch (id)
        {
            case 0:
                MRF = 0.003f + (-0.0015f * (cameraToMove.transform.position.z - minZ) / 3.64f);
                break;
            case 1:
                MRF = 0.04f + (-0.025f * (cameraToMove.transform.position.z - minZ) / 72.5f);
                break;
            case 2:
                MRF = 0.01f + (-0.007f * (cameraToMove.transform.position.z - minZ) / 14f);
                break;
            default:
                MRF = 0;
                break;

        }
        return MRF;
    }

}



