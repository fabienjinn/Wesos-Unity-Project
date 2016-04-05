using UnityEngine;
using System.Collections;

public class PS3_JoystickButtonTest : MonoBehaviour 
{
	/*
	 * Pour fonctionner , MotioninJoy actif + manette XBOX 360 (Si Manette PS3 passez en mode emulation XBOX 360)
	 * Ensuite dans Unity , configurer les Inputs 
	 *
	 *Cross = joystick button 0
	 */



	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Press();
	
	}

	void Press()
	{
		if(Input.GetButtonUp("Cross"))
		{
			Debug.Log (" CROSS Input received !");
		}
		else if(Input.GetButtonUp("Circle"))
		{
			Debug.Log (" CIRCLE Input received !");
		}
		else if(Input.GetButtonUp("Triangle"))
		{
			Debug.Log (" TRIANGLE Input received !");
		}
		else if(Input.GetButtonUp("Square"))
		{
			Debug.Log (" SQUARE Input received !");
		}
		else if(Input.GetButtonUp("Start"))
		{
			Debug.Log (" START Input received !");
		}
		else if(Input.GetButtonUp("Select"))
		{
			Debug.Log (" SELECT Input received !");
		}
		else if(Input.GetButtonUp("R1"))
		{
			Debug.Log (" R1 Input received !");
		}
		else if(Input.GetButtonUp("L1"))
		{
			Debug.Log (" L1 Input received !");
		}
		else if(Input.GetButtonUp("R3"))
		{
			Debug.Log (" R3 Input received !");
		}
		else if(Input.GetButtonUp("L3"))
		{
			Debug.Log (" L3 Input received !");
		}

		else
		{
			return;
		}
	}
}
