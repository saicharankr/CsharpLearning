using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearning
{
    #region Declaring Custom Attribute

    [AttributeUsage(
   AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]

    #endregion Declaring Custom Attribute

    public class DebugInfo : System.Attribute
    {
        public int bugNo;
        public string developer;
        public string lastReview;
        public string message;

        public DebugInfo(int bgNo, string dev, string d)
        {
            bugNo = bgNo;
            developer = dev;
            lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }

        public string Developer
        {
            get
            {
                return developer;
            }
        }

        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
}