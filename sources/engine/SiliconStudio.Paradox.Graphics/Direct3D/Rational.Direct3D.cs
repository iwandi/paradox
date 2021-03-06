﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
#if SILICONSTUDIO_PARADOX_GRAPHICS_API_DIRECT3D 
// Copyright (c) 2011-2012 Silicon Studio

using System;

namespace SiliconStudio.Paradox.Graphics
{
    public partial struct Rational
    {
        /// <summary>
        /// Converts from SharpDX representation.
        /// </summary>
        /// <param name="rational">The rational.</param>
        /// <returns>Rational.</returns>
        internal static Rational FromSharpDX(SharpDX.DXGI.Rational rational)
        {
            return new Rational(rational.Numerator, rational.Denominator);
        }

        /// <summary>
        /// Converts to SharpDX representation.
        /// </summary>
        /// <returns>SharpDX.DXGI.Rational.</returns>
        internal SharpDX.DXGI.Rational ToSharpDX()
        {
            return new SharpDX.DXGI.Rational(Numerator, Denominator);
        }
    }
}
#endif