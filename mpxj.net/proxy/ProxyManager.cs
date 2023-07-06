﻿using System;
using System.Collections.Generic;

namespace org.mpxj.proxy
{
	internal class ProxyManager
	{
        private readonly Dictionary<object, object> _objectCache = new Dictionary<object, object>();
        internal ProjectFile ProjectFile { get; }

        public ProxyManager(ProjectFile projectFile)
        {
            ProjectFile = projectFile;
        }

        private N ProxyObject<M, N>(M o, Func<M, N> proxyFunction)
        {
            if (!_objectCache.ContainsKey(o))
            {
                _objectCache[o] = proxyFunction.Invoke(o);
            }

            return (N)_objectCache[o];
        }

        internal Resource ProxyObject(net.sf.mpxj.Resource value)
        {
            return ProxyObject(value, v => new Resource(this, v));
        }

        internal ProjectCalendarWeek ProxyObject(net.sf.mpxj.ProjectCalendarWeek value)
        {
            return ProxyObject(value, v => new ProjectCalendarWeek(this, v));
        }

        internal ProjectCalendarException ProxyObject(net.sf.mpxj.ProjectCalendarException value)
        {
            return ProxyObject(value, v => new ProjectCalendarException(this, v));
        }

        internal ProjectCalendar ProxyObject(net.sf.mpxj.ProjectCalendar value)
        {
            return ProxyObject(value, v => new ProjectCalendar(this, v));
        }

        internal RecurringData ProxyObject(net.sf.mpxj.RecurringData value)
        {
            return ProxyObject(value, v => new RecurringData(v));
        }

        internal RecurringTask ProxyObject(net.sf.mpxj.RecurringTask value)
        {
            return ProxyObject(value, v => new RecurringTask(v));
        }

        internal ProjectCalendarHours ProxyObject(net.sf.mpxj.ProjectCalendarHours value)
        {
            return ProxyObject(value, v => new ProjectCalendarHours(v));
        }

        internal ProjectConfig ProxyObject(net.sf.mpxj.ProjectConfig value)
        {
            return ProxyObject(value, v => new ProjectConfig(v));
        }

        internal ProjectProperties ProxyObject(net.sf.mpxj.ProjectProperties value)
        {
            return ProxyObject(value, v => new ProjectProperties(this, v));
        }

        internal ResourceContainer ProxyObject(net.sf.mpxj.ResourceContainer value)
        {
            return ProxyObject(value, v => new ResourceContainer(this, v));
        }

        internal TaskContainer ProxyObject(net.sf.mpxj.TaskContainer value)
        {
            return ProxyObject(value, v => new TaskContainer(this, v));
        }

        internal ResourceAssignmentContainer ProxyObject(net.sf.mpxj.ResourceAssignmentContainer value)
        {
            return ProxyObject(value, v => new ResourceAssignmentContainer(this, v));
        }

        internal ViewContainer ProxyObject(net.sf.mpxj.ViewContainer value)
        {
            return ProxyObject(value, v => new ViewContainer(v));
        }

        internal Task ProxyObject(net.sf.mpxj.Task value)
        {
            return ProxyObject(value, v => new Task(this, v));
        }

        internal ProjectFile ProxyObject(net.sf.mpxj.ProjectFile value)
        {
            return ProxyObject(value, v => new ProjectFile(v));
        }

        internal ResourceAssignment ProxyObject(net.sf.mpxj.ResourceAssignment value)
        {
            return ProxyObject(value, v => new ResourceAssignment(this, v));
        }

        internal ActivityCodeValue ProxyObject(net.sf.mpxj.ActivityCodeValue value)
        {
            return ProxyObject(value, v => new ActivityCodeValue(this, v));
        }

        internal ProjectCalendarContainer ProxyObject(net.sf.mpxj.ProjectCalendarContainer value)
        {
            return ProxyObject(value, v => new ProjectCalendarContainer(this, v));
        }

        internal TableContainer ProxyObject(net.sf.mpxj.TableContainer value)
        {
            return ProxyObject(value, v => new TableContainer(v));
        }

