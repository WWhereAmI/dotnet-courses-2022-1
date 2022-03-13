using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal interface ISeries
    {
        /// <summary>
        /// Get current element 
        /// </summary>
        /// <returns></returns>
        double GetCurrent();

        /// <summary>
        /// Increases the element index 
        /// </summary>
        /// <returns>True if operation complete without any issues, otherwise fasle</returns>
        bool MoveNext();

        /// <summary>
        /// Reterns the element index to begin
        /// </summary>
        void Reset();
    }
}
