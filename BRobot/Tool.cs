using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRobot
{
    /// <summary>
    /// Represents a tool object that can be attached to the end effector of the robot
    /// </summary>
    public class Tool
    {
        public Point CenterPoint;
        public Rotation Orientation;

        public bool RobotHold;

        public double Mass;
        public Point CenterOfGravity;

        // Coordinate system of inertial moment, and moment components in kgm^2
        public Rotation AxesOfMoment;
        public double InertiaX;
        public double InertiaY;
        public double InertiaZ;

        public Tool()
        {
            RobotHold = true;
        }
    }
}
