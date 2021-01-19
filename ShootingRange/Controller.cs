using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange {
	class Controller {
		private static byte MAX_SPEED = 100;
		private static float CENTER_VOLTAGE = 2.2f;
		//CAP AT 70%
		private static float MIN_SPEED_VOLTAGE = 0.925f + 0.5f;//0.925f;
		private static float MAX_SPEED_VOLTAGE = 3.992f - 0.75f;//3.992f;
		private static float MIN_SPEED_VOLTAGE_CENTERED = CENTER_VOLTAGE - MIN_SPEED_VOLTAGE;
		private static float MAX_SPEED_VOLTAGE_CENTERED = MAX_SPEED_VOLTAGE - CENTER_VOLTAGE;


		private static byte distance;
		private static byte initDist;
		private static byte targetDistance;
		private static byte speed;
		private static bool stuck;

		public static void Update() {
			distance = NIController.GetRotations();
			if (NIController.IsStuck()) stuck = true;

			NIController.SetMotorControl(CalculateVrefVoltage());
		}

		public static void SetTargetDistance(byte distance) {
			targetDistance = distance;
		}

		public static void SetSpeed(byte speed) {
			Controller.speed = speed;
		}

		public static sbyte GetDirection() {
			byte dist = GetDistance();
			if (dist == targetDistance) return 0;		//If distance is at target, then don't move
			else if (dist < targetDistance) return 1;	//If distance is less than target, then move forward (1)
			else return -1;									//If distance is greater than target, then move backwards (-1)
		}

		public static byte GetDistance() {
			return (byte)((distance - initDist) & 0x7f);
		}

		public static bool IsStuck() {
			return stuck;
		}

		public static void SetStuck() {
			stuck = true;
		}

		public static void ResetStuck() {
			stuck = false;
		}

		private static float CalculateVrefVoltage() {
			if (stuck) return CENTER_VOLTAGE; //If stuck, then stop motor

			//direction * (speed in %) * (max voltage / 2) + (max voltage / 2)
			if (GetDirection() > 0) return (float)GetDirection() * speed / MAX_SPEED * MAX_SPEED_VOLTAGE_CENTERED + CENTER_VOLTAGE;
			if (GetDirection() < 0) return (float)GetDirection() * speed / MAX_SPEED * MIN_SPEED_VOLTAGE_CENTERED + CENTER_VOLTAGE;
			return CENTER_VOLTAGE;
		}

		public static void Initialize() {
			NIController.InitializeInstrument();

			initDist = NIController.GetRotations();
		}

		public static void Dispose() {
			NIController.SetMotorControl(MAX_SPEED_VOLTAGE);
		}
	}
}
