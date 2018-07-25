using UnityEngine;

public class CamerController : MonoBehaviour {

    private bool doMovement = true;

    public float panSpeed = 30f;
    public float panBorderThickness = 10f;

    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float minX = 80f;

    //private string message = "Movement disabled";

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            doMovement = !doMovement;
           // OnGUI();
        }

        if (!doMovement)
            return;
        
        // key controlling
        if (Input.GetKey("up") ||  Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }

        if(Input.GetKey("down") ||  Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }

        if(Input.GetKey("right") ||  Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }

        if(Input.GetKey("left") ||  Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        // scroll wheel
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;

        transform.position = pos;
    }

    /*
    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), message);
    }
    */
}
