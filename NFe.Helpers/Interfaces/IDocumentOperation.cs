﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Helpers.Interfaces
{
    public interface IDocumentOperation<T> where T:class, IDeserializeOperation, ISerializeOperation
    {

    }
}
