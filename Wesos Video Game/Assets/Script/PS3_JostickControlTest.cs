using UnityEngine;
using System.Collections;

public class PS3_JostickControlTest : MonoBehaviour 
{
	public Vector2 joystick_R = Vector2.zero;
	public Vector2 joystick_L = Vector2.zero;
	public Vector2 cross_arrows = Vector2.zero;

	public Vector2 R2_L2;

	// Use this for initialization
	void Start () 
	{
		joystick_R = Vector2.zero;
		joystick_L = Vector2.zero;
		cross_arrows = Vector2.zero;

		R2_L2 = Vector2.zero;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		joystick_R.x = Input.GetAxis("R_Joystick_H");
		joystick_R.y = Input.GetAxis("R_Joystick_V");

		joystick_L.x = Input.GetAxis("L_Joystick_H");
		joystick_L.y = Input.GetAxis("L_Joystick_V");

		cross_arrows.x = Input.GetAxisRaw("Arrows_H");
		cross_arrows.y = Input.GetAxisRaw("Arrows_V");

		R2_L2.x = Input.GetAxis("R2");
		R2_L2.y = Input.GetAxis("L2");

	
	}
}
