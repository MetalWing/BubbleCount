using UnityEngine;
using System.Collections;

public class ShootBallRaycast : MonoBehaviour {

	//int totalBalls = X;
	//balls next, cur;

	// Use this for initialization
	void Start () {

		//generate two balls at the bottom
		//get cannon coordinates;
		//next = instantiate next ball and place it beside the cannon;
		//cur = instatiate current ball and place it in front of cannon;
	
	}
	
	// Update is called once per frame
	void Update () {

		/**algorithm:

		get information about what was hit with the raycast
		//make sure that coord are either both worldCoord or screenCoord
		RaycastHit2D hit = Physics2D.Raycast(transform.position, directionOfMouse);

		if (totalBall == 0){
			end game;
		}

		if(mouseclick && totalBall > 0){
			shoot cur;
			cur change name to X (we want to maintain current = in front of cannon, and not ball in ceiling)
			if (hit == cannonball || hit == ceiling){
				X doesnt' bounce;
			} 
			else {
 				X bounce off wall;
			}
			swap();
			totalBalls = totalBalls - 1;
		} 

		end algorithm **/
	
	}

	/**
	 private void swap(){

		cur = next (takes place in front of cannon);
		next = instantiate next to cannon;		

	}

	end swap **/
}
