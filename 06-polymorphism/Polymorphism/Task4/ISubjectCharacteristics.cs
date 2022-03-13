namespace Task4
{
    internal interface ISubjectCharacteristics
    {
        /// <summary>
        /// Subject Health points 
        /// </summary>
        double HP { get; set; }

        /// <summary>
        /// Subject damage points 
        /// </summary>
        double Damage { get; set; }

        /// <summary>
        /// Subject resist to damage 
        /// </summary>
        double ShieldDefence { get; set; }

        /// <summary>
        /// Subject movement speed
        /// </summary>
        double Speed { get; set; }

    }
}
