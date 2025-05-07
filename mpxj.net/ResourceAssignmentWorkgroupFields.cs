using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceAssignmentWorkgroupFields : IJavaObjectProxy<org.mpxj.ResourceAssignmentWorkgroupFields>
    {
        public org.mpxj.ResourceAssignmentWorkgroupFields JavaObject { get; }

        internal ResourceAssignmentWorkgroupFields(org.mpxj.ResourceAssignmentWorkgroupFields javaObject)
        {
            JavaObject = javaObject;
        }

        public string MessageUniqueID
        {
            get => JavaObject.getMessageUniqueID();
            set => JavaObject.setMessageUniqueID(value);
        }

        public bool Confirmed
        {
            get => JavaObject.getConfirmed();
            set => JavaObject.setConfirmed(value);
        }

        public bool ResponsePending
        {
            get => JavaObject.getResponsePending();
            set => JavaObject.setResponsePending(value);
        }

        public DateTime? UpdateStart
        {
            get => JavaObject.getUpdateStart().ConvertType();
            set => JavaObject.setUpdateStart(value.ConvertType());
        }

        public DateTime? UpdateFinish
        {
            get => JavaObject.getUpdateFinish().ConvertType();
            set => JavaObject.setUpdateFinish(value.ConvertType());
        }

        public string ScheduleID
        {
            get => JavaObject.getScheduleID();
            set => JavaObject.setScheduleID(value);
        }
    }
}

