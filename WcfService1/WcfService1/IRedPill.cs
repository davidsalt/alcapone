﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    /// <summary>
    /// Represents the Red Pill service contract.
    /// </summary>
    [ServiceContract(Namespace = "http://KnockKnock.readify.net", Name = "IRedPill")]
    public interface IRedPill
    {
        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        long FibonacciNumber(long n);

        [OperationContract]
        string ReverseWords(string s);

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);
    }

    [DataContract]
    public enum TriangleType
    {
        [EnumMember]
        Error,
        [EnumMember]
        Equilateral,
        [EnumMember]
        Isosceles,
        [EnumMember]
        Scalene
    }
}
