﻿using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.SortingAlgorithms
{
    class Delegation
    {
        //Source: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates

        //create a delegate
        public delegate void SortingDelegate(List<Tshirt> tshirts);
    }
}
