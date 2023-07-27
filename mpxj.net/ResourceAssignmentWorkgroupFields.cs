using System;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ResourceAssignmentWorkgroupFields : IJavaObjectProxy<net.sf.mpxj.ResourceAssignmentWorkgroupFields>
    {
        public net.sf.mpxj.ResourceAssignmentWorkgroupFields JavaObject { get; }

        internal ResourceAssignmentWorkgroupFields(net.sf.mpxj.ResourceAssignmentWorkgroupFields javaObject)
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

