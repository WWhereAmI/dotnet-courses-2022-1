namespace Task4
{
    internal interface ISubjectActions
    {
        Coordinates Position { get; set; }

        /// <summary>
        /// Deal damage to Subject
        /// </summary>
        /// <param name="subject"></param>
        void Hit(ISubjectCharacteristics subject);

        /// <summary>
        /// Subject move algorithm 
        /// </summary>
        void Move();
    }
}
