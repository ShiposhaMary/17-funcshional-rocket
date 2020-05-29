using System;
 
namespace func_rocket
{
    public class My_ControlTask
    {
        public static double DirectionAngle;
 
        public static Turn ControlRocket(Rocket rocket, Vector target)
        {
            var vectorToTarget = new Vector(target.X - rocket.Location.X, target.Y - rocket.Location.Y);
 
            if (Math.Abs(vectorToTarget.Angle - rocket.Direction) < 0.5|| Math.Abs(vectorToTarget.Angle - rocket.Velocity.Angle) < 0.5)
            {
                DirectionAngle = (vectorToTarget.Angle - rocket.Direction + vectorToTarget.Angle - rocket.Velocity.Angle) /2;
            }
            else
            {
                DirectionAngle = vectorToTarget.Angle - rocket.Direction;
            }
 
            if (DirectionAngle < 0)return Turn.Left;
            return DirectionAngle > 0 ? Turn.Right : Turn.None;
        }
    }
}