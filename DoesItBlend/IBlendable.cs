﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for items that can be blended.
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blends the object.
        /// </summary>
        /// <returns>Returns a string describing the blended object.</returns>
        string Blend();
    }
}
