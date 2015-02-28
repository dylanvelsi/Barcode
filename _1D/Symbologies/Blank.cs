﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Barcode._1D.Symbologies
{
    /// <summary>
    ///  Blank encoding template
    ///  Written by: Brad Barnhill
    /// </summary>
    class Blank: BarcodeCommon, IBarcode
    {
        
        #region IBarcode Members

        public string Encoded_Value
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
