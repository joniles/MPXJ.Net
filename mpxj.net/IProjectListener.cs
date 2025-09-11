namespace MPXJ.Net
{
    public interface IProjectListener
    {
        void TaskRead(Task task);

        void TaskWritten(Task task);

        void ResourceRead(Resource resource);

        void ResourceWritten(Resource resource);

        void CalendarRead(ProjectCalendar calendar);

        void CalendarWritten(ProjectCalendar calendar);

        void AssignmentRead(ResourceAssignment assignment);

        void AssignmentWritten(ResourceAssignment assignment);

        void RelationRead(Relation relation);

        void RelationWritten(Relation relation);
    }
}