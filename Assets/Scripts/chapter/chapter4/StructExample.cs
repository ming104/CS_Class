using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ming
{
    public class StructExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Point point = new Point(1, 1);
            Debug.Log(point.GetPoint());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string GetPoint()
        {
            return $"({x}, {y})";
        }
    }
}

