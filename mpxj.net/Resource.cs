using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class Resource : AbstractFieldContainer, IProjectEntityWithID, IChildResourceContainer, IJavaObjectProxy<net.sf.mpxj.Resource>
    {
        public new net.sf.mpxj.Resource JavaObject => (net.sf.mpxj.Resource)base.JavaObject;

        internal Resource(ProxyManager proxyManager, net.sf.mpxj.Resource javaObject) : base(proxyManager, javaObject) { }

        public Resource AddResource() => _proxyManager.ProxyObject(JavaObject.addResource());

        public void AddChildResource(Resource child) => JavaObject.addChildResource(child.JavaObject);

        public IList<Resource> ChildResources => _proxyManager.ProxyList<net.sf.mpxj.Resource, Resource>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildResources());

        public void AddResourceAssignment(ResourceAssignment assignment) => JavaObject.addResourceAssignment(assignment.JavaObject);

        public IList<ResourceAssignment> TaskAssignments => _proxyManager.ProxyList<net.sf.mpxj.ResourceAssignment, ResourceAssignment>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTaskAssignments());

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public ResourceType? Type
        {
            get => JavaObject.getType().ConvertType();
            set => JavaObject.setType(value.ConvertType());
        }

        public bool Null => JavaObject.getNull();

        public string Initials
        {
            get => JavaObject.getInitials();
            set => JavaObject.setInitials(value);
        }

        public string Phonetics
        {
            get => JavaObject.getPhonetics();
            set => JavaObject.setPhonetics(value);
        }

        public string NtAccount
        {
            get => JavaObject.getNtAccount();
            set => JavaObject.setNtAccount(value);
        }

        public string MaterialLabel => JavaObject.getMaterialLabel();

        public string Code
        {
            get => JavaObject.getCode();
            set => JavaObject.setCode(value);
        }

        public string Group
        {
            get => JavaObject.getGroup();
            set => JavaObject.setGroup(value);
        }

        public WorkGroup? WorkGroup
        {
            get => JavaObject.getWorkGroup().ConvertType();
            set => JavaObject.setWorkGroup(value.ConvertType());
        }

        public string EmailAddress
        {
            get => JavaObject.getEmailAddress();
            set => JavaObject.setEmailAddress(value);
        }

        public string Hyperlink
        {
            get => JavaObject.getHyperlink();
            set => JavaObject.setHyperlink(value);
        }

        public string HyperlinkAddress
        {
            get => JavaObject.getHyperlinkAddress();
            set => JavaObject.setHyperlinkAddress(value);
        }

        public string HyperlinkSubAddress
        {
            get => JavaObject.getHyperlinkSubAddress();
            set => JavaObject.setHyperlinkSubAddress(value);
        }

        public string HyperlinkScreenTip
        {
            get => JavaObject.getHyperlinkScreenTip();
            set => JavaObject.setHyperlinkScreenTip(value);
        }

        public double? MaxUnits => JavaObject.getMaxUnits().ConvertType();

        public double? PeakUnits
        {
            get => JavaObject.getPeakUnits().ConvertType();
            set => JavaObject.setPeakUnits(value.ConvertType());
        }

        public bool OverAllocated
        {
            get => JavaObject.getOverAllocated();
            set => JavaObject.setOverAllocated(value);
        }

        public DateTime? AvailableFrom => JavaObject.getAvailableFrom().ConvertType();

        public DateTime? AvailableTo => JavaObject.getAvailableTo().ConvertType();

        public DateTime? Start => JavaObject.getStart().ConvertType();

        public DateTime? Finish => JavaObject.getFinish().ConvertType();

        public bool CanLevel
        {
            get => JavaObject.getCanLevel();
            set => JavaObject.setCanLevel(value);
        }

        public AccrueType? AccrueAt
        {
            get => JavaObject.getAccrueAt().ConvertType();
            set => JavaObject.setAccrueAt(value.ConvertType());
        }

        public Duration Work
        {
            get => _proxyManager.ProxyObject(JavaObject.getWork());
            set => JavaObject.setWork(value.JavaObject);
        }

        public Duration RegularWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRegularWork());
            set => JavaObject.setRegularWork(value.JavaObject);
        }

        public Duration ActualWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWork());
            set => JavaObject.setActualWork(value.JavaObject);
        }

        public Duration OvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getOvertimeWork());
            set => JavaObject.setOvertimeWork(value.JavaObject);
        }

        public Duration RemainingWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingWork());
            set => JavaObject.setRemainingWork(value.JavaObject);
        }

        public Duration ActualOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualOvertimeWork());
            set => JavaObject.setActualOvertimeWork(value.JavaObject);
        }

        public Duration RemainingOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingOvertimeWork());
            set => JavaObject.setRemainingOvertimeWork(value.JavaObject);
        }

        public double? PercentWorkComplete
        {
            get => JavaObject.getPercentWorkComplete().ConvertType();
            set => JavaObject.setPercentWorkComplete(value.ConvertType());
        }

        public Rate StandardRate => _proxyManager.ProxyObject(JavaObject.getStandardRate());

        public double? Cost
        {
            get => JavaObject.getCost().ConvertType();
            set => JavaObject.setCost(value.ConvertType());
        }

        public Rate OvertimeRate => _proxyManager.ProxyObject(JavaObject.getOvertimeRate());

        public double? OvertimeCost
        {
            get => JavaObject.getOvertimeCost().ConvertType();
            set => JavaObject.setOvertimeCost(value.ConvertType());
        }

        public double? CostPerUse => JavaObject.getCostPerUse().ConvertType();

        public double? ActualCost
        {
            get => JavaObject.getActualCost().ConvertType();
            set => JavaObject.setActualCost(value.ConvertType());
        }

        public double? ActualOvertimeCost
        {
            get => JavaObject.getActualOvertimeCost().ConvertType();
            set => JavaObject.setActualOvertimeCost(value.ConvertType());
        }

        public double? RemainingCost
        {
            get => JavaObject.getRemainingCost().ConvertType();
            set => JavaObject.setRemainingCost(value.ConvertType());
        }

        public double? RemainingOvertimeCost
        {
            get => JavaObject.getRemainingOvertimeCost().ConvertType();
            set => JavaObject.setRemainingOvertimeCost(value.ConvertType());
        }

        public Duration WorkVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkVariance());
            set => JavaObject.setWorkVariance(value.JavaObject);
        }

        public double? CostVariance
        {
            get => JavaObject.getCostVariance().ConvertType();
            set => JavaObject.setCostVariance(value.ConvertType());
        }

        public double? SV
        {
            get => JavaObject.getSV().ConvertType();
            set => JavaObject.setSV(value.ConvertType());
        }

        public double? CV
        {
            get => JavaObject.getCV().ConvertType();
            set => JavaObject.setCV(value.ConvertType());
        }

        public double? ACWP
        {
            get => JavaObject.getACWP().ConvertType();
            set => JavaObject.setACWP(value.ConvertType());
        }

        public string Notes
        {
            get => JavaObject.getNotes();
            set => JavaObject.setNotes(value);
        }

        public Notes NotesObject
        {
            get => _proxyManager.ProxyObject(JavaObject.getNotesObject());
            set => JavaObject.setNotesObject(value.JavaObject);
        }

        public double? BCWS
        {
            get => JavaObject.getBCWS().ConvertType();
            set => JavaObject.setBCWS(value.ConvertType());
        }

        public double? BCWP
        {
            get => JavaObject.getBCWP().ConvertType();
            set => JavaObject.setBCWP(value.ConvertType());
        }

        public bool Generic
        {
            get => JavaObject.getGeneric();
            set => JavaObject.setGeneric(value);
        }

        public bool Active
        {
            get => JavaObject.getActive();
            set => JavaObject.setActive(value);
        }

        public string ActiveDirectoryGUID
        {
            get => JavaObject.getActiveDirectoryGUID();
            set => JavaObject.setActiveDirectoryGUID(value);
        }

        public Duration ActualOvertimeWorkProtected
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualOvertimeWorkProtected());
            set => JavaObject.setActualOvertimeWorkProtected(value.JavaObject);
        }

        public Duration ActualWorkProtected
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWorkProtected());
            set => JavaObject.setActualWorkProtected(value.JavaObject);
        }

        public BookingType? BookingType
        {
            get => JavaObject.getBookingType().ConvertType();
            set => JavaObject.setBookingType(value.ConvertType());
        }

        public DateTime? CreationDate
        {
            get => JavaObject.getCreationDate().ConvertType();
            set => JavaObject.setCreationDate(value.ConvertType());
        }

        public bool Enterprise
        {
            get => JavaObject.getEnterprise();
            set => JavaObject.setEnterprise(value);
        }

        public int? CalendarUniqueID
        {
            get => JavaObject.getCalendarUniqueID().ConvertType();
            set => JavaObject.setCalendarUniqueID(value.ConvertType());
        }

        public ProjectCalendar Calendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getCalendar());
            set => JavaObject.setCalendar(value.JavaObject);
        }

        public ProjectCalendar AddCalendar() => _proxyManager.ProxyObject(JavaObject.addCalendar());

        public void SetText(int index, string value) => JavaObject.setText(index, value);

        public string GetText(int index) => JavaObject.getText(index);

        public string BaseCalendar
        {
            get => JavaObject.getBaseCalendar();
            set => JavaObject.setBaseCalendar(value);
        }

        public double? BaselineCost
        {
            get => JavaObject.getBaselineCost().ConvertType();
            set => JavaObject.setBaselineCost(value.ConvertType());
        }

        public Duration BaselineWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineWork());
            set => JavaObject.setBaselineWork(value.JavaObject);
        }

        public int? ID
        {
            get => JavaObject.getID().ConvertType();
            set => JavaObject.setID(value.ConvertType());
        }

        public bool LinkedFields
        {
            get => JavaObject.getLinkedFields();
            set => JavaObject.setLinkedFields(value);
        }

        public int? Objects
        {
            get => JavaObject.getObjects().ConvertType();
            set => JavaObject.setObjects(value.ConvertType());
        }

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public int? ParentResourceUniqueID
        {
            get => JavaObject.getParentResourceUniqueID().ConvertType();
            set => JavaObject.setParentResourceUniqueID(value.ConvertType());
        }

        public Resource ParentResource
        {
            get => _proxyManager.ProxyObject(JavaObject.getParentResource());
            set => JavaObject.setParentResource(value.JavaObject);
        }

        public void SetStart(int index, DateTime value) => JavaObject.setStart(index, value.ConvertType());

        public DateTime? GetStart(int index) => JavaObject.getStart(index).ConvertType();

        public void SetFinish(int index, DateTime value) => JavaObject.setFinish(index, value.ConvertType());

        public DateTime? GetFinish(int index) => JavaObject.getFinish(index).ConvertType();

        public void SetNumber(int index, double? value) => JavaObject.setNumber(index, value.ConvertType());

        public double? GetNumber(int index) => JavaObject.getNumber(index).ConvertType();

        public void SetDuration(int index, Duration value) => JavaObject.setDuration(index, value.JavaObject);

        public Duration GetDuration(int index) => _proxyManager.ProxyObject(JavaObject.getDuration(index));

        public void SetDate(int index, DateTime value) => JavaObject.setDate(index, value.ConvertType());

        public DateTime? GetDate(int index) => JavaObject.getDate(index).ConvertType();

        public void SetCost(int index, double? value) => JavaObject.setCost(index, value.ConvertType());

        public double? GetCost(int index) => JavaObject.getCost(index).ConvertType();

        public void SetFlag(int index, bool value) => JavaObject.setFlag(index, value);

        public bool GetFlag(int index) => JavaObject.getFlag(index);

        public void SetOutlineCode(int index, string value) => JavaObject.setOutlineCode(index, value);

        public string GetOutlineCode(int index) => JavaObject.getOutlineCode(index);

        public void Remove() => JavaObject.remove();

        public object GetFieldByAlias(string alias) => _proxyManager.GenericProxyObject(JavaObject.getFieldByAlias(alias));

        public void SetFieldByAlias(string alias, object value) => JavaObject.setFieldByAlias(alias, value.GenericJavaObject());

        public int? SubprojectResourceUniqueID
        {
            get => JavaObject.getSubprojectResourceUniqueID().ConvertType();
            set => JavaObject.setSubprojectResourceUniqueID(value.ConvertType());
        }

        public double? GetEnterpriseCost(int index) => JavaObject.getEnterpriseCost(index).ConvertType();

        public void SetEnterpriseCost(int index, double? value) => JavaObject.setEnterpriseCost(index, value.ConvertType());

        public DateTime? GetEnterpriseDate(int index) => JavaObject.getEnterpriseDate(index).ConvertType();

        public void SetEnterpriseDate(int index, DateTime value) => JavaObject.setEnterpriseDate(index, value.ConvertType());

        public Duration GetEnterpriseDuration(int index) => _proxyManager.ProxyObject(JavaObject.getEnterpriseDuration(index));

        public void SetEnterpriseDuration(int index, Duration value) => JavaObject.setEnterpriseDuration(index, value.JavaObject);

        public bool GetEnterpriseFlag(int index) => JavaObject.getEnterpriseFlag(index);

        public void SetEnterpriseFlag(int index, bool value) => JavaObject.setEnterpriseFlag(index, value);

        public double? GetEnterpriseNumber(int index) => JavaObject.getEnterpriseNumber(index).ConvertType();

        public void SetEnterpriseNumber(int index, double? value) => JavaObject.setEnterpriseNumber(index, value.ConvertType());

        public string GetEnterpriseText(int index) => JavaObject.getEnterpriseText(index);

        public void SetEnterpriseText(int index, string value) => JavaObject.setEnterpriseText(index, value);

        public void SetBaselineCost(int baselineNumber, double? value) => JavaObject.setBaselineCost(baselineNumber, value.ConvertType());

        public void SetBaselineWork(int baselineNumber, Duration value) => JavaObject.setBaselineWork(baselineNumber, value.JavaObject);

        public double? GetBaselineCost(int baselineNumber) => JavaObject.getBaselineCost(baselineNumber).ConvertType();

        public Duration GetBaselineWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineWork(baselineNumber));

        public bool Budget
        {
            get => JavaObject.getBudget();
            set => JavaObject.setBudget(value);
        }

        public Guid? GUID
        {
            get => JavaObject.getGUID().ConvertType();
            set => JavaObject.setGUID(value.ConvertType());
        }

        public string Unit
        {
            get => JavaObject.getUnit();
            set => JavaObject.setUnit(value);
        }

        public string SupplyReference
        {
            get => JavaObject.getSupplyReference();
            set => JavaObject.setSupplyReference(value);
        }

        public string Description
        {
            get => JavaObject.getDescription();
            set => JavaObject.setDescription(value);
        }

        public string ResourceID
        {
            get => JavaObject.getResourceID();
            set => JavaObject.setResourceID(value);
        }

        public bool ModifyOnIntegrate
        {
            get => JavaObject.getModifyOnIntegrate();
            set => JavaObject.setModifyOnIntegrate(value);
        }

        public bool ExpensesOnly
        {
            get => JavaObject.getExpensesOnly();
            set => JavaObject.setExpensesOnly(value);
        }

        public double? PeriodDur
        {
            get => JavaObject.getPeriodDur().ConvertType();
            set => JavaObject.setPeriodDur(value.ConvertType());
        }

        public double? Priority
        {
            get => JavaObject.getPriority().ConvertType();
            set => JavaObject.setPriority(value.ConvertType());
        }

        public double? Rate
        {
            get => JavaObject.getRate().ConvertType();
            set => JavaObject.setRate(value.ConvertType());
        }

        public double? Pool
        {
            get => JavaObject.getPool().ConvertType();
            set => JavaObject.setPool(value.ConvertType());
        }

        public double? PerDay
        {
            get => JavaObject.getPerDay().ConvertType();
            set => JavaObject.setPerDay(value.ConvertType());
        }

        public string Phone
        {
            get => JavaObject.getPhone();
            set => JavaObject.setPhone(value);
        }

        public bool Role
        {
            get => JavaObject.getRole();
            set => JavaObject.setRole(value);
        }

        public void SetCostRateTable(int index, CostRateTable crt) => JavaObject.setCostRateTable(index, crt.JavaObject);

        public CostRateTable GetCostRateTable(int index) => _proxyManager.ProxyObject(JavaObject.getCostRateTable(index));

        public CostRateTableEntry GetCurrentCostRateTableEntry(int costRateTable) => _proxyManager.ProxyObject(JavaObject.getCurrentCostRateTableEntry(costRateTable));

        public AvailabilityTable Availability => _proxyManager.ProxyObject(JavaObject.getAvailability());

        public double? BudgetCost
        {
            get => JavaObject.getBudgetCost().ConvertType();
            set => JavaObject.setBudgetCost(value.ConvertType());
        }

        public Duration BudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBudgetWork());
            set => JavaObject.setBudgetWork(value.JavaObject);
        }

        public double? BaselineBudgetCost
        {
            get => JavaObject.getBaselineBudgetCost().ConvertType();
            set => JavaObject.setBaselineBudgetCost(value.ConvertType());
        }

        public Duration BaselineBudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork());
            set => JavaObject.setBaselineBudgetWork(value.JavaObject);
        }

        public double? GetBaselineBudgetCost(int baselineNumber) => JavaObject.getBaselineBudgetCost(baselineNumber).ConvertType();

        public void SetBaselineBudgetCost(int baselineNumber, double? value) => JavaObject.setBaselineBudgetCost(baselineNumber, value.ConvertType());

        public Duration GetBaselineBudgetWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork(baselineNumber));

        public void SetBaselineBudgetWork(int baselineNumber, Duration value) => JavaObject.setBaselineBudgetWork(baselineNumber, value.JavaObject);

        public string CostCenter
        {
            get => JavaObject.getCostCenter();
            set => JavaObject.setCostCenter(value);
        }

        public bool CalculateCostsFromUnits
        {
            get => JavaObject.getCalculateCostsFromUnits();
            set => JavaObject.setCalculateCostsFromUnits(value);
        }

        public int? SequenceNumber
        {
            get => JavaObject.getSequenceNumber().ConvertType();
            set => JavaObject.setSequenceNumber(value.ConvertType());
        }

        public int? LocationUniqueID
        {
            get => JavaObject.getLocationUniqueID().ConvertType();
            set => JavaObject.setLocationUniqueID(value.ConvertType());
        }

        public Location Location
        {
            get => _proxyManager.ProxyObject(JavaObject.getLocation());
            set => JavaObject.setLocation(value.JavaObject);
        }
    }
}
