using UnityEngine;
using System.Collections.Generic;


public static class Extensions
{
    public static Vector2 ToVector2 (this Vector3 input)
    {
        return new Vector2(input.x, input.y);
    }
}


public struct CornerData
{
    public Vector3 corner { get; }
    public float angle { get; }


    public CornerData(Vector3 corner, float angle)
    {
        this.corner = corner;
        this.angle = angle;
    }
}


[ExecuteInEditMode]
public class PolygonDrawer : MonoBehaviour
{
    [SerializeField] int sides = 4;
    [SerializeField] float radius = 10;


    List<CornerData> corners = new List<CornerData>();


    private void Update() {
        Vector2 previsouCorner = transform.position.ToVector2() + new Vector2(radius, 0);

        for (int i = 0; i <= sides; i++)
        {
            float newCornerAngle = 2f * Mathf.PI / (float)sides * i;

            Vector3 currentCorner = new Vector3(
                Mathf.Cos(newCornerAngle) * radius,
                Mathf.Sin(newCornerAngle) * radius,
                0) + transform.position;

            Debug.DrawLine(currentCorner, previsouCorner, Color.red);


            corners.Add(new CornerData(currentCorner, newCornerAngle));

            previsouCorner = currentCorner;
        }
    }

    private void OnDrawGizmos()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.black;
        UnityEditor.Handles.color = Color.blue;

        foreach (var any in corners)
        {

            UnityEditor.Handles.Label(any.corner,
                (any.angle * Mathf.Rad2Deg).ToString(), style);
        }
    }






}
