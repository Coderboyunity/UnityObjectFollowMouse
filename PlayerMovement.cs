using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Adjust this speed to control the constant speed of the object
    public float moveSpeed = 5f;

    void Update()
    {
       
        Vector3 mousePosition = Input.mousePosition;
         mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));
         transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);

    }
}
