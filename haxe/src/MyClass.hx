package ;
import unityEngine.MonoBehaviour;
import unityEngine.Time;
import unityEngine.Vector3;
import unityEngine.GameObject;
using UnityHelper;

class MyClass extends MonoBehaviour {
    public var target:GameObject;
    public var speed:Single;
    private function Start():Void {

    }
    private function Update():Void {
	    trace("hahhahha");

        if (speed == 0) return;
        getTransform().position = Vector3.MoveTowards(getTransform().position, target.transform.position, Time.deltaTime * speed);
    }
}