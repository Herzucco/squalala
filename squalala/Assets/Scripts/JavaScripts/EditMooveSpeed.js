#pragma strict

var motor : CharacterMotor;
var speed : float;
var groundAcc : float;
var airAcc : float;
var originalSpeed : float;
var originalGroundAcc : float;
var originalAirAcc : float;

function Start () {

	motor = GetComponent(CharacterMotor);
}

function Update () {

}

public function boostSpeed() {
	motor.movement.maxForwardSpeed = speed;
	motor.movement.maxSidewaysSpeed = speed;
	motor.movement.maxBackwardsSpeed = speed;
	motor.movement.maxGroundAcceleration = groundAcc;
	motor.movement.maxAirAcceleration = airAcc;
}

public function resetSpeed() {
	motor.movement.maxForwardSpeed = originalSpeed;
	motor.movement.maxSidewaysSpeed = originalSpeed;
	motor.movement.maxBackwardsSpeed = originalSpeed;
	motor.movement.maxGroundAcceleration = originalSpeed;
	motor.movement.maxAirAcceleration = originalAirAcc;
}