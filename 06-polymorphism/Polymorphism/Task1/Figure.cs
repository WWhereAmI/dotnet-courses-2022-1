namespace Task1
{
    abstract internal class Figure
    {
        /// <summary>
        /// Draws a figure
        /// </summary>
        public abstract void Draw();

        /// <summary>
        /// Type of the figure
        /// </summary>
        public abstract string FigureType { get; }
    }
}
