using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectContext : IJavaObjectProxy<org.mpxj.ProjectContext>
    {
        internal readonly ProxyManager _proxyManager;
        public org.mpxj.ProjectContext JavaObject { get; }

        internal ProjectContext(ProxyManager proxyManager, org.mpxj.ProjectContext javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }
        
        public LocationContainer Locations => _proxyManager.ProxyObject(JavaObject.getLocations());
        
        public UnitOfMeasureContainer UnitsOfMeasure => _proxyManager.ProxyObject(JavaObject.getUnitsOfMeasure());

        public ExpenseCategoryContainer ExpenseCategories => _proxyManager.ProxyObject(JavaObject.getExpenseCategories());
        
        public CostAccountContainer CostAccounts => _proxyManager.ProxyObject(JavaObject.getCostAccounts());
        
        public WorkContourContainer WorkContours => _proxyManager.ProxyObject(JavaObject.getWorkContours());
        
        public NotesTopicContainer NotesTopics => _proxyManager.ProxyObject(JavaObject.getNotesTopics());
        
        public CustomFieldContainer CustomFields => _proxyManager.ProxyObject(JavaObject.getCustomFields());
        
        public UserDefinedFieldContainer UserDefinedFields => _proxyManager.ProxyObject(JavaObject.getUserDefinedFields());
        
        public ActivityCodeContainer ActivityCodes => _proxyManager.ProxyObject(JavaObject.getActivityCodes());
        
        public ProjectCodeContainer ProjectCodes => _proxyManager.ProxyObject(JavaObject.getProjectCodes());
        
        public ResourceCodeContainer ResourceCodes => _proxyManager.ProxyObject(JavaObject.getResourceCodes());

        public RoleCodeContainer RoleCodes => _proxyManager.ProxyObject(JavaObject.getRoleCodes());
        
        public ResourceAssignmentCodeContainer ResourceAssignmentCodes => _proxyManager.ProxyObject(JavaObject.getResourceAssignmentCodes());

        public ShiftContainer Shifts => _proxyManager.ProxyObject(JavaObject.getShifts());

        public ShiftPeriodContainer ShiftPeriods => _proxyManager.ProxyObject(JavaObject.getShiftPeriods());
        
        public CurrencyContainer Currencies => _proxyManager.ProxyObject(JavaObject.getCurrencies());

        public ProjectCalendarContainer Calendars => _proxyManager.ProxyObject(JavaObject.getCalendars());
        
        public ResourceContainer Resources => _proxyManager.ProxyObject(JavaObject.getResources());
        
        public IList<ProjectFile> Projects => _proxyManager.ProxyList<org.mpxj.ProjectFile, ProjectFile>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getProjects());
        
        public TimeUnitDefaults TimeUnitDefaults => _proxyManager.ProxyObject(JavaObject.getTimeUnitDefaults());
        
        public ProjectConfig ProjectConfig => _proxyManager.ProxyObject(JavaObject.getProjectConfig());
    }
}