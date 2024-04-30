using math_phisical_lib.Entity;

namespace graph_view_mhs.models;

public class Pendulum
{

    /// <summary>
    /// Calculate the angular velocity, which is the vector measure of the variation rate
    /// </summary>
    /// <param name="period">Period in which the movement occurs</param>
    /// <returns> Returns the angular velocity</returns>
    public static double CalculateAngularVelocity(double period)
    {
        return (2 * Math.PI) / period;
    }

    /// <summary>
    /// Calculates the period of a pendulum based on the length of its wire.
    /// </summary>
    /// <param name="wireLength">The length of the pendulum's wire in meters.</param>
    /// <returns>The period of the pendulum in seconds.</returns>
    public static double CalculatePeriod(double wireLength)
    {
        return 2 * Math.PI * Math.Sqrt(wireLength / Utils.GravityAcceleration);
    }

    /// <summary>
    /// Calculates the frequency of a periodic motion based on its period.
    /// </summary>
    /// <param name="period">The period of the motion in seconds.</param>
    /// <returns>The frequency of the motion in Hertz (cycles per second).</returns>
    public static double CalculateFrequency(double period)
    {
        return 1 / period;
    }


    /// <summary>
    /// Calculates the maximum amplitude of a pendulum's motion based on its initial displacement.
    /// </summary>
    /// <param name="initialDisplacement">The initial angular displacement of the pendulum in radians.</param>
    /// <returns>The maximum amplitude of the pendulum's motion in radians.</returns>
    public static double CalculateMaxAmplitude(double initialDisplacement)
    {
        // The maximum amplitude of a simple pendulum is equal to its initial displacement.
        return Math.Abs(initialDisplacement);
    }

    /// <summary>
    /// Calculates the potential energy of a pendulum at a given angular displacement.
    /// </summary>
    /// <param name="angularDisplacement">The angular displacement of the pendulum in radians.</param>
    /// <param name="length">The length of the pendulum's wire in meters.</param>
    /// <param name="mass">The mass of the pendulum's bob in kilograms.</param>
    /// <param name="gravity">The acceleration due to gravity in m/s².</param>
    /// <returns>The potential energy of the pendulum in joules.</returns>
    public static double CalculatePotentialEnergy(double angularDisplacement, double length, double mass, double gravity)
    {
        // Potential energy (PE) of a pendulum is given by PE = mgh, where h is the vertical displacement.
        double verticalDisplacement = length * (1 - Math.Cos(angularDisplacement));
        double potentialEnergy = mass * gravity * verticalDisplacement;
        return potentialEnergy;
    }

    /// <summary>
    /// Calculates the kinetic energy of a pendulum at a given angular displacement.
    /// </summary>
    /// <param name="angularDisplacement">The angular displacement of the pendulum in radians.</param>
    /// <param name="length">The length of the pendulum's wire in meters.</param>
    /// <param name="mass">The mass of the pendulum's bob in kilograms.</param>
    /// <param name="gravity">The acceleration due to gravity in m/s².</param>
    /// <returns>The kinetic energy of the pendulum in joules.</returns>
    public static double CalculateKineticEnergy(double angularDisplacement, double length, double mass, double gravity)
    {
        // Kinetic energy (KE) of a pendulum is given by KE = (1/2) * m * v^2, where v is the linear velocity.
        double linearVelocity = length * Math.Abs(angularDisplacement); // Assuming small angles for simplicity.
        double kineticEnergy = 0.5 * mass * Math.Pow(linearVelocity, 2);
        return kineticEnergy;
    }

    /// <summary>
    /// Calculates the angular velocity of a pendulum at a given angular displacement.
    /// </summary>
    /// <param name="angularDisplacement">The angular displacement of the pendulum in radians.</param>
    /// <param name="length">The length of the pendulum's wire in meters.</param>
    /// <param name="gravity">The acceleration due to gravity in m/s².</param>
    /// <returns>The angular velocity of the pendulum in radians per second.</returns>
    public static double CalculateAngularVelocity(double angularDisplacement, double length, double gravity)
    {
        // Angular velocity (ω) of a pendulum is given by ω = sqrt(g / L) * sin(θ), where L is the length of the wire.
        double angularVelocity = Math.Sqrt(gravity / length) * Math.Sin(angularDisplacement);
        return angularVelocity;
    }

    /// <summary>
    /// Calculates the restoring force exerted by a pendulum at a given angular displacement.
    /// </summary>
    /// <param name="angularDisplacement">The angular displacement of the pendulum in radians.</param>
    /// <param name="length">The length of the pendulum's wire in meters.</param>
    /// <param name="mass">The mass of the pendulum's bob in kilograms.</param>
    /// <param name="gravity">The acceleration due to gravity in m/s².</param>
    /// <returns>The restoring force exerted by the pendulum in newtons.</returns>
    public static double CalculateRestoringForce(double angularDisplacement, double length, double mass, double gravity)
    {
        // The restoring force (F) of a pendulum is given by F = -mg * sin(θ), where θ is the angular displacement.
        double restoringForce = -mass * gravity * Math.Sin(angularDisplacement);
        return restoringForce;
    }


}
