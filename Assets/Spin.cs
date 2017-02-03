using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    private bool spinning;

	void Update () {
		if (spinning)
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * 200f));
        }
	}

    public void SpinObject()
    {
        if (!spinning)
        {
            spinning = true;
        }
        else if (spinning)
        {
            spinning = false;
        }
    }
}
