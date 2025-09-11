namespace MPXJ.Net
{
    public class DefaultProjectListener : IProjectListener
    {
        public virtual void TaskRead(Task task) { }

        public virtual void TaskWritten(Task task) { }

        public virtual void ResourceRead(Resource resource) { }

        public virtual void ResourceWritten(Resource resource) { }

        public virtual void CalendarRead(ProjectCalendar calendar) { }

        public virtual void CalendarWritten(ProjectCalendar calendar) { }

        public virtual void AssignmentRead(ResourceAssignment assignment) { }

        public virtual void AssignmentWritten(ResourceAssignment assignment) { }

        public virtual void RelationRead(Relation relation) { }

        public virtual void RelationWritten(Relation relation) { }
    }
}