using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ming
{
    public class StructAssignment : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Point point1 = new Point(1, 1);
            Point point2 = point1;

            point2.x = 2;
            point2.y = 2;

            Debug.Log(point1.GetPoint());
            Debug.Log(point2.GetPoint());

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
