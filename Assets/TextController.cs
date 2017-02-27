using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {capsule_0, capsule_1, capsule_space_0, capsule_space_1, capsule_space_2, screen_0, screen_1, screen_space_0, screen_space_1, screen_space_2, button_0, button_1, button_2,
						button_space_0, button_space_1, button_space_2, button_space_3, button_space_4, button_space_5, hatch_0, hatch_1, hatch_2, hatch_3, hatch_space_0, hatch_space_1, hatch_space_2, hatch_space_3, hatch_space_4,
		knob_0, knob_1, knob_2, knob_3, knob_space_0, knob_space_1, knob_space_2, knob_space_3, knob_space_4, knob_space_5, launch, floor_0, floor_1, moonwalk};
	private States myState;
			
	// Use this for initialization
	void Start ()
	{
		myState = States.capsule_0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);
		
		if (myState == States.capsule_0)			{capsule_0();}
		else if (myState == States.capsule_1)		{capsule_1();}
		else if (myState == States.capsule_space_0)	{capsule_space_0();}
		else if (myState == States.capsule_space_1)	{capsule_space_1();}
		else if (myState == States.capsule_space_2)	{capsule_space_2();}
		else if (myState == States.screen_0)		{screen_0();}
		else if (myState == States.screen_1)		{screen_1();}
		else if (myState == States.screen_space_0)	{screen_space_0();}
		else if (myState == States.screen_space_1)	{screen_space_1();}
		else if (myState == States.screen_space_2)	{screen_space_2();}
		else if (myState == States.button_0)		{button_0();}
		else if (myState == States.button_1)		{button_1();}
		else if (myState == States.button_2)		{button_2();}
		else if (myState == States.button_space_0)	{button_space_0();}
		else if (myState == States.button_space_1)	{button_space_1();}
		else if (myState == States.button_space_2)	{button_space_2();}
		else if (myState == States.button_space_3)	{button_space_3();}
		else if (myState == States.button_space_4)	{button_space_4();}
		else if (myState == States.button_space_5)	{button_space_5();}
		else if (myState == States.hatch_0)			{hatch_0();}
		else if (myState == States.hatch_1)			{hatch_1();}
		else if (myState == States.hatch_2)			{hatch_2();}
		else if (myState == States.hatch_3)			{hatch_3();}
		else if (myState == States.hatch_space_0)	{hatch_space_0();}
		else if (myState == States.hatch_space_1)	{hatch_space_1();}
		else if (myState == States.hatch_space_2)	{hatch_space_2();}
		else if (myState == States.hatch_space_3)	{hatch_space_3();}
		else if (myState == States.hatch_space_4)	{hatch_space_4();}
		else if (myState == States.knob_0)			{knob_0();}
		else if (myState == States.knob_1)			{knob_1();}
		else if (myState == States.knob_2)			{knob_2();}
		else if (myState == States.knob_3)			{knob_3();}
		else if (myState == States.knob_space_0)	{knob_space_0();}
		else if (myState == States.knob_space_1)	{knob_space_1();}
		else if (myState == States.knob_space_2)	{knob_space_2();}
		else if (myState == States.knob_space_3)	{knob_space_3();}
		else if (myState == States.knob_space_4)	{knob_space_4();}
		else if (myState == States.knob_space_5)	{knob_space_5();}
		else if (myState == States.launch)			{launch();}
		else if (myState == States.floor_0)			{floor_0();}
		else if (myState == States.floor_1)			{floor_1();}
		else if (myState == States.moonwalk)		{moonwalk();}
		
	}
	
	#region State Handler Methods
	void capsule_0 ()
	{
		text.text = "In the cool dawn mist, astropooch Wendy sits atop her massive Saturn VI rocket.  Today marks the culmination of President Trump's " +
					"historic plan to make America great again by putting a dog on the moon.\n\n" +
					"The countdown is complete and it is time to launch.  Inside the capsule you see the flickering screen of the flight computer and " +
					"a large button just below it.  To your left sunlight pours through the open hatch.  To your right is the cabin pressure knob.\n\n" +
					"Press S to view the computer Screen, press B to view the Button, press H to view the Hatch, press K to view the Knob.";
					
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.screen_0;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.button_0;}
		else if (Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_0;}
		else if (Input.GetKeyDown(KeyCode.K))	{myState = States.knob_0;}
	}
	
	void capsule_1 ()
	{
		text.text = "In the cool dawn mist astropooch, Wendy sits atop her massive Saturn VI rocket.  Today marks the culmination of President Trump's " +
					"historic plan to make America great again by putting a dog on the moon.\n\n" +
					"The countdown is complete and it is time to launch.  Inside the capsule you see the flickering screen of the flight computer and " +
					"a large blinking button just below it.  To your left is the tightly sealed hatch. To your right is the cabin pressure knob.\n\n" +
					"Press S to view the computer Screen, press B to view the Button, press H to view the Hatch, press K to view the Knob";
		
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.screen_1;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.button_2;}
		else if (Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_2;}
		else if (Input.GetKeyDown(KeyCode.K))	{myState = States.knob_2;}
	}
	
	void capsule_space_0 ()
	{
		text.text = "Sitting in the gentle lunar gravity you glance around the inside of your capsule.  The flickering screen of the flight computer sits " +
					"to your front with a large button just below it.  To your left is the tightly sealed hatch.  To your right is the cabin " +
					"pressure knob.  You are pretty sure you heard something rolling around under your seat while landing.\n\n" +
					"Time to show off your moon walk!\n\n" +
					"Press S to view the computer Screen, press B to view the Button, press H to view the Hatch, press K to view the Knob, press F to check the Floor under your seat.";
		
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.screen_space_0;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.button_space_0;}
		else if (Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_space_0;}
		else if (Input.GetKeyDown(KeyCode.K))	{myState = States.knob_space_0;}
		else if (Input.GetKeyDown(KeyCode.F))	{myState = States.floor_0;}
	}
	
	void capsule_space_1 ()
	{
		text.text = "Sitting in the gentle lunar gravity you glance around the inside of your capsule.  The flickering screen of the flight computer sits " +
					"to your front with a large button just below it.  To your left is the tightly sealed hatch.  To your right is the cabin " +
					"pressure knob.\n\n" +
					"Time to show off your moon walk!\n\n" +
					"Press S to view the computer Screen, press B to view the Button, press H to view the Hatch, press K to view the Knob.";
		
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.screen_space_1;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.button_space_2;}
		else if (Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_space_2;}
		else if (Input.GetKeyDown(KeyCode.K))	{myState = States.knob_space_2;}
	}
	
	void capsule_space_2 ()
	{
		text.text = "Sitting in the gentle lunar gravity you glance around the inside of your capsule.  The flickering screen of the flight computer sits " +
					"to your front with a large button just below it.  To your left is the tightly sealed hatch.  To your right is the cabin " +
					"pressure knob.\n\n" +
					"Time to show off your moon walk!\n\n" +
					"Press S to view the computer Screen, press B to view the Button, press H to view the Hatch, press K to view the Knob.";
		
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.screen_space_2;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.button_space_4;}
		else if (Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_space_4;}
		else if (Input.GetKeyDown(KeyCode.K))	{myState = States.knob_space_5;}
	}
	
	void screen_0 ()
	{
		text.text = "A small, flickering black screen displays green text:\n\n" +
					"Cabin Pressure: 	100%\n" +
					"Hatch:				\t\tOpen\n" +
					"Launch Status:		Not Ready\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_0;}
	}
	
	void screen_1 ()
	{
		text.text = "A small, flickering black screen displays green text:\n\n" +
					"Cabin Pressure: 	100%\n" +
					"Hatch:				\t\tClosed\n" +
					"Launch Status:		Ready\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_1;}
	}
	
	void screen_space_0 ()
	{
		text.text = "A small, flickering black screen displays green text:\n\n" +
					"Cabin Pressure: 	100%\n" +
					"Hatch:				\t\tClosed\n" +
					"Launch Status:		Landed\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_0;}
	}
	
	void screen_space_1 ()
	{
		text.text = "A small, flickering black screen displays green text:\n\n" +
					"Cabin Pressure: 	100%\n" +
					"Hatch:				\t\tClosed\n" +
					"Launch Status:		Landed\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_1;}
	}
	
	void screen_space_2 ()
	{
		text.text = "A small, flickering black screen displays green text:\n\n" +
					"Cabin Pressure: 	0%\n" +
					"Hatch:				\t\tClosed\n" +
					"Launch Status:		Landed\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_2;}
	}
	
	void button_0 ()
	{
		text.text = "A large monochrome button sits just below the monitor.\n\n" +
					"Press B to push Button, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.B))	{myState = States.button_1;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_0;}
	}
	
	void button_1 ()
	{
		text.text = "A large monochrome button sits just below the monitor.\n\n" +
					"You press your big wet nose against the button.  It flashes rapidly for a few seconds as the flight computer emits an " +
					"angry beep.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_0;}
	}
	
	void button_2 ()
	{
		text.text = "A large monochrome button blinks slowly just below the monitor.\n\n" +
					"Press B to push Button, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.B))	{myState = States.launch;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_1;}
	}
	
	void button_space_0 ()
	{
		text.text = "A large monochrome button sits unlit just below the monitor.\n\n" +
					"Press B to push Button, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.B))	{myState = States.button_space_1;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_0;}
	}
	
	void button_space_1 ()
	{
		text.text = "A large monochrome button sits just below the monitor.\n\n" +
					"You press your big wet nose against the button.  It flashes rapidly for a few seconds as the flight computer emits an " +
					"angry beep.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_0;}
	}
	
	void button_space_2 ()
	{
		text.text = "A large monochrome button sits unlit just below the monitor.\n\n" +
					"Press B to push Button, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.B))	{myState = States.button_space_3;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_1;}
	}
	
	void button_space_3 ()
	{
		text.text = "A large monochrome button sits just below the monitor.\n\n" +
					"You press your big wet nose against the button.  It flashes rapidly for a few seconds as the flight computer emits an " +
					"angry beep.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_1;}
	}
	
	void button_space_4 ()
	{
		text.text = "A large monochrome button sits unlit just below the monitor.\n\n" +
					"Press B to push Button, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.B))	{myState = States.button_space_5;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_2;}
	}
	
	void button_space_5 ()
	{
		text.text = "A large monochrome button sits just below the monitor.\n\n" +
					"You press your big wet nose against the button.  It flashes rapidly for a few seconds as the flight computer emits an " +
					"angry beep.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_2;}
	}
	
	void hatch_0 ()
	{
		text.text = "You look out the open hatch and howl excitedly to your adoring fans. It would probably be a good idea to close this.\n\n" +
					"Press H to close Hatch, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_1;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_0;}
	}
	
	void hatch_1 ()
	{
		text.text = "You grab the door lever with your teeth and seal the hatch.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_1;}
	}
	
	void hatch_2 ()
	{
		text.text = "The breath from your nose fogs the glass as you peer out the hatch window at the crowd below.\n\n" +
					"Press H to open Hatch, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_3;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_1;}
	}
	
	void hatch_3 ()
	{
		text.text = "You grab the door lever with your teeth and open the hatch.\n\n" +
					"Press R to return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_0;}
	}
	
	void hatch_space_0 ()
	{
		text.text = "Outside the window you see the rocky grey surface of the moon and the  \tcold vacuum of space.\n\n" +
					"Press H to open Hatch, R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_space_1;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_0;}
	}
	
	void hatch_space_1 ()
	{
		text.text = "You pull at the door lever with your teeth but the hatch wont budge!\n\n" +
					"Press R to return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_0;}
	}
	
	void hatch_space_2 ()
	{
		text.text = "Outside the window you see the rocky grey surface of the moon and the cold vacuum of space.\n\n" +
					"Press H to open Hatch, R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.H))	{myState = States.hatch_space_3;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_1;}
	}
	
	void hatch_space_3 ()
	{
		text.text = "You pull at the door lever with your teeth but the hatch wont budge!\n\n" +
					"Press R to return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_1;}
	}
	
	void hatch_space_4 ()
	{
		text.text = "Outside the window you see the rocky grey surface of the moon and the cold vacuum of space.\n\n" +
					"Press H to open Hatch, R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.H))	{myState = States.moonwalk;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_2;}
	}
	
	void knob_0 ()
	{
		text.text = "A metal knob controlling the cabin pressure.\n\n" +
					"Press K to turn Knob, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.K))	{myState = States.knob_1;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_0;}
	}
	
	void knob_1 ()
	{
		text.text = "You clumsily turn the knob with your paws but nothing happens.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_0;}
	}
	
	void knob_2 ()
	{
		text.text = "A metal knob controlling the cabin pressure.\n\n" +
					"Press K to turn Knob, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.K))	{myState = States.knob_3;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_1;}
	}
	
	void knob_3 ()
	{
		text.text = "You clumsily turn the knob with your paws but nothing happens.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_1;}
	}
	
	void knob_space_0 ()
	{
		text.text = "A metal knob controlling the cabin pressure.\n\n" +
					"Press K to turn Knob, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.K))	{myState = States.knob_space_1;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_0;}
	}
	
	void knob_space_1 ()
	{
		text.text = "As you turn the knob with your paws you begin to feel lightheaded.  Gasping for air you manage to turn the knob back before you pass out.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_0;}
	}
	
	void knob_space_2 ()
	{
		text.text = "A metal knob controlling the cabin pressure.\n\n" +
					"Press K to turn Knob, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.K))	{myState = States.knob_space_3;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_1;}
	}
	
	void knob_space_3 ()
	{
		text.text = "Making sure your helmet is securely fastened you turn the knob, your spacesuit ballooning slightly as the cabin pressure drops.\n\n" +
					"Press K to turn Knob, press R to Return to capsule.";
					
		if 		(Input.GetKeyDown(KeyCode.K))	{myState = States.knob_space_4;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_2;}
	}
	
	void knob_space_4 ()
	{
		text.text = "Turning the knob again a loud hiss fills the cabin as the interior air pressure builds.\n\n" +
					"Press K to turn Knob, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.K))	{myState = States.knob_space_3;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_1;}
	}
	
	void knob_space_5 ()
	{
		text.text = "A metal knob controlling the cabin pressure.\n\n" +
					"Press K to turn Knob, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.K))	{myState = States.knob_space_4;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_2;}
	}
	
	void launch ()
	{
		text.text = "You press your big wet nose against the button and the cabin begins shaking dramatically as the rocket engine ignites. " +
					"Your tounge flops to one side, stretching cartoonishly and drooling against your headrest as you ascend into orbit.\n\n" +
					"Your ears float weightlessly in zero gravity while the autopilot flies the craft to your destination.  (What do dogs " +
					"know about orbital mechanics after all?) Capture and landing are handled flawlessly and before you know it you are " +
					"staring out the window at the surface of the moon.\n\n" +
					"Press SPACE to continue.";
		
		if 		(Input.GetKeyDown(KeyCode.Space))	{myState = States.capsule_space_0;}
	}
	
	void floor_0 ()
	{
		text.text = "You peek under your seat and find the spare helmet for your space suit rolling around underneath.  Good thing too since you " +
					"already lost the first one!\n\n" +
					"Press W to Wear helmet, press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.floor_1;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_0;}
	}
	
	void floor_1 ()
	{
		text.text = "You stick your snout through the helmet collar and wiggle it onto you head.  A momentary struggle and it clicks into place, " +
					"the mechanical whir of your suit life support system echoing softly inside.\n\n" +
					"Press R to Return to capsule.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_space_1;}
	}
	
	void moonwalk ()
	{
		text.text = "With the cabin pressure gone the hatch swings open to reveal the stark lunar landscape. The ship appears to have landed on " +
					"the lip on a large crater.  You take a deep breath and descend down the ladder into history.\n\n" +
					"Wendy First Dog on the Moon! - New York Times\n" +
					"Dog on Moon, Cats Unimpressed - Wall Street Journal\n" +
					"Pooch Moon Landing Faked! - National Enquirer\n\n" +
					"You Win!  Press R to Restart.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.capsule_0;}
	}
	#endregion
}