        internal FilterContainer ProxyObject(net.sf.mpxj.FilterContainer value)
        {
            return ProxyObject(value, v => new FilterContainer(v));
        }

        internal EventManager ProxyObject(net.sf.mpxj.EventManager value)
        {
            return ProxyObject(value, v => new EventManager(v));
        }

        internal GroupContainer ProxyObject(net.sf.mpxj.GroupContainer value)
        {
            return ProxyObject(value, v => new GroupContainer(v));
        }

        internal CustomFieldContainer ProxyObject(net.sf.mpxj.CustomFieldContainer value)
        {
            return ProxyObject(value, v => new CustomFieldContainer(v));
        }

        internal ActivityCodeContainer ProxyObject(net.sf.mpxj.ActivityCodeContainer value)
        {
            return ProxyObject(value, v => new ActivityCodeContainer(v));
        }

        internal DataLinkContainer ProxyObject(net.sf.mpxj.DataLinkContainer value)
        {
            return ProxyObject(value, v => new DataLinkContainer(v));
        }

        internal ExpenseCategoryContainer ProxyObject(net.sf.mpxj.ExpenseCategoryContainer value)
        {
            return ProxyObject(value, v => new ExpenseCategoryContainer(v));
        }

        internal CostAccountContainer ProxyObject(net.sf.mpxj.CostAccountContainer value)
        {
            return ProxyObject(value, v => new CostAccountContainer(v));
        }

        internal UserDefinedFieldContainer ProxyObject(net.sf.mpxj.UserDefinedFieldContainer value)
        {
            return ProxyObject(value, v => new UserDefinedFieldContainer(v));
        }

        internal WorkContourContainer ProxyObject(net.sf.mpxj.WorkContourContainer value)
        {
            return ProxyObject(value, v => new WorkContourContainer(v));
        }

        internal NotesTopicContainer ProxyObject(net.sf.mpxj.NotesTopicContainer value)
        {
            return ProxyObject(value, v => new NotesTopicContainer(v));
        }

        internal LocationContainer ProxyObject(net.sf.mpxj.LocationContainer value)
        {
            return ProxyObject(value, v => new LocationContainer(v));
        }

        internal object GenericProxyObject(object o)
        {
            if (o == null)
            {
                return null;
            }

            switch (o.GetType().AssemblyQualifiedName)
            {
                case "net.sf.mpxj.Resource":
                    return ProxyObject((net.sf.mpxj.Resource)o);

                case "net.sf.mpxj.Task":
                    return ProxyObject((net.sf.mpxj.Task)o);

                case "net.sf.mpxj.ResourceAssignment":
                    return ProxyObject((net.sf.mpxj.ResourceAssignment)o);

                case "net.sf.mpxj.ProjectCalendarWeek":
                    return ProxyObject((net.sf.mpxj.ProjectCalendarWeek)o);

                case "net.sf.mpxj.ProjectCalendarException":
                    return ProxyObject((net.sf.mpxj.ProjectCalendarException)o);

                case "net.sf.mpxj.ProjectCalendar":
                    return ProxyObject((net.sf.mpxj.ProjectCalendar)o);

                case "net.sf.mpxj.RecurringData":
                    return ProxyObject((net.sf.mpxj.RecurringData)o);

                case "net.sf.mpxj.ProjectCalendarHours":
                    return ProxyObject((net.sf.mpxj.ProjectCalendarHours)o);

            }

            return o;
        }

        internal IList<ProjectFile> ProxyProjectFileList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.ProjectFile, ProjectFile>(this, l));
        }

        internal IList<Resource> ProxyResourceList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.Resource, Resource>(this, l));
        }

        internal IList<Task> ProxyTaskList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.Task, Task>(this, l));
        }

        internal IList<ResourceAssignment> ProxyResourceAssignmentList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.ResourceAssignment, ResourceAssignment>(this, l));
        }

        internal IList<ActivityCodeValue> ProxyActivityCodeValueList(java.util.List value)
        {
            return ProxyObject(value, l => new DeepProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(this, l));
        }
    }
}
