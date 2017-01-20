About
--------------------------------------------------------------------------------------

	TouchIt (c) ITEKUBE - http://www.itekube.com

	TouchIt is a native plugins for Windows Touch (Windows 7 & 8(.1) & 10 32/64)
	TouchIt provide gestures recognition (pan, pinch, rotation) up to 10 fingers

Contact
--------------------------------------------------------------------------------------
touchit@itekube.com


Features
--------------------------------------------------------------------------------------
Native Windows Touch support (7 & 8 & 8.1 & 10) 32/64 bits


Pre-requisite
--------------------------------------------------------------------------------------
Visual Studio Redistributable Package 2013
http://www.microsoft.com/en-us/download/details.aspx?id=40784


Installation
--------------------------------------------------------------------------------------
Add IT3TouchIT prefab to your scene or add TouchIT4Unity.cs to any object.

TouchIT do not work in editor. You need to build your scene.

Utilisation
--------------------------------------------------------------------------------------
Add an event for each gesture your want
		TouchIt4Unity.IT3Drag += onDrag;
		TouchIt4Unity.IT3Pinch += onPinch;
		TouchIt4Unity.IT3Rotation += onRotation;
		
void onDrag(DragGesture gesture) {
}
void onPinch(PinchGesture gesture) {
}
void onRotation(TwistGesture gesture) {
}

You can use standard Input.Touch or any Input properties ... almost :)

Documentation
--------------------------------------------------------------------------------------
http://www.itekube.com/TouchIT/
--------------------------------------------------------------------------------------


Legal Stuff / Licensing:
--------------------------------------------------------------------------------------
TouchIT is licensed per-seat, as with all other editor extensions, according to Unity's EULA.
This means that in order for a team to use TouchIT, everyone who want to be able to use it, needs their own license.
If you finish and release a product in Unity, using TouchIT, I would appreciate a mention of TouchIT in the credits :)